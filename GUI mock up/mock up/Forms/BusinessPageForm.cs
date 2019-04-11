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
    public partial class BusinessPageForm : Form
    {
        DBController dB = new DBController();
        Business user;
        public BusinessPageForm(Business u)
        {
            user = u;
            string username = user.Username;
            string email = user.Email;
            string type = user.Type;
            string name = user.Name;
            string open = user.openHour.ToString();
            string close = user.closeHour.ToString();
            InitializeComponent();
            UserIDtextBox.Text = username;
            EmailtextBox.Text = email;
            closeTextBox.Text = close;
            openTextBox.Text = open;
            typeCombo.Text = type;
            nameTextBox.Text = name;
        }

        private void Cancelbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Editbutton_Click(object sender, EventArgs e)
        {
            Editbutton.Hide();
            confirmBut.Show();
            UserIDtextBox.ReadOnly = false;
            EmailtextBox.ReadOnly = false;
            openTextBox.ReadOnly = false;
            closeTextBox.ReadOnly = false;
            nameTextBox.ReadOnly = false;
        }

        private void confirmBut_Click(object sender, EventArgs e)
        {
            Editbutton.Show();
            confirmBut.Hide();
            UserIDtextBox.ReadOnly = true;
            EmailtextBox.ReadOnly = true;
            openTextBox.ReadOnly = true;
            closeTextBox.ReadOnly = true;
            nameTextBox.ReadOnly = true;
            dB.ChangeBusAccount
                (user.Username,UserIDtextBox.Text,EmailtextBox.Text,openTextBox.Text,closeTextBox.Text,nameTextBox.Text,typeCombo.Text);
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

        private void ChangePasswordbutton_Click(object sender, EventArgs e)
        {

        }
    }
}
