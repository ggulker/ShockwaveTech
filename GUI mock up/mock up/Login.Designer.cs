namespace mock_up
{
    partial class Login
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
            this.newBut.Location = new System.Drawing.Point(225, 246);
            this.newBut.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.newBut.Name = "newBut";
            this.newBut.Size = new System.Drawing.Size(344, 70);
            this.newBut.TabIndex = 3;
            this.newBut.Text = "New";
            this.newBut.UseVisualStyleBackColor = true;
            // 
            // loginBut
            // 
            this.loginBut.Location = new System.Drawing.Point(225, 140);
            this.loginBut.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.loginBut.Name = "loginBut";
            this.loginBut.Size = new System.Drawing.Size(344, 72);
            this.loginBut.TabIndex = 2;
            this.loginBut.Text = "Login";
            this.loginBut.UseVisualStyleBackColor = true;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Sitka Text", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(150, 10);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(461, 87);
            this.title.TabIndex = 8;
            this.title.Text = "Quicker Queue";
            this.title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(796, 452);
            this.Controls.Add(this.title);
            this.Controls.Add(this.newBut);
            this.Controls.Add(this.loginBut);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button newBut;
        private System.Windows.Forms.Button loginBut;
        private System.Windows.Forms.Label title;
    }
}