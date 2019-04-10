using mock_up.Classes;
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
/// final screen used as a confirmation and more info
/// </summary>
namespace mock_up.Forms
{
    public partial class Finalize : Form
    {
        string customer, business;
        DBController dB = new DBController();

        public Finalize(string b, string c)
        {
            customer = c;
            business = b;
            InitializeComponent();
        }

        //closes form
        private void CloseBut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //calls controller to add to orders table
        private void QueueBut_Click(object sender, EventArgs e)
        {
            dB.CreateOrder(customer, business);
            MessageBox.Show("complete");
            this.Close();
        }
    }
}
