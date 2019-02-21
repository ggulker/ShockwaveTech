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
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.quicker_QueueDataSet = new mock_up.Quicker_QueueDataSet();
            this.businessBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.businessTableAdapter = new mock_up.Quicker_QueueDataSetTableAdapters.BusinessTableAdapter();
            this.tableAdapterManager = new mock_up.Quicker_QueueDataSetTableAdapters.TableAdapterManager();
            this.businessDataGridView = new System.Windows.Forms.DataGridView();
            this.logOutBut = new System.Windows.Forms.Button();
            this.QueueBut = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Here = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quicker_QueueDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.businessBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.businessDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // quicker_QueueDataSet
            // 
            this.quicker_QueueDataSet.DataSetName = "Quicker_QueueDataSet";
            this.quicker_QueueDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // businessBindingSource
            // 
            this.businessBindingSource.DataMember = "Business";
            this.businessBindingSource.DataSource = this.quicker_QueueDataSet;
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
            // businessDataGridView
            // 
            this.businessDataGridView.AllowUserToAddRows = false;
            this.businessDataGridView.AllowUserToDeleteRows = false;
            this.businessDataGridView.AutoGenerateColumns = false;
            this.businessDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.businessDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.businessDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.Here});
            this.businessDataGridView.DataSource = this.businessBindingSource;
            this.businessDataGridView.Location = new System.Drawing.Point(12, 12);
            this.businessDataGridView.Name = "businessDataGridView";
            this.businessDataGridView.ReadOnly = true;
            this.businessDataGridView.RowTemplate.Height = 24;
            this.businessDataGridView.Size = new System.Drawing.Size(584, 336);
            this.businessDataGridView.TabIndex = 0;
            // 
            // logOutBut
            // 
            this.logOutBut.Location = new System.Drawing.Point(653, 12);
            this.logOutBut.Name = "logOutBut";
            this.logOutBut.Size = new System.Drawing.Size(131, 39);
            this.logOutBut.TabIndex = 2;
            this.logOutBut.Text = "Log Out";
            this.logOutBut.UseVisualStyleBackColor = true;
            this.logOutBut.Click += new System.EventHandler(this.logOutBut_Click);
            // 
            // QueueBut
            // 
            this.QueueBut.Location = new System.Drawing.Point(653, 57);
            this.QueueBut.Name = "QueueBut";
            this.QueueBut.Size = new System.Drawing.Size(131, 39);
            this.QueueBut.TabIndex = 3;
            this.QueueBut.Text = "Queue";
            this.QueueBut.UseVisualStyleBackColor = true;
            this.QueueBut.Click += new System.EventHandler(this.QueueBut_Click);
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "BusName";
            this.dataGridViewTextBoxColumn7.HeaderText = "Business";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "openHour";
            this.dataGridViewTextBoxColumn4.HeaderText = "Opens";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "closeHour";
            this.dataGridViewTextBoxColumn5.HeaderText = "Closes";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "BusType";
            this.dataGridViewTextBoxColumn6.HeaderText = "Type";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // Here
            // 
            this.Here.DataPropertyName = "username";
            this.Here.HeaderText = "username";
            this.Here.Name = "Here";
            this.Here.ReadOnly = true;
            this.Here.Visible = false;
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(796, 452);
            this.Controls.Add(this.QueueBut);
            this.Controls.Add(this.logOutBut);
            this.Controls.Add(this.businessDataGridView);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Search";
            this.Text = "Database";
            this.Load += new System.EventHandler(this.Database_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quicker_QueueDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.businessBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.businessDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource1;
        private Quicker_QueueDataSet quicker_QueueDataSet;
        private System.Windows.Forms.BindingSource businessBindingSource;
        private Quicker_QueueDataSetTableAdapters.BusinessTableAdapter businessTableAdapter;
        private Quicker_QueueDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView businessDataGridView;
        private System.Windows.Forms.Button logOutBut;
        private System.Windows.Forms.Button QueueBut;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Here;
    }
}