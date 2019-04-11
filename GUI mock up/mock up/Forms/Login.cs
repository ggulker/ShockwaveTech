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

/// <summary>
/// login for all users that checks account info and password sent
/// </summary>
namespace mock_up
{
    public partial class Login : Form
    {
        Aes_Encryption aes = new Aes_Encryption();
        //used to see what button they pressed on the choice form
        char type;
        Business business;
        Customer customer;
        public Login(char t)
        {
            type = t;
            InitializeComponent();
        }

        //once login is pressed begins logincheck and determines what kind of account
        //is being logged into
        private void loginBut_Click(object sender, EventArgs e)
        {
            //checks if it logged in
            if (loginCheck())
                //wether its a business or customer
                if (type == 'B')
                {
                    BusHome bus = new BusHome(business);
                    bus.Show();
                    this.Close();
                }
                else
                {
                    Search search = new Search(customer);
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

            //determines what login is being attempted
            if (type == 'B')
            {
                business = new Business(user,passText.Text);
                //checking password
                if (business.PassCheck(passText.Text))
                {
                    return true;
                }
                else
                    return false;
            }
            else
            {
                customer = new Customer(user,passText.Text);
                if (customer.PassCheck(passText.Text))
                {
                    return true;
                }
                else
                    return false;
            }
        }

        //just restarts the program
        private void cancelBut_Click(object sender, EventArgs e)
        {
            choice cancel = new choice();
            cancel.Show();
            this.Close();
        }
    }
}
