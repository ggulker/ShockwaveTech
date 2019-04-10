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
/// user chooses what account they are creating
/// </summary>
namespace mock_up
{
    public partial class NewChoice : Form
    {
        public NewChoice()
        {
            InitializeComponent();
        }

        //creates a new window and sends what button they pressed
        private void busBut_Click(object sender, EventArgs e)
        {
            BusCreate bus = new BusCreate();
            bus.Show();
            this.Close();
        }

        private void userBut_Click(object sender, EventArgs e)
        {
            CustCreate cust = new CustCreate();
            cust.Show();
            this.Close();
        }
    }
}
