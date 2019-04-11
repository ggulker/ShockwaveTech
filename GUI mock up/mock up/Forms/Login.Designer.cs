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
            this.userLab = new System.Windows.Forms.Label();
            this.passLab = new System.Windows.Forms.Label();
            this.loginBut = new System.Windows.Forms.Button();
            this.cancelBut = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.usernameText = new System.Windows.Forms.TextBox();
            this.passText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // userLab
            // 
            this.userLab.AutoSize = true;
            this.userLab.Location = new System.Drawing.Point(331, 298);
            this.userLab.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.userLab.Name = "userLab";
            this.userLab.Size = new System.Drawing.Size(153, 32);
            this.userLab.TabIndex = 3;
            this.userLab.Text = "Username:";
            // 
            // passLab
            // 
            this.passLab.AutoSize = true;
            this.passLab.Location = new System.Drawing.Point(331, 472);
            this.passLab.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.passLab.Name = "passLab";
            this.passLab.Size = new System.Drawing.Size(147, 32);
            this.passLab.TabIndex = 4;
            this.passLab.Text = "Password:";
            // 
            // loginBut
            // 
            this.loginBut.BackColor = System.Drawing.Color.LimeGreen;
            this.loginBut.Location = new System.Drawing.Point(813, 596);
            this.loginBut.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.loginBut.Name = "loginBut";
            this.loginBut.Size = new System.Drawing.Size(277, 60);
            this.loginBut.TabIndex = 5;
            this.loginBut.Text = "Login";
            this.loginBut.UseVisualStyleBackColor = false;
            this.loginBut.Click += new System.EventHandler(this.loginBut_Click);
            // 
            // cancelBut
            // 
            this.cancelBut.Location = new System.Drawing.Point(491, 596);
            this.cancelBut.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.cancelBut.Name = "cancelBut";
            this.cancelBut.Size = new System.Drawing.Size(277, 60);
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
            this.title.Location = new System.Drawing.Point(299, 19);
            this.title.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(920, 174);
            this.title.TabIndex = 7;
            this.title.Text = "Quicker Queue";
            this.title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // usernameText
            // 
            this.usernameText.Location = new System.Drawing.Point(491, 298);
            this.usernameText.Name = "usernameText";
            this.usernameText.Size = new System.Drawing.Size(591, 38);
            this.usernameText.TabIndex = 8;
            // 
            // passText
            // 
            this.passText.Location = new System.Drawing.Point(491, 472);
            this.passText.Name = "passText";
            this.passText.PasswordChar = '*';
            this.passText.Size = new System.Drawing.Size(591, 38);
            this.passText.TabIndex = 9;
            this.passText.UseSystemPasswordChar = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1592, 875);
            this.Controls.Add(this.passText);
            this.Controls.Add(this.usernameText);
            this.Controls.Add(this.title);
            this.Controls.Add(this.cancelBut);
            this.Controls.Add(this.loginBut);
            this.Controls.Add(this.passLab);
            this.Controls.Add(this.userLab);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Login";
            this.Text = "Login Prompt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label userLab;
        private System.Windows.Forms.Label passLab;
        private System.Windows.Forms.Button loginBut;
        private System.Windows.Forms.Button cancelBut;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.TextBox usernameText;
        private System.Windows.Forms.TextBox passText;
    }
}