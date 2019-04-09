using mock_up.Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mock_up
{
    public abstract class User
    {
        protected string username;
        protected string pass = null;
        protected string email;
        protected SqlDataReader userData;
        //creates a connection to our database
        protected DBController dB = new DBController();
        protected SqlConnection con = new SqlConnection
            ("Data Source=quickerproject.database.windows.net;Initial Catalog=Userbase;Persist Security Info=True;User ID=user;Password=Mwsu1234");
        public User(string u)
        {
            //gets all info on passed in username
            Download(u);
        }

        //getter for email
        public string Email
        {
            get
            {
                return email;
            }
        }

        //getter for username
        public string Username
        {
            get
            {
                return username;
            }
        }

        //gets all our customer or business info from the server
        protected void Download(string user)
        {

            //creates a command that will hold our query
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = GetQueary();
            //replaces @username in our query with specified username
            cmd.Parameters.AddWithValue("@username", user);

            con.Open();
            //get info 
            SqlDataReader r = cmd.ExecuteReader();
            //checks to see if it found anything
            if (r.Read())
            {
                userData = r;
                CopyInfo();
            }
            con.Close();
        }

        //gets the queary were running 
        virtual protected string GetQueary()
        {
            return "";
        }

        //copy all data from queary to class
        virtual protected void CopyInfo()
        {

        }

        //used to create accounts for both user types
        //done by creating a command INSERT and adding all user input info
        virtual protected void Create()
        {

        }

        //password check
        virtual public bool PassCheck(string given)
        {
            if (given == pass)
                return true;
            else
                return false;
        }
    }

}
