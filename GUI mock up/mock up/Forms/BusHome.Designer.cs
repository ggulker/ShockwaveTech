namespace mock_up.Forms
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
            this.QueueDataGridView = new System.Windows.Forms.DataGridView();
            this.customerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quicker_QueueDataSet = new mock_up.Quicker_QueueDataSet();
            this.ordersTableAdapter = new mock_up.Quicker_QueueDataSetTableAdapters.OrdersTableAdapter();
            this.tableAdapterManager = new mock_up.Quicker_QueueDataSetTableAdapters.TableAdapterManager();
            this.logOutBut = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.QueueDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quicker_QueueDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // QueueDataGridView
            // 
            this.QueueDataGridView.AllowUserToAddRows = false;
            this.QueueDataGridView.AllowUserToDeleteRows = false;
            this.QueueDataGridView.AutoGenerateColumns = false;
            this.QueueDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.QueueDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerDataGridViewTextBoxColumn});
            this.QueueDataGridView.DataSource = this.ordersBindingSource;
            this.QueueDataGridView.Location = new System.Drawing.Point(13, 13);
            this.QueueDataGridView.Name = "QueueDataGridView";
            this.QueueDataGridView.ReadOnly = true;
            this.QueueDataGridView.RowTemplate.Height = 24;
            this.QueueDataGridView.Size = new System.Drawing.Size(155, 342);
            this.QueueDataGridView.TabIndex = 0;
            // 
            // customerDataGridViewTextBoxColumn
            // 
            this.customerDataGridViewTextBoxColumn.DataPropertyName = "Customer";
            this.customerDataGridViewTextBoxColumn.HeaderText = "Customer";
            this.customerDataGridViewTextBoxColumn.Name = "customerDataGridViewTextBoxColumn";
            this.customerDataGridViewTextBoxColumn.ReadOnly = true;
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
            // BusHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(796, 452);
            this.Controls.Add(this.logOutBut);
            this.Controls.Add(this.QueueDataGridView);
            this.Name = "BusHome";
            this.Text = "Business Home";
            this.Load += new System.EventHandler(this.BusHome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.QueueDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quicker_QueueDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Quicker_QueueDataSet quicker_QueueDataSet;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private Quicker_QueueDataSetTableAdapters.OrdersTableAdapter ordersTableAdapter;
        private Quicker_QueueDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView QueueDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button logOutBut;
    }
}