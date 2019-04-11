namespace mock_up
{
    partial class BusHome
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
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quicker_QueueDataSet = new mock_up.Quicker_QueueDataSet();
            this.ordersTableAdapter = new mock_up.Quicker_QueueDataSetTableAdapters.OrdersTableAdapter();
            this.tableAdapterManager = new mock_up.Quicker_QueueDataSetTableAdapters.TableAdapterManager();
            this.logOutBut = new System.Windows.Forms.Button();
            this.userbaseDataSet = new mock_up.UserbaseDataSet();
            this.ordersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ordersTableAdapter1 = new mock_up.UserbaseDataSetTableAdapters.OrdersTableAdapter();
            this.tableAdapterManager1 = new mock_up.UserbaseDataSetTableAdapters.TableAdapterManager();
            this.ordersDataGridView = new System.Windows.Forms.DataGridView();
            this.Customer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notifyBut = new System.Windows.Forms.Button();
            this.removeBut = new System.Windows.Forms.Button();
            this.accountBut = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quicker_QueueDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userbaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataMember = "Orders";
            this.ordersBindingSource.DataSource = this.quicker_QueueDataSet;
            // 
            // quicker_QueueDataSet
            // 
            this.quicker_QueueDataSet.DataSetName = "Quicker_QueueDataSet";
            this.quicker_QueueDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.tableAdapterManager.OrdersTableAdapter = this.ordersTableAdapter;
            this.tableAdapterManager.UpdateOrder = mock_up.Quicker_QueueDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // logOutBut
            // 
            this.logOutBut.Location = new System.Drawing.Point(653, 13);
            this.logOutBut.Name = "logOutBut";
            this.logOutBut.Size = new System.Drawing.Size(131, 39);
            this.logOutBut.TabIndex = 1;
            this.logOutBut.Text = "Log Out";
            this.logOutBut.UseVisualStyleBackColor = true;
            this.logOutBut.Click += new System.EventHandler(this.logOutBut_Click);
            // 
            // userbaseDataSet
            // 
            this.userbaseDataSet.DataSetName = "UserbaseDataSet";
            this.userbaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ordersBindingSource1
            // 
            this.ordersBindingSource1.DataMember = "Orders";
            this.ordersBindingSource1.DataSource = this.userbaseDataSet;
            // 
            // ordersTableAdapter1
            // 
            this.ordersTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.BusinessTableAdapter = null;
            this.tableAdapterManager1.CustomerTableAdapter = null;
            this.tableAdapterManager1.FavoritesTableAdapter = null;
            this.tableAdapterManager1.OrdersTableAdapter = this.ordersTableAdapter1;
            this.tableAdapterManager1.UpdateOrder = mock_up.UserbaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // ordersDataGridView
            // 
            this.ordersDataGridView.AllowUserToAddRows = false;
            this.ordersDataGridView.AllowUserToDeleteRows = false;
            this.ordersDataGridView.AutoGenerateColumns = false;
            this.ordersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ordersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Customer});
            this.ordersDataGridView.DataSource = this.ordersBindingSource1;
            this.ordersDataGridView.Location = new System.Drawing.Point(12, 13);
            this.ordersDataGridView.Name = "ordersDataGridView";
            this.ordersDataGridView.ReadOnly = true;
            this.ordersDataGridView.RowTemplate.Height = 24;
            this.ordersDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ordersDataGridView.Size = new System.Drawing.Size(189, 415);
            this.ordersDataGridView.TabIndex = 2;
            // 
            // Customer
            // 
            this.Customer.DataPropertyName = "Customer";
            this.Customer.HeaderText = "Customer";
            this.Customer.Name = "Customer";
            this.Customer.ReadOnly = true;
            // 
            // notifyBut
            // 
            this.notifyBut.Location = new System.Drawing.Point(220, 404);
            this.notifyBut.Name = "notifyBut";
            this.notifyBut.Size = new System.Drawing.Size(75, 23);
            this.notifyBut.TabIndex = 3;
            this.notifyBut.Text = "Notify";
            this.notifyBut.UseVisualStyleBackColor = true;
            this.notifyBut.Click += new System.EventHandler(this.notifyBut_Click);
            // 
            // removeBut
            // 
            this.removeBut.Location = new System.Drawing.Point(220, 375);
            this.removeBut.Name = "removeBut";
            this.removeBut.Size = new System.Drawing.Size(75, 23);
            this.removeBut.TabIndex = 4;
            this.removeBut.Text = "Remove";
            this.removeBut.UseVisualStyleBackColor = true;
            this.removeBut.Click += new System.EventHandler(this.removeBut_Click);
            // 
            // accountBut
            // 
            this.accountBut.Location = new System.Drawing.Point(220, 346);
            this.accountBut.Name = "accountBut";
            this.accountBut.Size = new System.Drawing.Size(75, 23);
            this.accountBut.TabIndex = 5;
            this.accountBut.TabStop = false;
            this.accountBut.Text = "account";
            this.accountBut.UseVisualStyleBackColor = true;
            this.accountBut.Click += new System.EventHandler(this.accountBut_Click);
            // 
            // BusHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(804, 452);
            this.Controls.Add(this.accountBut);
            this.Controls.Add(this.removeBut);
            this.Controls.Add(this.notifyBut);
            this.Controls.Add(this.ordersDataGridView);
            this.Controls.Add(this.logOutBut);
            this.Name = "BusHome";
            this.Text = "Business Home";
            this.Load += new System.EventHandler(this.BusHome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quicker_QueueDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userbaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersDataGridView)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private Quicker_QueueDataSet quicker_QueueDataSet;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private Quicker_QueueDataSetTableAdapters.OrdersTableAdapter ordersTableAdapter;
        private Quicker_QueueDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button logOutBut;
        private UserbaseDataSet userbaseDataSet;
        private System.Windows.Forms.BindingSource ordersBindingSource1;
        private UserbaseDataSetTableAdapters.OrdersTableAdapter ordersTableAdapter1;
        private UserbaseDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.DataGridView ordersDataGridView;
        private System.Windows.Forms.Button notifyBut;
        private System.Windows.Forms.Button removeBut;
        private System.Windows.Forms.DataGridViewTextBoxColumn Customer;
        private System.Windows.Forms.Button accountBut;
    }
}