using mock_up.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mock_up
{
    public partial class Login : Form
    {
        //used to see what button they pressed on the choice form
        char type;

        public Login(char t)
        {
            type = t;
            InitializeComponent();
        }

        private void loginBut_Click(object sender, EventArgs e)
        {
            bool pass = loginCheck();
            //checks if it logged in
            if (pass)
                //wether its a business or customer
                if (type == 'B')
                {
                    BusHome bus = new BusHome(usernameText.Text);
                    bus.Show();
                    this.Close();
                }
                else
                {
                    Search search = new Search(usernameText.Text);
                    search.Show();
                    this.Close();
                }
            else
                MessageBox.Show("Username/Password may be wrong please try again.");
        }
        
        //connects to the database and sees if our username has a password and if it matches
        private bool loginCheck()
        {
            //holds the username passed in
            string user = usernameText.Text;
            //creates a connection to our database
            SqlConnection con = new SqlConnection("Data Source=shockwave.database.windows.net;Initial Catalog=Quicker Queue;;User ID=user;Password=Mwsu1234");
            //creates a command that will hold our query
            SqlCommand cmd = con.CreateCommand();

            if (type == 'B')
            {
                //holds passed in password from database
                string dataPass = string.Empty;
                //query we send in
                cmd.CommandText = "SELECT pass FROM Business WHERE username=@username";
                //replaces @username in our query with specified username
                cmd.Parameters.AddWithValue("@username", user);
                con.Open();
                //get info 
                var r = cmd.ExecuteReader();
                //checks if the username had anything in the database
                if (r.Read())
                {
                    //compare the typed in password with our database
                    string pass = passText.Text;
                    string d = r["pass"].ToString();
                    //password has weird empty spaces so this gets rid of those
                    dataPass= d.Replace(" ", "");
                    if (dataPass == pass)
                        return true;
                    else
                        return false;
                }
                else
                    return false;
            }
            else
            {
                //all the same just for a customer not a business
                string dataPass = string.Empty;

                cmd.CommandText = "SELECT pass FROM Customer WHERE username=@username";
                cmd.Parameters.AddWithValue("@username", user);
                con.Open();
                var r = cmd.ExecuteReader();
                if (r.Read())
                {
                    string pass = passText.Text;
                    string d = r["pass"].ToString();
                    dataPass = d.Replace(" ", "");
                    if (dataPass == pass)
                        return true;
                    else
                        return false;
                }
                else
                    return false;
            }
        }
    }
}
