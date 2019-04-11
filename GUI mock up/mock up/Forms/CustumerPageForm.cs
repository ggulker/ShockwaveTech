using mock_up.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mock_up.Forms
{
    public partial class CustumerPageForm : Form
    {
        Customer user;
        DBController dB = new DBController();
        public CustumerPageForm(Customer c)
        {
            user = c;
            string username = user.Username;
            string email = user.Email;
            InitializeComponent();
            UserIDtextBox.Text = username;
            EmailtextBox.Text = email;
        }
        private void confirmBut_Click(object sender, EventArgs e)
        {
            Editbutton.Show();
            confirmBut.Hide();
            dB.ChangeCustAccount(user.Username, UserIDtextBox.Text, EmailtextBox.Text);
            UserIDtextBox.ReadOnly = true;
            EmailtextBox.ReadOnly = true;
        }

        private void Editbutton_Click(object sender, EventArgs e)
        {
            Editbutton.Hide();
            confirmBut.Show();
            UserIDtextBox.ReadOnly = false;
            EmailtextBox.ReadOnly = false;
        }

        private void ChangePasswordbutton_Click(object sender, EventArgs e)
        {

        }

        private void Cancelbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void deleteBut_Click(object sender, EventArgs e)
        {
            string message = "Are you sure you want to delete your account?";
            string title = "Close Window";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                dB.RemoveCustAccount(user.Username);
                this.Close();
                System.Environment.Exit(1);
            }
            else
            {
                // Do something  
            }
        }
    }
}
