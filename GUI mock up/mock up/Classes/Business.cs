using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mock_up
{
    public class Business : User
    {
        Aes_Encryption aes = new Aes_Encryption();
        public int openHour;
        public int closeHour;
        public string busType;
        public string busName;

        //used for logging in
        public Business(string u) : base(u)
        {

        }

        //constructor used for making a new account
        public Business(string u, string p, string e, string o, string c, string t, string n) : base(u)
        {
            //sense we use the username to download info in our base constructor
            //if there is any info that means the account already exists
            if (pass != null)
                throw new System.InvalidOperationException("An account already exists with this username");
            else
            {
                string OldPassword = p;
                p = aes.Encrypt(p, OldPassword);
                u = aes.Encrypt(u, OldPassword);
                e = aes.Encrypt(e, OldPassword);
                //MessageBox.Show(aes.Encrypt(p,p));
                //MessageBox.Show(aes.Encrypt(u,p));
                //MessageBox.Show(aes.Encrypt(e,p));

                //MessageBox.Show(aes.Decrypt(p));
                //MessageBox.Show(aes.Decrypt(u));
                //MessageBox.Show(aes.Decrypt(e));s
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
            email = Email.Replace(" ", "");
            busName = busName.Replace(" ", "");
            busType = busType.Replace(" ", "");
        }

        //creates business in database by calling on the controller
        protected override void Create()
        {
            dB.CreateBus(username, pass, Email, openHour, closeHour, busType, busName);
        }
    }
}
