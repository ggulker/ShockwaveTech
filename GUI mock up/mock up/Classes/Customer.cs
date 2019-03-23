using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mock_up
{
    class Customer : User
    {
        public Customer(string u) : base(u)
        {

        }

        public Customer(string u, string p, string e):base(u)
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
                Create();
            }
        }

        protected override string GetQueary()
        {
            string s = "SELECT * FROM Customer WHERE username=@username";
            return s;
        }

        protected override void CopyInfo()
        {
            username = userData["username"].ToString();
            pass = userData["pass"].ToString();
            email = userData["email"].ToString();
            username = username.Replace(" ", "");
            pass = pass.Replace(" ", "");
            email = email.Replace(" ", "");
        }

        protected override void Create()
        {

            SqlCommand create = con.CreateCommand();
            create.CommandText = "INSERT INTO Customer VALUES (";
            string u = "'" + username + "', ";
            string p = "'" + pass + "', ";
            string e = "'" + email + "')";
            create.CommandText += u + p + e;
            con.Open();
            create.ExecuteNonQuery();
            con.Close();
        }
    }
}
