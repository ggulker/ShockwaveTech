namespace mock_up.Forms
{
    partial class RestuarantForm
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
            this.Seatlabel = new System.Windows.Forms.Label();
            this.BiggerTable3checkBox = new System.Windows.Forms.CheckBox();
            this.BiggerTable2checkBox = new System.Windows.Forms.CheckBox();
            this.BiggerTable1checkBox = new System.Windows.Forms.CheckBox();
            this.Booth4checkBox = new System.Windows.Forms.CheckBox();
            this.Booth3checkBox = new System.Windows.Forms.CheckBox();
            this.Booth2checkBox = new System.Windows.Forms.CheckBox();
            this.Table4checkBox = new System.Windows.Forms.CheckBox();
            this.Table3checkBox = new System.Windows.Forms.CheckBox();
            this.Table2checkBox = new System.Windows.Forms.CheckBox();
            this.Bar5checkBox = new System.Windows.Forms.CheckBox();
            this.Bar3checkBox = new System.Windows.Forms.CheckBox();
            this.Bar2checkBox = new System.Windows.Forms.CheckBox();
            this.Booth1checkBox = new System.Windows.Forms.CheckBox();
            this.Bar1checkBox = new System.Windows.Forms.CheckBox();
            this.Table1checkBox = new System.Windows.Forms.CheckBox();
            this.Notifybutton = new System.Windows.Forms.Button();
            this.Queuelabel = new System.Windows.Forms.Label();
            this.Removebutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Bar4checkBox = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.userbaseDataSet = new mock_up.UserbaseDataSet();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ordersTableAdapter = new mock_up.UserbaseDataSetTableAdapters.OrdersTableAdapter();
            this.tableAdapterManager = new mock_up.UserbaseDataSetTableAdapters.TableAdapterManager();
            this.ordersDataGridView = new System.Windows.Forms.DataGridView();
            this.Customer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.logOutBut = new System.Windows.Forms.Button();
            this.accountBut = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userbaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Seatlabel
            // 
            this.Seatlabel.AutoSize = true;
            this.Seatlabel.BackColor = System.Drawing.Color.Silver;
            this.Seatlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Seatlabel.ForeColor = System.Drawing.Color.Black;
            this.Seatlabel.Location = new System.Drawing.Point(472, 145);
            this.Seatlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Seatlabel.Name = "Seatlabel";
            this.Seatlabel.Size = new System.Drawing.Size(123, 25);
            this.Seatlabel.TabIndex = 93;
            this.Seatlabel.Text = "Seat Types";
            // 
            // BiggerTable3checkBox
            // 
            this.BiggerTable3checkBox.AutoSize = true;
            this.BiggerTable3checkBox.BackColor = System.Drawing.Color.CadetBlue;
            this.BiggerTable3checkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BiggerTable3checkBox.Location = new System.Drawing.Point(647, 383);
            this.BiggerTable3checkBox.Margin = new System.Windows.Forms.Padding(4);
            this.BiggerTable3checkBox.Name = "BiggerTable3checkBox";
            this.BiggerTable3checkBox.Size = new System.Drawing.Size(161, 29);
            this.BiggerTable3checkBox.TabIndex = 92;
            this.BiggerTable3checkBox.Text = "Bigger Table 3";
            this.BiggerTable3checkBox.UseVisualStyleBackColor = false;
            // 
            // BiggerTable2checkBox
            // 
            this.BiggerTable2checkBox.AutoSize = true;
            this.BiggerTable2checkBox.BackColor = System.Drawing.Color.CadetBlue;
            this.BiggerTable2checkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BiggerTable2checkBox.Location = new System.Drawing.Point(647, 330);
            this.BiggerTable2checkBox.Margin = new System.Windows.Forms.Padding(4);
            this.BiggerTable2checkBox.Name = "BiggerTable2checkBox";
            this.BiggerTable2checkBox.Size = new System.Drawing.Size(161, 29);
            this.BiggerTable2checkBox.TabIndex = 91;
            this.BiggerTable2checkBox.Text = "Bigger Table 2";
            this.BiggerTable2checkBox.UseVisualStyleBackColor = false;
            // 
            // BiggerTable1checkBox
            // 
            this.BiggerTable1checkBox.AutoSize = true;
            this.BiggerTable1checkBox.BackColor = System.Drawing.Color.CadetBlue;
            this.BiggerTable1checkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BiggerTable1checkBox.Location = new System.Drawing.Point(647, 272);
            this.BiggerTable1checkBox.Margin = new System.Windows.Forms.Padding(4);
            this.BiggerTable1checkBox.Name = "BiggerTable1checkBox";
            this.BiggerTable1checkBox.Size = new System.Drawing.Size(161, 29);
            this.BiggerTable1checkBox.TabIndex = 90;
            this.BiggerTable1checkBox.Text = "Bigger Table 1";
            this.BiggerTable1checkBox.UseVisualStyleBackColor = false;
            // 
            // Booth4checkBox
            // 
            this.Booth4checkBox.AutoSize = true;
            this.Booth4checkBox.BackColor = System.Drawing.Color.PaleVioletRed;
            this.Booth4checkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Booth4checkBox.Location = new System.Drawing.Point(887, 405);
            this.Booth4checkBox.Margin = new System.Windows.Forms.Padding(4);
            this.Booth4checkBox.Name = "Booth4checkBox";
            this.Booth4checkBox.Size = new System.Drawing.Size(101, 29);
            this.Booth4checkBox.TabIndex = 88;
            this.Booth4checkBox.Text = "Booth 4";
            this.Booth4checkBox.UseVisualStyleBackColor = false;
            // 
            // Booth3checkBox
            // 
            this.Booth3checkBox.AutoSize = true;
            this.Booth3checkBox.BackColor = System.Drawing.Color.PaleVioletRed;
            this.Booth3checkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Booth3checkBox.Location = new System.Drawing.Point(887, 353);
            this.Booth3checkBox.Margin = new System.Windows.Forms.Padding(4);
            this.Booth3checkBox.Name = "Booth3checkBox";
            this.Booth3checkBox.Size = new System.Drawing.Size(101, 29);
            this.Booth3checkBox.TabIndex = 87;
            this.Booth3checkBox.Text = "Booth 3";
            this.Booth3checkBox.UseVisualStyleBackColor = false;
            // 
            // Booth2checkBox
            // 
            this.Booth2checkBox.AutoSize = true;
            this.Booth2checkBox.BackColor = System.Drawing.Color.PaleVioletRed;
            this.Booth2checkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Booth2checkBox.Location = new System.Drawing.Point(887, 302);
            this.Booth2checkBox.Margin = new System.Windows.Forms.Padding(4);
            this.Booth2checkBox.Name = "Booth2checkBox";
            this.Booth2checkBox.Size = new System.Drawing.Size(101, 29);
            this.Booth2checkBox.TabIndex = 86;
            this.Booth2checkBox.Text = "Booth 2";
            this.Booth2checkBox.UseVisualStyleBackColor = false;
            // 
            // Table4checkBox
            // 
            this.Table4checkBox.AutoSize = true;
            this.Table4checkBox.BackColor = System.Drawing.Color.CadetBlue;
            this.Table4checkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Table4checkBox.Location = new System.Drawing.Point(477, 405);
            this.Table4checkBox.Margin = new System.Windows.Forms.Padding(4);
            this.Table4checkBox.Name = "Table4checkBox";
            this.Table4checkBox.Size = new System.Drawing.Size(100, 29);
            this.Table4checkBox.TabIndex = 85;
            this.Table4checkBox.Text = "Table 4";
            this.Table4checkBox.UseVisualStyleBackColor = false;
            // 
            // Table3checkBox
            // 
            this.Table3checkBox.AutoSize = true;
            this.Table3checkBox.BackColor = System.Drawing.Color.CadetBlue;
            this.Table3checkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Table3checkBox.Location = new System.Drawing.Point(477, 353);
            this.Table3checkBox.Margin = new System.Windows.Forms.Padding(4);
            this.Table3checkBox.Name = "Table3checkBox";
            this.Table3checkBox.Size = new System.Drawing.Size(100, 29);
            this.Table3checkBox.TabIndex = 84;
            this.Table3checkBox.Text = "Table 3";
            this.Table3checkBox.UseVisualStyleBackColor = false;
            // 
            // Table2checkBox
            // 
            this.Table2checkBox.AutoSize = true;
            this.Table2checkBox.BackColor = System.Drawing.Color.CadetBlue;
            this.Table2checkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Table2checkBox.Location = new System.Drawing.Point(477, 302);
            this.Table2checkBox.Margin = new System.Windows.Forms.Padding(4);
            this.Table2checkBox.Name = "Table2checkBox";
            this.Table2checkBox.Size = new System.Drawing.Size(100, 29);
            this.Table2checkBox.TabIndex = 83;
            this.Table2checkBox.Text = "Table 2";
            this.Table2checkBox.UseVisualStyleBackColor = false;
            // 
            // Bar5checkBox
            // 
            this.Bar5checkBox.AutoSize = true;
            this.Bar5checkBox.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.Bar5checkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bar5checkBox.Location = new System.Drawing.Point(911, 196);
            this.Bar5checkBox.Margin = new System.Windows.Forms.Padding(4);
            this.Bar5checkBox.Name = "Bar5checkBox";
            this.Bar5checkBox.Size = new System.Drawing.Size(80, 29);
            this.Bar5checkBox.TabIndex = 82;
            this.Bar5checkBox.Text = "Bar 5";
            this.Bar5checkBox.UseVisualStyleBackColor = false;
            // 
            // Bar3checkBox
            // 
            this.Bar3checkBox.AutoSize = true;
            this.Bar3checkBox.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.Bar3checkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bar3checkBox.Location = new System.Drawing.Point(693, 196);
            this.Bar3checkBox.Margin = new System.Windows.Forms.Padding(4);
            this.Bar3checkBox.Name = "Bar3checkBox";
            this.Bar3checkBox.Size = new System.Drawing.Size(80, 29);
            this.Bar3checkBox.TabIndex = 80;
            this.Bar3checkBox.Text = "Bar 3";
            this.Bar3checkBox.UseVisualStyleBackColor = false;
            // 
            // Bar2checkBox
            // 
            this.Bar2checkBox.AutoSize = true;
            this.Bar2checkBox.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.Bar2checkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bar2checkBox.Location = new System.Drawing.Point(585, 196);
            this.Bar2checkBox.Margin = new System.Windows.Forms.Padding(4);
            this.Bar2checkBox.Name = "Bar2checkBox";
            this.Bar2checkBox.Size = new System.Drawing.Size(80, 29);
            this.Bar2checkBox.TabIndex = 79;
            this.Bar2checkBox.Text = "Bar 2";
            this.Bar2checkBox.UseVisualStyleBackColor = false;
            // 
            // Booth1checkBox
            // 
            this.Booth1checkBox.AutoSize = true;
            this.Booth1checkBox.BackColor = System.Drawing.Color.PaleVioletRed;
            this.Booth1checkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Booth1checkBox.Location = new System.Drawing.Point(887, 250);
            this.Booth1checkBox.Margin = new System.Windows.Forms.Padding(4);
            this.Booth1checkBox.Name = "Booth1checkBox";
            this.Booth1checkBox.Size = new System.Drawing.Size(101, 29);
            this.Booth1checkBox.TabIndex = 78;
            this.Booth1checkBox.Text = "Booth 1";
            this.Booth1checkBox.UseVisualStyleBackColor = false;
            // 
            // Bar1checkBox
            // 
            this.Bar1checkBox.AutoSize = true;
            this.Bar1checkBox.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.Bar1checkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bar1checkBox.Location = new System.Drawing.Point(477, 196);
            this.Bar1checkBox.Margin = new System.Windows.Forms.Padding(4);
            this.Bar1checkBox.Name = "Bar1checkBox";
            this.Bar1checkBox.Size = new System.Drawing.Size(80, 29);
            this.Bar1checkBox.TabIndex = 77;
            this.Bar1checkBox.Text = "Bar 1";
            this.Bar1checkBox.UseVisualStyleBackColor = false;
            // 
            // Table1checkBox
            // 
            this.Table1checkBox.AutoSize = true;
            this.Table1checkBox.BackColor = System.Drawing.Color.CadetBlue;
            this.Table1checkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Table1checkBox.Location = new System.Drawing.Point(477, 250);
            this.Table1checkBox.Margin = new System.Windows.Forms.Padding(4);
            this.Table1checkBox.Name = "Table1checkBox";
            this.Table1checkBox.Size = new System.Drawing.Size(100, 29);
            this.Table1checkBox.TabIndex = 76;
            this.Table1checkBox.Text = "Table 1";
            this.Table1checkBox.UseVisualStyleBackColor = false;
            // 
            // Notifybutton
            // 
            this.Notifybutton.BackColor = System.Drawing.Color.SpringGreen;
            this.Notifybutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Notifybutton.Location = new System.Drawing.Point(370, 453);
            this.Notifybutton.Margin = new System.Windows.Forms.Padding(4);
            this.Notifybutton.Name = "Notifybutton";
            this.Notifybutton.Size = new System.Drawing.Size(100, 28);
            this.Notifybutton.TabIndex = 74;
            this.Notifybutton.Text = "Notify";
            this.Notifybutton.UseVisualStyleBackColor = false;
            this.Notifybutton.Click += new System.EventHandler(this.Notifybutton_Click);
            // 
            // Queuelabel
            // 
            this.Queuelabel.AutoSize = true;
            this.Queuelabel.BackColor = System.Drawing.Color.Silver;
            this.Queuelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Queuelabel.ForeColor = System.Drawing.Color.Black;
            this.Queuelabel.Location = new System.Drawing.Point(60, 145);
            this.Queuelabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Queuelabel.Name = "Queuelabel";
            this.Queuelabel.Size = new System.Drawing.Size(77, 25);
            this.Queuelabel.TabIndex = 73;
            this.Queuelabel.Text = "Queue";
            // 
            // Removebutton
            // 
            this.Removebutton.BackColor = System.Drawing.Color.IndianRed;
            this.Removebutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Removebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Removebutton.Location = new System.Drawing.Point(13, 453);
            this.Removebutton.Margin = new System.Windows.Forms.Padding(4);
            this.Removebutton.Name = "Removebutton";
            this.Removebutton.Size = new System.Drawing.Size(100, 28);
            this.Removebutton.TabIndex = 72;
            this.Removebutton.Text = "Remove";
            this.Removebutton.UseVisualStyleBackColor = false;
            this.Removebutton.Click += new System.EventHandler(this.Removebutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(479, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 47);
            this.label1.TabIndex = 2;
            this.label1.Text = "Restuarant";
            // 
            // Bar4checkBox
            // 
            this.Bar4checkBox.AutoSize = true;
            this.Bar4checkBox.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.Bar4checkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bar4checkBox.Location = new System.Drawing.Point(803, 196);
            this.Bar4checkBox.Margin = new System.Windows.Forms.Padding(4);
            this.Bar4checkBox.Name = "Bar4checkBox";
            this.Bar4checkBox.Size = new System.Drawing.Size(80, 29);
            this.Bar4checkBox.TabIndex = 81;
            this.Bar4checkBox.Text = "Bar 4";
            this.Bar4checkBox.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.accountBut);
            this.panel1.Controls.Add(this.logOutBut);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1067, 74);
            this.panel1.TabIndex = 75;
            // 
            // userbaseDataSet
            // 
            this.userbaseDataSet.DataSetName = "UserbaseDataSet";
            this.userbaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataMember = "Orders";
            this.ordersBindingSource.DataSource = this.userbaseDataSet;
            // 
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BusinessTableAdapter = null;
            this.tableAdapterManager.CustomerTableAdapter = null;
            this.tableAdapterManager.FavoritesTableAdapter = null;
            this.tableAdapterManager.OrdersTableAdapter = this.ordersTableAdapter;
            this.tableAdapterManager.UpdateOrder = mock_up.UserbaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // ordersDataGridView
            // 
            this.ordersDataGridView.AllowUserToAddRows = false;
            this.ordersDataGridView.AllowUserToDeleteRows = false;
            this.ordersDataGridView.AutoGenerateColumns = false;
            this.ordersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ordersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Customer,
            this.custName,
            this.orderTime});
            this.ordersDataGridView.DataSource = this.ordersBindingSource;
            this.ordersDataGridView.Location = new System.Drawing.Point(12, 173);
            this.ordersDataGridView.Name = "ordersDataGridView";
            this.ordersDataGridView.ReadOnly = true;
            this.ordersDataGridView.RowTemplate.Height = 24;
            this.ordersDataGridView.Size = new System.Drawing.Size(458, 273);
            this.ordersDataGridView.TabIndex = 94;
            // 
            // Customer
            // 
            this.Customer.DataPropertyName = "Customer";
            this.Customer.HeaderText = "Username";
            this.Customer.Name = "Customer";
            this.Customer.ReadOnly = true;
            // 
            // custName
            // 
            this.custName.DataPropertyName = "custName";
            this.custName.HeaderText = "Name";
            this.custName.Name = "custName";
            this.custName.ReadOnly = true;
            // 
            // orderTime
            // 
            this.orderTime.DataPropertyName = "orderTime";
            this.orderTime.HeaderText = "Time";
            this.orderTime.Name = "orderTime";
            this.orderTime.ReadOnly = true;
            // 
            // logOutBut
            // 
            this.logOutBut.Location = new System.Drawing.Point(13, 16);
            this.logOutBut.Name = "logOutBut";
            this.logOutBut.Size = new System.Drawing.Size(131, 39);
            this.logOutBut.TabIndex = 95;
            this.logOutBut.Text = "Log Out";
            this.logOutBut.UseVisualStyleBackColor = true;
            this.logOutBut.Click += new System.EventHandler(this.logOutBut_Click);
            // 
            // accountBut
            // 
            this.accountBut.Location = new System.Drawing.Point(911, 12);
            this.accountBut.Name = "accountBut";
            this.accountBut.Size = new System.Drawing.Size(132, 39);
            this.accountBut.TabIndex = 96;
            this.accountBut.Text = "Account";
            this.accountBut.UseVisualStyleBackColor = true;
            this.accountBut.Click += new System.EventHandler(this.accountBut_Click);
            // 
            // RestuarantForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.ordersDataGridView);
            this.Controls.Add(this.Seatlabel);
            this.Controls.Add(this.BiggerTable3checkBox);
            this.Controls.Add(this.BiggerTable2checkBox);
            this.Controls.Add(this.BiggerTable1checkBox);
            this.Controls.Add(this.Booth4checkBox);
            this.Controls.Add(this.Booth3checkBox);
            this.Controls.Add(this.Booth2checkBox);
            this.Controls.Add(this.Table4checkBox);
            this.Controls.Add(this.Table3checkBox);
            this.Controls.Add(this.Table2checkBox);
            this.Controls.Add(this.Bar5checkBox);
            this.Controls.Add(this.Bar3checkBox);
            this.Controls.Add(this.Bar2checkBox);
            this.Controls.Add(this.Booth1checkBox);
            this.Controls.Add(this.Bar1checkBox);
            this.Controls.Add(this.Table1checkBox);
            this.Controls.Add(this.Notifybutton);
            this.Controls.Add(this.Queuelabel);
            this.Controls.Add(this.Removebutton);
            this.Controls.Add(this.Bar4checkBox);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RestuarantForm";
            this.Text = "RestuarantForm";
            this.Load += new System.EventHandler(this.RestuarantForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userbaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ListBox QueuelistBox;
        private System.Windows.Forms.Label Seatlabel;
        private System.Windows.Forms.CheckBox BiggerTable3checkBox;
        private System.Windows.Forms.CheckBox BiggerTable2checkBox;
        private System.Windows.Forms.CheckBox BiggerTable1checkBox;
        private System.Windows.Forms.CheckBox Booth4checkBox;
        private System.Windows.Forms.CheckBox Booth3checkBox;
        private System.Windows.Forms.CheckBox Booth2checkBox;
        private System.Windows.Forms.CheckBox Table4checkBox;
        private System.Windows.Forms.CheckBox Table3checkBox;
        private System.Windows.Forms.CheckBox Table2checkBox;
        private System.Windows.Forms.CheckBox Bar5checkBox;
        private System.Windows.Forms.CheckBox Bar3checkBox;
        private System.Windows.Forms.CheckBox Bar2checkBox;
        private System.Windows.Forms.CheckBox Booth1checkBox;
        private System.Windows.Forms.CheckBox Bar1checkBox;
        private System.Windows.Forms.CheckBox Table1checkBox;
        private System.Windows.Forms.Button Notifybutton;
        private System.Windows.Forms.Label Queuelabel;
        private System.Windows.Forms.Button Removebutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox Bar4checkBox;
        private System.Windows.Forms.Panel panel1;
        private UserbaseDataSet userbaseDataSet;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private UserbaseDataSetTableAdapters.OrdersTableAdapter ordersTableAdapter;
        private UserbaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView ordersDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Customer;
        private System.Windows.Forms.DataGridViewTextBoxColumn custName;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderTime;
        private System.Windows.Forms.Button logOutBut;
        private System.Windows.Forms.Button accountBut;
    }
}
