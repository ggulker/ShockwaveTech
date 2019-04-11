namespace mock_up
{
    partial class Start
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
            this.newBut = new System.Windows.Forms.Button();
            this.loginBut = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // newBut
            // 
            this.newBut.BackColor = System.Drawing.Color.CadetBlue;
            this.newBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newBut.Location = new System.Drawing.Point(169, 200);
            this.newBut.Margin = new System.Windows.Forms.Padding(2);
            this.newBut.Name = "newBut";
            this.newBut.Size = new System.Drawing.Size(258, 57);
            this.newBut.TabIndex = 3;
            this.newBut.Text = "New";
            this.newBut.UseVisualStyleBackColor = false;
            this.newBut.Click += new System.EventHandler(this.newBut_Click);
            // 
            // loginBut
            // 
            this.loginBut.BackColor = System.Drawing.Color.SpringGreen;
            this.loginBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBut.Location = new System.Drawing.Point(169, 114);
            this.loginBut.Margin = new System.Windows.Forms.Padding(2);
            this.loginBut.Name = "loginBut";
            this.loginBut.Size = new System.Drawing.Size(258, 58);
            this.loginBut.TabIndex = 2;
            this.loginBut.Text = "Login";
            this.loginBut.UseVisualStyleBackColor = false;
            this.loginBut.Click += new System.EventHandler(this.loginBut_Click);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Sitka Text", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.Red;
            this.title.Location = new System.Drawing.Point(112, 8);
            this.title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(370, 69);
            this.title.TabIndex = 8;
            this.title.Text = "Quicker Queue";
            this.title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(597, 367);
            this.Controls.Add(this.title);
            this.Controls.Add(this.newBut);
            this.Controls.Add(this.loginBut);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Start";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Start_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button newBut;
        private System.Windows.Forms.Button loginBut;
        private System.Windows.Forms.Label title;
    }
}