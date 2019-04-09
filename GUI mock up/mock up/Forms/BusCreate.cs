using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mock_up
{
    public partial class BusCreate : Form
    {
        public BusCreate()
        {
            InitializeComponent();
        }

        private void Registerbutton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(UserIDtextBox.Text) || string.IsNullOrEmpty(PasswordtextBox.Text) || string.IsNullOrEmpty(EmailtextBox.Text))
                MessageBox.Show("Please fill all boxes before registering.");
            else
            {
                string username = UserIDtextBox.Text;
                string pass = PasswordtextBox.Text;
                string email = EmailtextBox.Text;
                string open = OpentextBox.Text;
                string close = ClosetextBox.Text;
                string type = typeComboBox.Text;
                string name = NametextBox.Text;
                try
                {
                    Business create = new Business(username,pass,email,open,close,type,name);
                    MessageBox.Show("Your account has been created!");
                    BusHome start = new BusHome(create);
                    start.Show();
                    this.Close();
                }
                catch(System.InvalidOperationException)
                {
                    MessageBox.Show("this account already exists");
                }
            }
        }
    }
}
