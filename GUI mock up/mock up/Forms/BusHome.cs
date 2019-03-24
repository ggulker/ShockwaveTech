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

namespace mock_up
{
    public partial class BusHome : Form
    {
        //need the business name to get orders
        string BusName;
        private Timer refresh;
        public BusHome(string n)
        {
            BusName = n;
            InitializeComponent();
        }

        private void ordersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ordersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.quicker_QueueDataSet);

        }

        private void BusHome_Load(object sender, EventArgs e)
        {
            // fills table with orders from the business that logged in
            this.ordersTableAdapter.OrdersGet(this.quicker_QueueDataSet.Orders,BusName);
            SetTimer(sender,e);
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
            this.ordersTableAdapter.OrdersGet(this.quicker_QueueDataSet.Orders, BusName);
        }
    }
}
