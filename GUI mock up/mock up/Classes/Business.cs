using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mock_up
{
    class Business : User
    {
        public int openHour;
        public int closeHour;
        public string busType;
        public string busName;

        public Business(string u) : base(u)
        {

        }

        public Business(string u, string p, string e, string o, string c, string t, string n) : base(u)
        {
            //sense we use the username to download info in our base constructor
            //if there is any info that means the account already exists
            if (pass != null)
                throw new System.InvalidOperationException("An account already exists with this username");
            else
            {
                pass = p;
                username = u;
                email = e;
                closeHour = Convert.ToInt32(c);
                openHour = Convert.ToInt32(o);
                busType = t;
                busName = n;
                Create();
            }
        }

        //creates user specific queary for our search
        protected override string GetQueary()
        {
            string s = "SELECT * FROM Business WHERE username=@username";
            return s;
        }

        //copies info specifically needed for this class
        protected override void CopyInfo()
        {
            //grabs the info from our data reader
            username = userData["username"].ToString();
            pass = userData["pass"].ToString();
            email = userData["email"].ToString();
            busName = userData["BusName"].ToString();
            busType = userData["BusType"].ToString();
            openHour = Convert.ToInt16(userData["openHour"].ToString());
            closeHour = Convert.ToInt16(userData["closeHour"].ToString());
            //all strings returned have alot of empty spaces removing those
            username = username.Replace(" ", "");
            pass = pass.Replace(" ", "");
            email = email.Replace(" ", "");
            busName = busName.Replace(" ", "");
            busType = busType.Replace(" ", "");
        }

        protected override void Create()
        {
            SqlCommand create = con.CreateCommand();
            create.CommandText = "INSERT INTO Business VALUES (";
            string u = "'" + username + "', ";
            string p = "'" + pass + "', ";
            string e = "'" + email + "', ";
            string o = openHour.ToString() + ", ";
            string c = closeHour.ToString() + ", ";
            string t = "'" + busType + "', ";
            string n = "'" + busName + "')";
            create.CommandText += u + p + e + o + c + t + n;
            con.Open();
            create.ExecuteNonQuery();
            con.Close();
        }
    }
}
