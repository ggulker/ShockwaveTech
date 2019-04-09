
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using Timer = System.Windows.Forms.Timer;
using mock_up.Classes;

namespace mock_up
{
    public partial class BusHome : Form
    {
        //need the business name to get orders
        string username;
        string email;
        DBController dB = new DBController();

        public BusHome(Business n)
        {
            username = n.Username;
            email = n.Email;
            InitializeComponent();
        }

        private void ordersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ordersBindingSource.EndEdit();
            this.tableAdapterManager1.UpdateAll(this.userbaseDataSet);

        }

        private void BusHome_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'userbaseDataSet.Orders' table. You can move, or remove it, as needed.
            this.ordersTableAdapter1.FillBy(this.userbaseDataSet.Orders, username);
            SetTimer(sender, e);
        }

        //just restarts program
        private void logOutBut_Click(object sender, EventArgs e)
        {
            Start restart = new Start();
            restart.Show();
            this.Close();
        }

        private void SetTimer(object sender, EventArgs e)
        {
            Timer timer = new Timer();
            timer.Interval = (10 * 1000); // 10 secs
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            this.ordersTableAdapter1.FillBy(this.userbaseDataSet.Orders, username);
        }

        private void notifyBut_Click(object sender, EventArgs e)
        {
            //grabs name from selected row then calls the controller to grab the email
            string custEmail = dB.CustEmail
                (ordersDataGridView.SelectedRows[0].Cells["Customer"].Value.ToString());
        }
    }
}