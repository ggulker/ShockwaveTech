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
        char type;

        public Login(char t)
        {
            type = t;
            InitializeComponent();
        }

        private void loginBut_Click(object sender, EventArgs e)
        {
            string user, pass;
            user = usernameText.Text;
            pass = passText.Text;
            if (type == 'B')
            {
                //string dataPass = " ";
                //string sql = "SELECT pass FROM Business WHERE username LIKE @username";
                //using (SqlConnection conn = new SqlConnection(connString))
                //{

                //}
            }
            else
            {

            }
        }
    }
}
