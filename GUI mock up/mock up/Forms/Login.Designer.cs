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
            this.usernameText = new System.Windows.Forms.RichTextBox();
            this.passText = new System.Windows.Forms.RichTextBox();
            this.userLab = new System.Windows.Forms.Label();
            this.passLab = new System.Windows.Forms.Label();
            this.loginBut = new System.Windows.Forms.Button();
            this.cancelBut = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // usernameText
            // 
            this.usernameText.Location = new System.Drawing.Point(185, 123);
            this.usernameText.Margin = new System.Windows.Forms.Padding(2);
            this.usernameText.Name = "usernameText";
            this.usernameText.Size = new System.Drawing.Size(224, 28);
            this.usernameText.TabIndex = 1;
            this.usernameText.Text = "";
            // 
            // passText
            // 
            this.passText.Location = new System.Drawing.Point(184, 196);
            this.passText.Margin = new System.Windows.Forms.Padding(2);
            this.passText.Name = "passText";
            this.passText.Size = new System.Drawing.Size(224, 28);
            this.passText.TabIndex = 2;
            this.passText.Text = "";
            // 
            // userLab
            // 
            this.userLab.AutoSize = true;
            this.userLab.Location = new System.Drawing.Point(124, 125);
            this.userLab.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.userLab.Name = "userLab";
            this.userLab.Size = new System.Drawing.Size(58, 13);
            this.userLab.TabIndex = 3;
            this.userLab.Text = "Username:";
            // 
            // passLab
            // 
            this.passLab.AutoSize = true;
            this.passLab.Location = new System.Drawing.Point(124, 198);
            this.passLab.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.passLab.Name = "passLab";
            this.passLab.Size = new System.Drawing.Size(56, 13);
            this.passLab.TabIndex = 4;
            this.passLab.Text = "Password:";
            // 
            // loginBut
            // 
            this.loginBut.BackColor = System.Drawing.Color.LimeGreen;
            this.loginBut.Location = new System.Drawing.Point(305, 250);
            this.loginBut.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.loginBut.Name = "loginBut";
            this.loginBut.Size = new System.Drawing.Size(104, 25);
            this.loginBut.TabIndex = 5;
            this.loginBut.Text = "Login";
            this.loginBut.UseVisualStyleBackColor = false;
            this.loginBut.Click += new System.EventHandler(this.loginBut_Click);
            // 
            // cancelBut
            // 
            this.cancelBut.Location = new System.Drawing.Point(184, 250);
            this.cancelBut.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cancelBut.Name = "cancelBut";
            this.cancelBut.Size = new System.Drawing.Size(104, 25);
            this.cancelBut.TabIndex = 6;
            this.cancelBut.Text = "Cancel";
            this.cancelBut.UseVisualStyleBackColor = true;
            this.cancelBut.Click += new System.EventHandler(this.cancelBut_Click);
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
            this.title.TabIndex = 7;
            this.title.Text = "Quicker Queue";
            this.title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(597, 367);
            this.Controls.Add(this.title);
            this.Controls.Add(this.cancelBut);
            this.Controls.Add(this.loginBut);
            this.Controls.Add(this.passLab);
            this.Controls.Add(this.userLab);
            this.Controls.Add(this.passText);
            this.Controls.Add(this.usernameText);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Login";
            this.Text = "Login Prompt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox usernameText;
        private System.Windows.Forms.RichTextBox passText;
        private System.Windows.Forms.Label userLab;
        private System.Windows.Forms.Label passLab;
        private System.Windows.Forms.Button loginBut;
        private System.Windows.Forms.Button cancelBut;
        private System.Windows.Forms.Label title;
    }
}