using mock_up.Forms;
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
    public partial class Search : Form
    {
        string username;
        private SqlConnection con = new SqlConnection("Data Source=quickerproject.database.windows.net;Initial Catalog=Userbase;Persist Security Info=True;User ID=user;Password=Mwsu1234");
        SqlDataAdapter adapt;
        DataTable dt;

        public Search(string u)
        {
            username = u;
            InitializeComponent();
        }


        private void Search_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'userbaseDataSet.Business' table. You can move, or remove it, as needed.
            this.businessTableAdapter1.Fill(this.userbaseDataSet.Business);
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

        //search by creating own queary and making a new table with it
        private void Searchbutton_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Business WHERE pass != ''";
            //every textbox checked and if not empty adds to queary
            if (!string.IsNullOrEmpty(SearchtextBox.Text) && SearchtextBox.Text != "Search")
            {
                query += " AND BusName= '" + SearchtextBox.Text + "'";
            }
            if(!string.IsNullOrEmpty(FiltercomboBox.Text) && FiltercomboBox.Text != "Filter")
            {
                query += " AND BusType= '" + FiltercomboBox.Text + "'";
                
            }
            if (!string.IsNullOrEmpty(OpentextBox.Text))
            {
                query += " AND openHour= " + OpentextBox.Text;
            }
            if (!string.IsNullOrEmpty(ClosetextBox.Text))
            {
                query += " AND closeHour= " + ClosetextBox.Text;
            }
            //opens connection and creates new table based on queary then replaces current table
            con.Open();
            adapt = new SqlDataAdapter(query,con);
            dt = new DataTable();
            adapt.Fill(dt);
            businessDataGridView.DataSource = dt;
            con.Close();
        }

        //empties search text box if clicked
        private void SearchtextBox_Click(object sender, EventArgs e)
        {
            SearchtextBox.Clear();
        }

        //inserts selected business into favorites table for later
        private void favoriteBut_Click(object sender, EventArgs e)
        {
            //checks to see if u selected a row
            if (businessDataGridView.SelectedRows.Count != 0)
            {
                //takes selected rows and gets the username 
                DataGridViewRow row = businessDataGridView.SelectedRows[0];
                string business = row.Cells["Here"].Value.ToString();

                //creates queary and executes
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "INSERT INTO Favorites VALUES(@customer, @business)";
                cmd.Parameters.AddWithValue("@customer", username);
                cmd.Parameters.AddWithValue("@business", business);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            else
            {
                MessageBox.Show("Please select a business to favorite");
            }
        }
    }
}
