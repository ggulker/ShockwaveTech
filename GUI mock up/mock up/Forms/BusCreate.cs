using mock_up.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/// <summary>
/// form used for new bussiness to make their account
/// </summary>
namespace mock_up
{
    public partial class BusCreate : Form
    {
        public BusCreate()
        {
            InitializeComponent();
        }

        //once clicked collects all info from textboxes and creates a new business class
        //then creates a new BusHome form with this business
        private void Registerbutton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(UserIDtextBox.Text) || string.IsNullOrEmpty(PasswordtextBox.Text) || string.IsNullOrEmpty(EmailtextBox.Text)
                || string.IsNullOrEmpty(typeComboBox.Text) || string.IsNullOrEmpty(OpentextBox.Text) || string.IsNullOrEmpty(ClosetextBox.Text) || string.IsNullOrEmpty(NametextBox.Text))
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
                string emailPass = emailPassBox.Text;
                try
                {
                    Business create = new Business(username,pass,email,open,close,type,name,emailPass);
                    MessageBox.Show("Your account has been created!");

                    if (create.Type == "Restraunt")
                    {
                        RestuarantForm r = new RestuarantForm(create);
                        r.Show();
                    }
                    else
                    {
                        DoctorOfficeForm d = new DoctorOfficeForm(create);
                        d.Show();
                    }
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
