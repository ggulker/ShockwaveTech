using mock_up.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
///used to see whos in the queue
namespace mock_up.Forms
{
    public partial class CheckQueue : Form
    {
        string business;
        DBController dB = new DBController();
        public CheckQueue(string b)
        {
            business = b;
            InitializeComponent();
        }

        private void businessBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.businessBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.userbaseDataSet);

        }

        //on load fills table with businesses queue
        private void CheckQueue_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'userbaseDataSet.Orders' table. You can move, or remove it, as needed.
            DataTable dt = dB.GetTable("SELECT * FROM Orders WHERE business='" + business + "'");
            queueView.DataSource = dt;
        }
    }
}
