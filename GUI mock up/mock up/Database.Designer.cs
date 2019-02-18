namespace mock_up
{
    partial class Database
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
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.businessDataGridView.AutoGenerateColumns = false;
            this.businessDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.businessDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.businessDataGridView.DataSource = this.businessBindingSource;
            this.businessDataGridView.Location = new System.Drawing.Point(12, 35);
            this.businessDataGridView.Name = "businessDataGridView";
            this.businessDataGridView.RowTemplate.Height = 24;
            this.businessDataGridView.Size = new System.Drawing.Size(444, 336);
            this.businessDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "BusName";
            this.dataGridViewTextBoxColumn7.HeaderText = "BusName";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "openHour";
            this.dataGridViewTextBoxColumn4.HeaderText = "openHour";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "closeHour";
            this.dataGridViewTextBoxColumn5.HeaderText = "closeHour";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "BusType";
            this.dataGridViewTextBoxColumn6.HeaderText = "BusType";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // Database
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(796, 452);
            this.Controls.Add(this.businessDataGridView);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Database";
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
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}