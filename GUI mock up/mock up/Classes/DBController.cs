using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mock_up.Classes
{
    public class DBController
    {
        private SqlConnection con = new SqlConnection("Data Source=quickerproject.database.windows.net;Initial Catalog=Userbase;Persist Security Info=True;User ID=user;Password=Mwsu1234");
        private SqlDataReader userData;
        public DBController()
        {

        }

        //used to search all bussiness and get results based on passed query
        public DataTable SearchBus(string query)
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

        //used to create orders in the queue
        public void CreateOrder(string customer, string business)
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
        public void CreateBus(string username, string pass, string email, int openHour, int closeHour, string busType, string busName)
        {
            //create a queary and fill it with info
            SqlCommand create = con.CreateCommand();
            create.CommandText = "INSERT INTO Business VALUES (@username, @pass, @email, @oh, @ch, @type, @name)";
            create.Parameters.AddWithValue("@username", username);
            create.Parameters.AddWithValue("@pass", pass);
            create.Parameters.AddWithValue("@email", email);
            create.Parameters.AddWithValue("@oh", openHour);
            create.Parameters.AddWithValue("@ch", closeHour);
            create.Parameters.AddWithValue("@type", busType);
            create.Parameters.AddWithValue("@name", busName);

            //exectue query
            con.Open();
            create.ExecuteNonQuery();
            con.Close();
        }

        public string CustEmail(string name)
        {
            Customer cust = new Customer(name);
            string e = cust.Email;
            return e;
        }
    }
}
