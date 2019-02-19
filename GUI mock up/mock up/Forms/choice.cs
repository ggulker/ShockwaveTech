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
    public partial class choice : Form
    {
        public choice()
        {
            InitializeComponent();
        }

        private void busBut_Click(object sender, EventArgs e)
        {
            Login login = new Login('B');
            login.Show();
            this.Close();
        }

        private void userBut_Click(object sender, EventArgs e)
        {
            Login login = new Login('C');
            login.Show();
            this.Close();
        }
    }
}
