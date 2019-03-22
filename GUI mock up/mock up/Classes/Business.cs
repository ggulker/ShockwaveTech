using System;
using System.Collections.Generic;
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

        //creates user specific queary for our search
        protected override string getQueary()
        {
            string s = "SELECT * FROM Business WHERE username=@username";
            return s;
        }

        //copies info specifically needed for this class
        protected override void copyInfo()
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
    }
}
