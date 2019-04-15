using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// controller used for any database calls 
/// </summary>
namespace mock_up.Classes
{
    public class DBController
    {
        private SqlConnection con = new SqlConnection
            ("Data Source=quickerproject.database.windows.net;Initial Catalog=Userbase;Persist Security Info=True;User ID=user;Password=Mwsu1234");
        public DBController()
        {

        }

        //used to search all bussiness and get results based on passed query
        public DataTable GetTable(string query)
        {
            SqlDataAdapter adapt;
            DataTable dt;
            
            con.Open();
            adapt = new SqlDataAdapter(query, con);
            dt = new DataTable();
            //fill new tables with query results
            adapt.Fill(dt);
            con.Close();
            //return table 
            return dt;
        }

        //insert into favorites table
        public void CreateFavorite(string customer, string business)
        {
            //creates query
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "INSERT INTO Favorites VALUES(@customer, @business)";
            cmd.Parameters.AddWithValue("@customer", customer);
            cmd.Parameters.AddWithValue("@business", business);

            //execute query
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        //inserts a business into the table
        public void CreateBus(string username, string pass, string email, int openHour, int closeHour, string busType, string busName, string emailpass)
        {
            //create a queary and fill it with info
            SqlCommand create = con.CreateCommand();
            create.CommandText = "INSERT INTO Business VALUES (@username, @pass, @email, @oh, @ch, @type, @name, @ep)";
            create.Parameters.AddWithValue("@username", username);
            create.Parameters.AddWithValue("@pass", pass);
            create.Parameters.AddWithValue("@email", email);
            create.Parameters.AddWithValue("@oh", openHour);
            create.Parameters.AddWithValue("@ch", closeHour);
            create.Parameters.AddWithValue("@type", busType);
            create.Parameters.AddWithValue("@name", busName);
            create.Parameters.AddWithValue("@ep", emailpass);
            //exectue query
            con.Open();
            create.ExecuteNonQuery();
            con.Close();
        }

        //inserts a customer into table
        public void CreateCust(string username, string pass, string email)
        {
            //create a queary and fill it with info
            SqlCommand create = con.CreateCommand();
            create.CommandText = "INSERT INTO Customer VALUES (@username, @pass, @email)";
            create.Parameters.AddWithValue("@username", username);
            create.Parameters.AddWithValue("@pass", pass);
            create.Parameters.AddWithValue("@email", email);

            //exectue query
            con.Open();
            create.ExecuteNonQuery();
            con.Close();
        }

        //inserts into orders table
        public void CreateOrder(string customer, string business, string name, int time)
        {
            //creates query
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "INSERT INTO Orders VALUES(@customer, @business, @name, @time)";
            cmd.Parameters.AddWithValue("@customer", customer);
            cmd.Parameters.AddWithValue("@business", business);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@time", time);
            //execute query
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        //retrieve the email of a customer
        public string CustEmail(string name)
        {
            string e = "";
            //create query to get email
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "SELECT * FROM Customer WHERE username=@username";
            //name has large empty spaces
            name = name.Replace(" ", "");
            cmd.Parameters.AddWithValue("@username", name);

            //execute query and grab email
            con.Open();
            SqlDataReader r = cmd.ExecuteReader();
            if (r.Read())
            {
                e = r["email"].ToString();
            }
            r.Close();
            con.Close();

            //more empty space
            e = e.Replace(" ", "");
            return e;
        }

        //remove from Orders table
        public void RemoveOrder(string customer, string business)
        {
            SqlCommand remove = con.CreateCommand();
            remove.CommandText = "DELETE FROM Orders WHERE customer=@customer AND business=@business";
            remove.Parameters.AddWithValue("@customer", customer);
            remove.Parameters.AddWithValue("@business", business);

            //exectue query
            con.Open();
            remove.ExecuteNonQuery();
            con.Close();
        }

        //removes any customer account by username
        public void RemoveCustAccount(string user)
        {
            SqlCommand remove = con.CreateCommand();
            remove.CommandText = "DELETE FROM Customer WHERE username = @username";
            remove.Parameters.AddWithValue("@username", user);
            con.Open();
            remove.ExecuteNonQuery();
            con.Close();
        }

        //removes any business account by username
        public void RemoveBusAccount(string user)
        {
            SqlCommand remove = con.CreateCommand();
            remove.CommandText = "DELETE FROM Business WHERE username = @username";
            remove.Parameters.AddWithValue("@username", user);
            con.Open();
            remove.ExecuteNonQuery();
            con.Close();
        }

        //changes a customer account info with an update sql
        public void ChangeCustAccount(string oUsername, string username, string email)
        {
            SqlCommand remove = con.CreateCommand();
            remove.CommandText = "UPDATE Customer SET username = @newu, email = @newe WHERE username = @username";
            remove.Parameters.AddWithValue("@username", oUsername);
            remove.Parameters.AddWithValue("@newu", username);
            remove.Parameters.AddWithValue("@newe", email);
            con.Open();
            remove.ExecuteNonQuery();
            con.Close();
        }

        //changes a business account info with an update sql
        public void ChangeBusAccount(string oUsername, string username, string email, string openH, string closeH, string busName, string busType)
        {
            SqlCommand remove = con.CreateCommand();
            remove.CommandText = "UPDATE Business SET username = @newu, email = @newe, openHour = @openH, closeHour = @closeH, BusType = @type, BusName = @name WHERE username = @username";
            remove.Parameters.AddWithValue("@username", oUsername);
            remove.Parameters.AddWithValue("@newu", username);
            remove.Parameters.AddWithValue("@newe", email);
            remove.Parameters.AddWithValue("@openH",Convert.ToInt16(openH));
            remove.Parameters.AddWithValue("@closeH", Convert.ToInt16(closeH));
            remove.Parameters.AddWithValue("@name", busName);
            remove.Parameters.AddWithValue("@type", busType);
            con.Open();
            remove.ExecuteNonQuery();
            con.Close();
        }
    }
}
