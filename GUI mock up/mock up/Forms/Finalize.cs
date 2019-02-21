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

namespace mock_up.Forms
{
    public partial class Finalize : Form
    {
        string customer, business;
        public Finalize(string b, string c)
        {
            customer = c;
            business = b;
            InitializeComponent();
        }

        private void CloseBut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void QueueBut_Click(object sender, EventArgs e)
        {
            //creates connection then adds a new order
            SqlConnection con = new SqlConnection("Data Source=shockwave.database.windows.net;Initial Catalog=Quicker Queue;;User ID=user;Password=Mwsu1234");
            SqlCommand cmd = con.CreateCommand();
            //creates query and fills with specific info
            cmd.CommandText = "INSERT INTO orders VALUES(@customer, @business)";
            cmd.Parameters.AddWithValue("@customer", customer);
            cmd.Parameters.AddWithValue("@business", business);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("completed");
            this.Close();
        }
    }
}
