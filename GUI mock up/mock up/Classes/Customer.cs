using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/// <summary>
/// a customer user creates this class and uses it throughout the program
/// </summary>
namespace mock_up
{
    public class Customer : User
    {
        public Customer(string u, string p) : base(u,p)
        {

        }

        //called when making a new customer
        public Customer(string u, string p, string e):base(u,p)
        {
            //sense we use the username to download info in our base constructor
            //if there is any info that means the account already exists
            if (pass != null)
                throw new System.InvalidOperationException("An account already exists with this username");
            else
            {
                p = aes.Encrypt(p, OldPassword);
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
            dB.CreateCust(username, pass, email);
        }
    }
}
