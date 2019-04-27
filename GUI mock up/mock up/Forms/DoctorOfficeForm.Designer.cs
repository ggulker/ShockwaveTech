namespace mock_up.Forms
{
    partial class DoctorOfficeForm
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
            this.Doctor3checkBox = new System.Windows.Forms.CheckBox();
            this.Doctor2checkBox = new System.Windows.Forms.CheckBox();
            this.Room6checkBox = new System.Windows.Forms.CheckBox();
            this.Room7checkBox = new System.Windows.Forms.CheckBox();
            this.Room8checkBox = new System.Windows.Forms.CheckBox();
            this.Doctor1checkBox = new System.Windows.Forms.CheckBox();
            this.Room5checkBox = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Doctor4checkBox = new System.Windows.Forms.CheckBox();
            this.Room4checkBox = new System.Windows.Forms.CheckBox();
            this.Room3checkBox = new System.Windows.Forms.CheckBox();
            this.Room2checkBox = new System.Windows.Forms.CheckBox();
            this.Room1checkBox = new System.Windows.Forms.CheckBox();
            this.Notifybutton = new System.Windows.Forms.Button();
            this.Queuelabel = new System.Windows.Forms.Label();
            this.Removebutton = new System.Windows.Forms.Button();
            this.ordersDataGridView = new System.Windows.Forms.DataGridView();
            this.Customer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userbaseDataSet = new mock_up.UserbaseDataSet();
            this.ordersTableAdapter = new mock_up.UserbaseDataSetTableAdapters.OrdersTableAdapter();
            this.tableAdapterManager = new mock_up.UserbaseDataSetTableAdapters.TableAdapterManager();
            this.logOutBut = new System.Windows.Forms.Button();
            this.accountBut = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ordersDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userbaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // Doctor3checkBox
            // 
            this.Doctor3checkBox.AutoSize = true;
            this.Doctor3checkBox.BackColor = System.Drawing.Color.LimeGreen;
            this.Doctor3checkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Doctor3checkBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Doctor3checkBox.Location = new System.Drawing.Point(509, 287);
            this.Doctor3checkBox.Margin = new System.Windows.Forms.Padding(4);
            this.Doctor3checkBox.Name = "Doctor3checkBox";
            this.Doctor3checkBox.Size = new System.Drawing.Size(107, 29);
            this.Doctor3checkBox.TabIndex = 97;
            this.Doctor3checkBox.Text = "Doctor 3";
            this.Doctor3checkBox.UseVisualStyleBackColor = false;
            // 
            // Doctor2checkBox
            // 
            this.Doctor2checkBox.AutoSize = true;
            this.Doctor2checkBox.BackColor = System.Drawing.Color.LimeGreen;
            this.Doctor2checkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Doctor2checkBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Doctor2checkBox.Location = new System.Drawing.Point(509, 235);
            this.Doctor2checkBox.Margin = new System.Windows.Forms.Padding(4);
            this.Doctor2checkBox.Name = "Doctor2checkBox";
            this.Doctor2checkBox.Size = new System.Drawing.Size(107, 29);
            this.Doctor2checkBox.TabIndex = 95;
            this.Doctor2checkBox.Text = "Doctor 2";
            this.Doctor2checkBox.UseVisualStyleBackColor = false;
            // 
            // Room6checkBox
            // 
            this.Room6checkBox.AutoSize = true;
            this.Room6checkBox.BackColor = System.Drawing.Color.PaleVioletRed;
            this.Room6checkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Room6checkBox.Location = new System.Drawing.Point(877, 235);
            this.Room6checkBox.Margin = new System.Windows.Forms.Padding(4);
            this.Room6checkBox.Name = "Room6checkBox";
            this.Room6checkBox.Size = new System.Drawing.Size(101, 29);
            this.Room6checkBox.TabIndex = 94;
            this.Room6checkBox.Text = "Room 6";
            this.Room6checkBox.UseVisualStyleBackColor = false;
            // 
            // Room7checkBox
            // 
            this.Room7checkBox.AutoSize = true;
            this.Room7checkBox.BackColor = System.Drawing.Color.PaleVioletRed;
            this.Room7checkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Room7checkBox.Location = new System.Drawing.Point(877, 287);
            this.Room7checkBox.Margin = new System.Windows.Forms.Padding(4);
            this.Room7checkBox.Name = "Room7checkBox";
            this.Room7checkBox.Size = new System.Drawing.Size(101, 29);
            this.Room7checkBox.TabIndex = 93;
            this.Room7checkBox.Text = "Room 7";
            this.Room7checkBox.UseVisualStyleBackColor = false;
            // 
            // Room8checkBox
            // 
            this.Room8checkBox.AutoSize = true;
            this.Room8checkBox.BackColor = System.Drawing.Color.PaleVioletRed;
            this.Room8checkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Room8checkBox.Location = new System.Drawing.Point(877, 338);
            this.Room8checkBox.Margin = new System.Windows.Forms.Padding(4);
            this.Room8checkBox.Name = "Room8checkBox";
            this.Room8checkBox.Size = new System.Drawing.Size(101, 29);
            this.Room8checkBox.TabIndex = 92;
            this.Room8checkBox.Text = "Room 8";
            this.Room8checkBox.UseVisualStyleBackColor = false;
            // 
            // Doctor1checkBox
            // 
            this.Doctor1checkBox.AutoSize = true;
            this.Doctor1checkBox.BackColor = System.Drawing.Color.LimeGreen;
            this.Doctor1checkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Doctor1checkBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Doctor1checkBox.Location = new System.Drawing.Point(509, 183);
            this.Doctor1checkBox.Margin = new System.Windows.Forms.Padding(4);
            this.Doctor1checkBox.Name = "Doctor1checkBox";
            this.Doctor1checkBox.Size = new System.Drawing.Size(107, 29);
            this.Doctor1checkBox.TabIndex = 91;
            this.Doctor1checkBox.Text = "Doctor 1";
            this.Doctor1checkBox.UseVisualStyleBackColor = false;
            // 
            // Room5checkBox
            // 
            this.Room5checkBox.AutoSize = true;
            this.Room5checkBox.BackColor = System.Drawing.Color.PaleVioletRed;
            this.Room5checkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Room5checkBox.Location = new System.Drawing.Point(877, 183);
            this.Room5checkBox.Margin = new System.Windows.Forms.Padding(4);
            this.Room5checkBox.Name = "Room5checkBox";
            this.Room5checkBox.Size = new System.Drawing.Size(101, 29);
            this.Room5checkBox.TabIndex = 90;
            this.Room5checkBox.Text = "Room 5";
            this.Room5checkBox.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SkyBlue;
            this.panel1.Controls.Add(this.accountBut);
            this.panel1.Controls.Add(this.logOutBut);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1067, 74);
            this.panel1.TabIndex = 83;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(428, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 47);
            this.label1.TabIndex = 2;
            this.label1.Text = "Doctor\'s Office";
            // 
            // Doctor4checkBox
            // 
            this.Doctor4checkBox.AutoSize = true;
            this.Doctor4checkBox.BackColor = System.Drawing.Color.LimeGreen;
            this.Doctor4checkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Doctor4checkBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Doctor4checkBox.Location = new System.Drawing.Point(509, 338);
            this.Doctor4checkBox.Margin = new System.Windows.Forms.Padding(4);
            this.Doctor4checkBox.Name = "Doctor4checkBox";
            this.Doctor4checkBox.Size = new System.Drawing.Size(107, 29);
            this.Doctor4checkBox.TabIndex = 96;
            this.Doctor4checkBox.Text = "Doctor 4";
            this.Doctor4checkBox.UseVisualStyleBackColor = false;
            // 
            // Room4checkBox
            // 
            this.Room4checkBox.AutoSize = true;
            this.Room4checkBox.BackColor = System.Drawing.Color.PaleVioletRed;
            this.Room4checkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Room4checkBox.Location = new System.Drawing.Point(739, 338);
            this.Room4checkBox.Margin = new System.Windows.Forms.Padding(4);
            this.Room4checkBox.Name = "Room4checkBox";
            this.Room4checkBox.Size = new System.Drawing.Size(101, 29);
            this.Room4checkBox.TabIndex = 87;
            this.Room4checkBox.Text = "Room 4";
            this.Room4checkBox.UseVisualStyleBackColor = false;
            // 
            // Room3checkBox
            // 
            this.Room3checkBox.AutoSize = true;
            this.Room3checkBox.BackColor = System.Drawing.Color.PaleVioletRed;
            this.Room3checkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Room3checkBox.Location = new System.Drawing.Point(739, 287);
            this.Room3checkBox.Margin = new System.Windows.Forms.Padding(4);
            this.Room3checkBox.Name = "Room3checkBox";
            this.Room3checkBox.Size = new System.Drawing.Size(101, 29);
            this.Room3checkBox.TabIndex = 86;
            this.Room3checkBox.Text = "Room 3";
            this.Room3checkBox.UseVisualStyleBackColor = false;
            // 
            // Room2checkBox
            // 
            this.Room2checkBox.AutoSize = true;
            this.Room2checkBox.BackColor = System.Drawing.Color.PaleVioletRed;
            this.Room2checkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Room2checkBox.Location = new System.Drawing.Point(739, 235);
            this.Room2checkBox.Margin = new System.Windows.Forms.Padding(4);
            this.Room2checkBox.Name = "Room2checkBox";
            this.Room2checkBox.Size = new System.Drawing.Size(101, 29);
            this.Room2checkBox.TabIndex = 85;
            this.Room2checkBox.Text = "Room 2";
            this.Room2checkBox.UseVisualStyleBackColor = false;
            // 
            // Room1checkBox
            // 
            this.Room1checkBox.AutoSize = true;
            this.Room1checkBox.BackColor = System.Drawing.Color.PaleVioletRed;
            this.Room1checkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Room1checkBox.Location = new System.Drawing.Point(739, 183);
            this.Room1checkBox.Margin = new System.Windows.Forms.Padding(4);
            this.Room1checkBox.Name = "Room1checkBox";
            this.Room1checkBox.Size = new System.Drawing.Size(101, 29);
            this.Room1checkBox.TabIndex = 84;
            this.Room1checkBox.Text = "Room 1";
            this.Room1checkBox.UseVisualStyleBackColor = false;
            // 
            // Notifybutton
            // 
            this.Notifybutton.BackColor = System.Drawing.Color.SpringGreen;
            this.Notifybutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Notifybutton.Location = new System.Drawing.Point(402, 446);
            this.Notifybutton.Margin = new System.Windows.Forms.Padding(4);
            this.Notifybutton.Name = "Notifybutton";
            this.Notifybutton.Size = new System.Drawing.Size(100, 28);
            this.Notifybutton.TabIndex = 82;
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
            this.Queuelabel.Location = new System.Drawing.Point(63, 138);
            this.Queuelabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Queuelabel.Name = "Queuelabel";
            this.Queuelabel.Size = new System.Drawing.Size(77, 25);
            this.Queuelabel.TabIndex = 81;
            this.Queuelabel.Text = "Queue";
            // 
            // Removebutton
            // 
            this.Removebutton.BackColor = System.Drawing.Color.IndianRed;
            this.Removebutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Removebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Removebutton.Location = new System.Drawing.Point(12, 446);
            this.Removebutton.Margin = new System.Windows.Forms.Padding(4);
            this.Removebutton.Name = "Removebutton";
            this.Removebutton.Size = new System.Drawing.Size(100, 28);
            this.Removebutton.TabIndex = 80;
            this.Removebutton.Text = "Remove";
            this.Removebutton.UseVisualStyleBackColor = false;
            this.Removebutton.Click += new System.EventHandler(this.Removebutton_Click);
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
            this.ordersDataGridView.Location = new System.Drawing.Point(12, 166);
            this.ordersDataGridView.Name = "ordersDataGridView";
            this.ordersDataGridView.ReadOnly = true;
            this.ordersDataGridView.RowTemplate.Height = 24;
            this.ordersDataGridView.Size = new System.Drawing.Size(490, 273);
            this.ordersDataGridView.TabIndex = 98;
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
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataMember = "Orders";
            this.ordersBindingSource.DataSource = this.userbaseDataSet;
            // 
            // userbaseDataSet
            // 
            this.userbaseDataSet.DataSetName = "UserbaseDataSet";
            this.userbaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // logOutBut
            // 
            this.logOutBut.Location = new System.Drawing.Point(12, 16);
            this.logOutBut.Name = "logOutBut";
            this.logOutBut.Size = new System.Drawing.Size(131, 39);
            this.logOutBut.TabIndex = 96;
            this.logOutBut.Text = "Log Out";
            this.logOutBut.UseVisualStyleBackColor = true;
            this.logOutBut.Click += new System.EventHandler(this.logOutBut_Click);
            // 
            // accountBut
            // 
            this.accountBut.Location = new System.Drawing.Point(923, 16);
            this.accountBut.Name = "accountBut";
            this.accountBut.Size = new System.Drawing.Size(132, 39);
            this.accountBut.TabIndex = 97;
            this.accountBut.Text = "Account";
            this.accountBut.UseVisualStyleBackColor = true;
            this.accountBut.Click += new System.EventHandler(this.accountBut_Click);
            // 
            // DoctorOfficeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.ordersDataGridView);
            this.Controls.Add(this.Doctor3checkBox);
            this.Controls.Add(this.Doctor2checkBox);
            this.Controls.Add(this.Room6checkBox);
            this.Controls.Add(this.Room7checkBox);
            this.Controls.Add(this.Room8checkBox);
            this.Controls.Add(this.Doctor1checkBox);
            this.Controls.Add(this.Room5checkBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Doctor4checkBox);
            this.Controls.Add(this.Room4checkBox);
            this.Controls.Add(this.Room3checkBox);
            this.Controls.Add(this.Room2checkBox);
            this.Controls.Add(this.Room1checkBox);
            this.Controls.Add(this.Notifybutton);
            this.Controls.Add(this.Queuelabel);
            this.Controls.Add(this.Removebutton);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DoctorOfficeForm";
            this.Text = "DoctorOfficeForm";
            this.Load += new System.EventHandler(this.DoctorOfficeForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ordersDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userbaseDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox Doctor3checkBox;
        private System.Windows.Forms.CheckBox Doctor2checkBox;
        private System.Windows.Forms.CheckBox Room6checkBox;
        private System.Windows.Forms.CheckBox Room7checkBox;
        private System.Windows.Forms.CheckBox Room8checkBox;
        private System.Windows.Forms.CheckBox Doctor1checkBox;
        private System.Windows.Forms.CheckBox Room5checkBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox Doctor4checkBox;
        private System.Windows.Forms.CheckBox Room4checkBox;
        private System.Windows.Forms.CheckBox Room3checkBox;
        private System.Windows.Forms.CheckBox Room2checkBox;
        private System.Windows.Forms.CheckBox Room1checkBox;
        private System.Windows.Forms.Button Notifybutton;
        private System.Windows.Forms.Label Queuelabel;
        private System.Windows.Forms.Button Removebutton;
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