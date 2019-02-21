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

namespace mock_up
{
    public partial class Search : Form
    {
        string username;
        public Search(string u)
        {
            username = u;
            InitializeComponent();
        }

        private void Database_Load(object sender, EventArgs e)
        {
            //fills with all businesses on load
            this.businessTableAdapter.Fill(this.quicker_QueueDataSet.Business);

        }

        //just restarts program
        private void logOutBut_Click(object sender, EventArgs e)
        {
            Start restart = new Start();
            restart.Show();
            this.Close();
        }

        private void QueueBut_Click(object sender, EventArgs e)
        {
            //makes sure at least one row is selected
            if (businessDataGridView.SelectedRows.Count != 0)
            {
                //grabs username from row selected
                DataGridViewRow row = businessDataGridView.SelectedRows[0];
                Finalize queue = new Finalize(row.Cells["Here"].Value.ToString(), username);
                queue.Show();
            }
            else
            {
                MessageBox.Show("Please select a business to queue for");
            }
        }
    }
}
