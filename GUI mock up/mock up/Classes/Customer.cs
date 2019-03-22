using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mock_up
{
    class Customer : User
    {
        public Customer(string u) : base(u)
        {

        }

        protected override string getQueary()
        {
            string s = "SELECT * FROM Customer WHERE username=@username";
            return s;
        }

        protected override void copyInfo()
        {
            username = userData["username"].ToString();
            pass = userData["pass"].ToString();
            email = userData["email"].ToString();
            username = username.Replace(" ", "");
            pass = pass.Replace(" ", "");
            email = email.Replace(" ", "");
        }
    }
}
