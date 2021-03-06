﻿namespace mock_up
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
            this.accountBut = new System.Windows.Forms.Button();
            this.logOutBut = new System.Windows.Forms.Button();
            this.businessBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userbaseDataSet = new mock_up.UserbaseDataSet();
            this.businessBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.businessTableAdapter1 = new mock_up.UserbaseDataSetTableAdapters.BusinessTableAdapter();
            this.tableAdapterManager1 = new mock_up.UserbaseDataSetTableAdapters.TableAdapterManager();
            this.favoriteBut = new System.Windows.Forms.Button();
            this.checkBut = new System.Windows.Forms.Button();
            this.businessDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Here = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.businessBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userbaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.businessBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.businessDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // FiltercomboBox
            // 
            this.FiltercomboBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.FiltercomboBox.Items.AddRange(new object[] {
            "",
            "Restraunt",
            "Doctor\'s Office",
            "Favorites"});
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
            this.OpencomboBox.Items.AddRange(new object[] {
            "am",
            "pm"});
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
            this.ClosecomboBox.Items.AddRange(new object[] {
            "am",
            "pm"});
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
            this.panel1.Controls.Add(this.accountBut);
            this.panel1.Controls.Add(this.logOutBut);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(727, 74);
            this.panel1.TabIndex = 12;
            // 
            // accountBut
            // 
            this.accountBut.Location = new System.Drawing.Point(628, 13);
            this.accountBut.Name = "accountBut";
            this.accountBut.Size = new System.Drawing.Size(75, 32);
            this.accountBut.TabIndex = 1;
            this.accountBut.Text = "Account";
            this.accountBut.UseVisualStyleBackColor = true;
            this.accountBut.Click += new System.EventHandler(this.accountBut_Click);
            // 
            // logOutBut
            // 
            this.logOutBut.Location = new System.Drawing.Point(13, 13);
            this.logOutBut.Name = "logOutBut";
            this.logOutBut.Size = new System.Drawing.Size(75, 32);
            this.logOutBut.TabIndex = 0;
            this.logOutBut.Text = "Log Out";
            this.logOutBut.UseVisualStyleBackColor = true;
            this.logOutBut.Click += new System.EventHandler(this.logOutBut_Click);
            // 
            // userbaseDataSet
            // 
            this.userbaseDataSet.DataSetName = "UserbaseDataSet";
            this.userbaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // businessBindingSource1
            // 
            this.businessBindingSource1.DataMember = "Business";
            this.businessBindingSource1.DataSource = this.userbaseDataSet;
            // 
            // businessTableAdapter1
            // 
            this.businessTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.BusinessTableAdapter = this.businessTableAdapter1;
            this.tableAdapterManager1.CustomerTableAdapter = null;
            this.tableAdapterManager1.FavoritesTableAdapter = null;
            this.tableAdapterManager1.OrdersTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = mock_up.UserbaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // favoriteBut
            // 
            this.favoriteBut.Location = new System.Drawing.Point(628, 129);
            this.favoriteBut.Name = "favoriteBut";
            this.favoriteBut.Size = new System.Drawing.Size(75, 23);
            this.favoriteBut.TabIndex = 13;
            this.favoriteBut.Text = "Favorite";
            this.favoriteBut.UseVisualStyleBackColor = true;
            this.favoriteBut.Click += new System.EventHandler(this.favoriteBut_Click);
            // 
            // checkBut
            // 
            this.checkBut.Location = new System.Drawing.Point(628, 91);
            this.checkBut.Name = "checkBut";
            this.checkBut.Size = new System.Drawing.Size(75, 23);
            this.checkBut.TabIndex = 14;
            this.checkBut.Text = "Check";
            this.checkBut.UseVisualStyleBackColor = true;
            this.checkBut.Click += new System.EventHandler(this.checkBut_Click);
            // 
            // businessDataGridView
            // 
            this.businessDataGridView.AllowUserToAddRows = false;
            this.businessDataGridView.AllowUserToDeleteRows = false;
            this.businessDataGridView.AutoGenerateColumns = false;
            this.businessDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.businessDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.Here,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.businessDataGridView.DataSource = this.businessBindingSource1;
            this.businessDataGridView.Location = new System.Drawing.Point(16, 152);
            this.businessDataGridView.Name = "businessDataGridView";
            this.businessDataGridView.ReadOnly = true;
            this.businessDataGridView.RowTemplate.Height = 24;
            this.businessDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.businessDataGridView.Size = new System.Drawing.Size(687, 390);
            this.businessDataGridView.TabIndex = 14;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "BusName";
            this.dataGridViewTextBoxColumn7.HeaderText = "Name";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // Here
            // 
            this.Here.DataPropertyName = "username";
            this.Here.HeaderText = "username";
            this.Here.Name = "Here";
            this.Here.ReadOnly = true;
            this.Here.Visible = false;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "BusType";
            this.dataGridViewTextBoxColumn6.HeaderText = "Type";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "email";
            this.dataGridViewTextBoxColumn3.HeaderText = "Email";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "openHour";
            this.dataGridViewTextBoxColumn4.HeaderText = "Open";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "closeHour";
            this.dataGridViewTextBoxColumn5.HeaderText = "Close";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(727, 554);
            this.Controls.Add(this.businessDataGridView);
            this.Controls.Add(this.checkBut);
            this.Controls.Add(this.favoriteBut);
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
            ((System.ComponentModel.ISupportInitialize)(this.businessBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userbaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.businessBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.businessDataGridView)).EndInit();
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
        private System.Windows.Forms.BindingSource businessBindingSource;
        private UserbaseDataSet userbaseDataSet;
        private System.Windows.Forms.BindingSource businessBindingSource1;
        private UserbaseDataSetTableAdapters.BusinessTableAdapter businessTableAdapter1;
        private UserbaseDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.Button favoriteBut;
        private System.Windows.Forms.Button checkBut;
        private System.Windows.Forms.DataGridView businessDataGridView;
        private System.Windows.Forms.Button logOutBut;
        private System.Windows.Forms.Button accountBut;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Here;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}