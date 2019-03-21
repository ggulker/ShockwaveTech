namespace WindowsFormsApp2
{
    partial class Register
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
            this.NametextBox = new System.Windows.Forms.TextBox();
            this.Namelabel = new System.Windows.Forms.Label();
            this.Emaillabel = new System.Windows.Forms.Label();
            this.EmailtextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PasswordtextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.UserIDtextBox = new System.Windows.Forms.TextBox();
            this.Registerbutton = new System.Windows.Forms.Button();
            this.Cancelbutton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // NametextBox
            // 
            this.NametextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.NametextBox.Location = new System.Drawing.Point(172, 111);
            this.NametextBox.Name = "NametextBox";
            this.NametextBox.Size = new System.Drawing.Size(165, 20);
            this.NametextBox.TabIndex = 0;
            // 
            // Namelabel
            // 
            this.Namelabel.AutoSize = true;
            this.Namelabel.Location = new System.Drawing.Point(131, 114);
            this.Namelabel.Name = "Namelabel";
            this.Namelabel.Size = new System.Drawing.Size(38, 13);
            this.Namelabel.TabIndex = 1;
            this.Namelabel.Text = "Name:";
            // 
            // Emaillabel
            // 
            this.Emaillabel.AutoSize = true;
            this.Emaillabel.Location = new System.Drawing.Point(131, 166);
            this.Emaillabel.Name = "Emaillabel";
            this.Emaillabel.Size = new System.Drawing.Size(35, 13);
            this.Emaillabel.TabIndex = 3;
            this.Emaillabel.Text = "Email:";
            // 
            // EmailtextBox
            // 
            this.EmailtextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.EmailtextBox.Location = new System.Drawing.Point(172, 163);
            this.EmailtextBox.Name = "EmailtextBox";
            this.EmailtextBox.Size = new System.Drawing.Size(165, 20);
            this.EmailtextBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(113, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Password:";
            // 
            // PasswordtextBox
            // 
            this.PasswordtextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PasswordtextBox.Location = new System.Drawing.Point(172, 189);
            this.PasswordtextBox.Name = "PasswordtextBox";
            this.PasswordtextBox.Size = new System.Drawing.Size(165, 20);
            this.PasswordtextBox.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(123, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "UserID:";
            // 
            // UserIDtextBox
            // 
            this.UserIDtextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.UserIDtextBox.Location = new System.Drawing.Point(172, 137);
            this.UserIDtextBox.Name = "UserIDtextBox";
            this.UserIDtextBox.Size = new System.Drawing.Size(165, 20);
            this.UserIDtextBox.TabIndex = 6;
            // 
            // Registerbutton
            // 
            this.Registerbutton.BackColor = System.Drawing.Color.SpringGreen;
            this.Registerbutton.Location = new System.Drawing.Point(262, 215);
            this.Registerbutton.Name = "Registerbutton";
            this.Registerbutton.Size = new System.Drawing.Size(75, 23);
            this.Registerbutton.TabIndex = 8;
            this.Registerbutton.Text = "Register";
            this.Registerbutton.UseVisualStyleBackColor = false;
            // 
            // Cancelbutton
            // 
            this.Cancelbutton.BackColor = System.Drawing.Color.DimGray;
            this.Cancelbutton.Location = new System.Drawing.Point(172, 215);
            this.Cancelbutton.Name = "Cancelbutton";
            this.Cancelbutton.Size = new System.Drawing.Size(75, 23);
            this.Cancelbutton.TabIndex = 9;
            this.Cancelbutton.Text = "Cancel";
            this.Cancelbutton.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(495, 60);
            this.panel1.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(64, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Create Account";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.SWicon30x30;
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(72, 37);
            this.panel2.TabIndex = 0;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(495, 369);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Cancelbutton);
            this.Controls.Add(this.Registerbutton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.UserIDtextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PasswordtextBox);
            this.Controls.Add(this.Emaillabel);
            this.Controls.Add(this.EmailtextBox);
            this.Controls.Add(this.Namelabel);
            this.Controls.Add(this.NametextBox);
            this.Name = "Register";
            this.Text = "Register";
            this.Load += new System.EventHandler(this.Register_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NametextBox;
        private System.Windows.Forms.Label Namelabel;
        private System.Windows.Forms.Label Emaillabel;
        private System.Windows.Forms.TextBox EmailtextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PasswordtextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox UserIDtextBox;
        private System.Windows.Forms.Button Registerbutton;
        private System.Windows.Forms.Button Cancelbutton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
    }
}

