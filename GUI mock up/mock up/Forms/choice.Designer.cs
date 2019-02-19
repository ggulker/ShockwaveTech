namespace mock_up
{
    partial class choice
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
            this.busBut = new System.Windows.Forms.Button();
            this.userBut = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // busBut
            // 
            this.busBut.Location = new System.Drawing.Point(226, 130);
            this.busBut.Margin = new System.Windows.Forms.Padding(2);
            this.busBut.Name = "busBut";
            this.busBut.Size = new System.Drawing.Size(344, 86);
            this.busBut.TabIndex = 0;
            this.busBut.Text = "Business";
            this.busBut.UseVisualStyleBackColor = true;
            this.busBut.Click += new System.EventHandler(this.busBut_Click);
            // 
            // userBut
            // 
            this.userBut.Location = new System.Drawing.Point(226, 242);
            this.userBut.Margin = new System.Windows.Forms.Padding(2);
            this.userBut.Name = "userBut";
            this.userBut.Size = new System.Drawing.Size(344, 86);
            this.userBut.TabIndex = 1;
            this.userBut.Text = "User";
            this.userBut.UseVisualStyleBackColor = true;
            this.userBut.Click += new System.EventHandler(this.userBut_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Text", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(150, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(461, 87);
            this.label2.TabIndex = 8;
            this.label2.Text = "Quicker Queue";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // choice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(796, 452);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.userBut);
            this.Controls.Add(this.busBut);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "choice";
            this.Text = "ShockWave Inc.";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button busBut;
        private System.Windows.Forms.Button userBut;
        private System.Windows.Forms.Label label2;
    }
}

