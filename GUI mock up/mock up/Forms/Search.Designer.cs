namespace mock_up
{
    partial class Search
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.FiltercomboBox = new System.Windows.Forms.ComboBox();
            this.SearchtextBox = new System.Windows.Forms.TextBox();
            this.Searchbutton = new System.Windows.Forms.Button();
            this.OpentextBox = new System.Windows.Forms.TextBox();
            this.Openlabel = new System.Windows.Forms.Label();
            this.OpencomboBox = new System.Windows.Forms.ComboBox();
            this.ClosecomboBox = new System.Windows.Forms.ComboBox();
            this.Closelabel = new System.Windows.Forms.Label();
            this.ClosetextBox = new System.Windows.Forms.TextBox();
            this.Queuebut = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.businessDataGridView = new System.Windows.Forms.DataGridView();
            this.businessBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quicker_QueueDataSet = new mock_up.Quicker_QueueDataSet();
            this.businessTableAdapter = new mock_up.Quicker_QueueDataSetTableAdapters.BusinessTableAdapter();
            this.tableAdapterManager = new mock_up.Quicker_QueueDataSetTableAdapters.TableAdapterManager();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.busNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.busTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.openHourDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.closeHourDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.businessDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.businessBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quicker_QueueDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // FiltercomboBox
            // 
            this.FiltercomboBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.FiltercomboBox.Items.AddRange(new object[] {
            " ",
            "Restraunt"});
            this.FiltercomboBox.Location = new System.Drawing.Point(396, 90);
            this.FiltercomboBox.Margin = new System.Windows.Forms.Padding(4);
            this.FiltercomboBox.Name = "FiltercomboBox";
            this.FiltercomboBox.Size = new System.Drawing.Size(116, 24);
            this.FiltercomboBox.TabIndex = 0;
            this.FiltercomboBox.Text = "Filter";
            // 
            // SearchtextBox
            // 
            this.SearchtextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.SearchtextBox.ForeColor = System.Drawing.Color.Black;
            this.SearchtextBox.Location = new System.Drawing.Point(104, 90);
            this.SearchtextBox.Margin = new System.Windows.Forms.Padding(4);
            this.SearchtextBox.Name = "SearchtextBox";
            this.SearchtextBox.Size = new System.Drawing.Size(283, 22);
            this.SearchtextBox.TabIndex = 1;
            this.SearchtextBox.Text = "Search";
            this.SearchtextBox.Click += new System.EventHandler(this.SearchtextBox_Click);
            // 
            // Searchbutton
            // 
            this.Searchbutton.BackColor = System.Drawing.Color.RoyalBlue;
            this.Searchbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Searchbutton.Location = new System.Drawing.Point(521, 90);
            this.Searchbutton.Margin = new System.Windows.Forms.Padding(4);
            this.Searchbutton.Name = "Searchbutton";
            this.Searchbutton.Size = new System.Drawing.Size(100, 28);
            this.Searchbutton.TabIndex = 3;
            this.Searchbutton.Text = "Search";
            this.Searchbutton.UseVisualStyleBackColor = false;
            this.Searchbutton.Click += new System.EventHandler(this.Searchbutton_Click);
            // 
            // OpentextBox
            // 
            this.OpentextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.OpentextBox.Location = new System.Drawing.Point(157, 122);
            this.OpentextBox.Margin = new System.Windows.Forms.Padding(4);
            this.OpentextBox.Name = "OpentextBox";
            this.OpentextBox.Size = new System.Drawing.Size(63, 22);
            this.OpentextBox.TabIndex = 5;
            // 
            // Openlabel
            // 
            this.Openlabel.AutoSize = true;
            this.Openlabel.Location = new System.Drawing.Point(101, 126);
            this.Openlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Openlabel.Name = "Openlabel";
            this.Openlabel.Size = new System.Drawing.Size(47, 17);
            this.Openlabel.TabIndex = 6;
            this.Openlabel.Text = "Open:";
            // 
            // OpencomboBox
            // 
            this.OpencomboBox.BackColor = System.Drawing.SystemColors.Control;
            this.OpencomboBox.FormattingEnabled = true;
            this.OpencomboBox.Location = new System.Drawing.Point(229, 121);
            this.OpencomboBox.Margin = new System.Windows.Forms.Padding(4);
            this.OpencomboBox.Name = "OpencomboBox";
            this.OpencomboBox.Size = new System.Drawing.Size(52, 24);
            this.OpencomboBox.TabIndex = 7;
            this.OpencomboBox.Text = "am";
            // 
            // ClosecomboBox
            // 
            this.ClosecomboBox.BackColor = System.Drawing.SystemColors.Control;
            this.ClosecomboBox.FormattingEnabled = true;
            this.ClosecomboBox.Location = new System.Drawing.Point(437, 121);
            this.ClosecomboBox.Margin = new System.Windows.Forms.Padding(4);
            this.ClosecomboBox.Name = "ClosecomboBox";
            this.ClosecomboBox.Size = new System.Drawing.Size(52, 24);
            this.ClosecomboBox.TabIndex = 10;
            this.ClosecomboBox.Text = "pm";
            // 
            // Closelabel
            // 
            this.Closelabel.AutoSize = true;
            this.Closelabel.Location = new System.Drawing.Point(309, 126);
            this.Closelabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Closelabel.Name = "Closelabel";
            this.Closelabel.Size = new System.Drawing.Size(47, 17);
            this.Closelabel.TabIndex = 9;
            this.Closelabel.Text = "Close:";
            // 
            // ClosetextBox
            // 
            this.ClosetextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClosetextBox.Location = new System.Drawing.Point(365, 122);
            this.ClosetextBox.Margin = new System.Windows.Forms.Padding(4);
            this.ClosetextBox.Name = "ClosetextBox";
            this.ClosetextBox.Size = new System.Drawing.Size(63, 22);
            this.ClosetextBox.TabIndex = 8;
            // 
            // Queuebut
            // 
            this.Queuebut.BackColor = System.Drawing.Color.SpringGreen;
            this.Queuebut.Location = new System.Drawing.Point(521, 126);
            this.Queuebut.Margin = new System.Windows.Forms.Padding(4);
            this.Queuebut.Name = "Queuebut";
            this.Queuebut.Size = new System.Drawing.Size(100, 28);
            this.Queuebut.TabIndex = 11;
            this.Queuebut.Text = "Queue";
            this.Queuebut.UseVisualStyleBackColor = false;
            this.Queuebut.Click += new System.EventHandler(this.QueueBut_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(727, 74);
            this.panel1.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel2.Location = new System.Drawing.Point(16, 15);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(96, 46);
            this.panel2.TabIndex = 1;
            // 
            // businessDataGridView
            // 
            this.businessDataGridView.AutoGenerateColumns = false;
            this.businessDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.businessDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.usernameDataGridViewTextBoxColumn,
            this.passDataGridViewTextBoxColumn,
            this.busNameDataGridViewTextBoxColumn,
            this.busTypeDataGridViewTextBoxColumn,
            this.openHourDataGridViewTextBoxColumn,
            this.closeHourDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn});
            this.businessDataGridView.DataSource = this.businessBindingSource;
            this.businessDataGridView.Location = new System.Drawing.Point(4, 161);
            this.businessDataGridView.Name = "businessDataGridView";
            this.businessDataGridView.RowTemplate.Height = 24;
            this.businessDataGridView.Size = new System.Drawing.Size(711, 331);
            this.businessDataGridView.TabIndex = 13;
            // 
            // businessBindingSource
            // 
            this.businessBindingSource.DataMember = "Business";
            this.businessBindingSource.DataSource = this.quicker_QueueDataSet;
            // 
            // quicker_QueueDataSet
            // 
            this.quicker_QueueDataSet.DataSetName = "Quicker_QueueDataSet";
            this.quicker_QueueDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // businessTableAdapter
            // 
            this.businessTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BusinessTableAdapter = this.businessTableAdapter;
            this.tableAdapterManager.CustomerTableAdapter = null;
            this.tableAdapterManager.OrdersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = mock_up.Quicker_QueueDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "username";
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            this.usernameDataGridViewTextBoxColumn.Visible = false;
            // 
            // passDataGridViewTextBoxColumn
            // 
            this.passDataGridViewTextBoxColumn.DataPropertyName = "pass";
            this.passDataGridViewTextBoxColumn.HeaderText = "pass";
            this.passDataGridViewTextBoxColumn.Name = "passDataGridViewTextBoxColumn";
            this.passDataGridViewTextBoxColumn.Visible = false;
            // 
            // busNameDataGridViewTextBoxColumn
            // 
            this.busNameDataGridViewTextBoxColumn.DataPropertyName = "BusName";
            this.busNameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.busNameDataGridViewTextBoxColumn.Name = "busNameDataGridViewTextBoxColumn";
            // 
            // busTypeDataGridViewTextBoxColumn
            // 
            this.busTypeDataGridViewTextBoxColumn.DataPropertyName = "BusType";
            this.busTypeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.busTypeDataGridViewTextBoxColumn.Name = "busTypeDataGridViewTextBoxColumn";
            // 
            // openHourDataGridViewTextBoxColumn
            // 
            this.openHourDataGridViewTextBoxColumn.DataPropertyName = "openHour";
            this.openHourDataGridViewTextBoxColumn.HeaderText = "Opens";
            this.openHourDataGridViewTextBoxColumn.Name = "openHourDataGridViewTextBoxColumn";
            // 
            // closeHourDataGridViewTextBoxColumn
            // 
            this.closeHourDataGridViewTextBoxColumn.DataPropertyName = "closeHour";
            this.closeHourDataGridViewTextBoxColumn.HeaderText = "Closes";
            this.closeHourDataGridViewTextBoxColumn.Name = "closeHourDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(727, 554);
            this.Controls.Add(this.businessDataGridView);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Queuebut);
            this.Controls.Add(this.ClosecomboBox);
            this.Controls.Add(this.Closelabel);
            this.Controls.Add(this.ClosetextBox);
            this.Controls.Add(this.OpencomboBox);
            this.Controls.Add(this.Openlabel);
            this.Controls.Add(this.OpentextBox);
            this.Controls.Add(this.Searchbutton);
            this.Controls.Add(this.SearchtextBox);
            this.Controls.Add(this.FiltercomboBox);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Search";
            this.Text = "Search";
            this.Load += new System.EventHandler(this.Search_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.businessDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.businessBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quicker_QueueDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox FiltercomboBox;
        private System.Windows.Forms.TextBox SearchtextBox;
        private System.Windows.Forms.Button Searchbutton;
        private System.Windows.Forms.TextBox OpentextBox;
        private System.Windows.Forms.Label Openlabel;
        private System.Windows.Forms.ComboBox OpencomboBox;
        private System.Windows.Forms.ComboBox ClosecomboBox;
        private System.Windows.Forms.Label Closelabel;
        private System.Windows.Forms.TextBox ClosetextBox;
        private System.Windows.Forms.Button Queuebut;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView businessDataGridView;
        private Quicker_QueueDataSet quicker_QueueDataSet;
        private System.Windows.Forms.BindingSource businessBindingSource;
        private Quicker_QueueDataSetTableAdapters.BusinessTableAdapter businessTableAdapter;
        private Quicker_QueueDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn busNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn busTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn openHourDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn closeHourDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
    }
}