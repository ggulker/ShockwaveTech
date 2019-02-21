namespace mock_up.Forms
{
    partial class Finalize
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
            this.QueueBut = new System.Windows.Forms.Button();
            this.CloseBut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // QueueBut
            // 
            this.QueueBut.Location = new System.Drawing.Point(86, 77);
            this.QueueBut.Name = "QueueBut";
            this.QueueBut.Size = new System.Drawing.Size(107, 36);
            this.QueueBut.TabIndex = 0;
            this.QueueBut.Text = "Queue";
            this.QueueBut.UseVisualStyleBackColor = true;
            this.QueueBut.Click += new System.EventHandler(this.QueueBut_Click);
            // 
            // CloseBut
            // 
            this.CloseBut.Location = new System.Drawing.Point(86, 136);
            this.CloseBut.Name = "CloseBut";
            this.CloseBut.Size = new System.Drawing.Size(107, 36);
            this.CloseBut.TabIndex = 1;
            this.CloseBut.Text = "Close";
            this.CloseBut.UseVisualStyleBackColor = true;
            this.CloseBut.Click += new System.EventHandler(this.CloseBut_Click);
            // 
            // Queue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.CloseBut);
            this.Controls.Add(this.QueueBut);
            this.Name = "Queue";
            this.Text = "Queue";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button QueueBut;
        private System.Windows.Forms.Button CloseBut;
    }
}