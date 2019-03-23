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

            if (type == 'B')
            {
                Business login = new Business(user);
                if (login.PassCheck(passText.Text))
                {
                    return true;
                }
                else
                    return false;
            }
            else
            {
                Customer login = new Customer(user);
                if (login.PassCheck(passText.Text))
                {
                    return true;
                }
                else
                    return false;
            }
        }

        private void cancelBut_Click(object sender, EventArgs e)
        {
            choice cancel = new choice();
            cancel.Show();
            this.Close();
        }
    }
}
