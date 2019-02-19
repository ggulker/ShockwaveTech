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
            bool pass = loginCheck();
            if (pass)
                MessageBox.Show("good");
            else
                MessageBox.Show("bad");
        }

        private bool loginCheck()
        {
            string user = usernameText.Text;
            if(type == 'B')
            {
                string dataPass = string.Empty;

                SqlConnection con = new SqlConnection("Data Source=shockwave.database.windows.net;Initial Catalog=Quicker Queue;;User ID=user;Password=Mwsu1234");
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "SELECT pass FROM Business WHERE username=@username";
                cmd.Parameters.AddWithValue("@username", user);
                con.Open();
                var r = cmd.ExecuteReader();
                if (r.Read())
                {
                    string pass = passText.Text;
                    string d = r["pass"].ToString();
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
                return false;
            }
        }
    }
}
