using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mock_up
{
    abstract class User
    {
        protected string username;
        protected string pass;
        protected string email;
        protected SqlDataReader userData;
        public User(string u)
        {
            //gets all info on passed in username
            Download(u);
        }

        //gets all our customer or business info from the server
        protected void Download(string user)
        {
            //creates a connection to our database
            SqlConnection con = new SqlConnection("Data Source=shockwave.database.windows.net;Initial Catalog=Quicker Queue;;User ID=user;Password=Mwsu1234");
            //creates a command that will hold our query
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = getQueary();
            //replaces @username in our query with specified username
            cmd.Parameters.AddWithValue("@username", user);

            con.Open();
            //get info 
            SqlDataReader r = cmd.ExecuteReader();
            //checks to see if it found anything
            if (r.Read())
            {
                userData = r;
                copyInfo();
            }
            con.Close();
        }

        //gets the queary were running 
        virtual protected string getQueary()
        {
            return "";
        }

        //copy all data from queary to class
        virtual protected void copyInfo()
        {

        }

        //password check
        virtual public bool passCheck(string given)
        {
            if (given == pass)
                return true;
            else
                return false;
        }
    }

}
