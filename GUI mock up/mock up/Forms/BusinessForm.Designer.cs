namespace WindowsFormsApp2
{
    partial class BusinessForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Cancelbutton = new System.Windows.Forms.Button();
            this.Registerbutton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.UserIDtextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PasswordtextBox = new System.Windows.Forms.TextBox();
            this.Emaillabel = new System.Windows.Forms.Label();
            this.EmailtextBox = new System.Windows.Forms.TextBox();
            this.Namelabel = new System.Windows.Forms.Label();
            this.NametextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ClosecomboBox = new System.Windows.Forms.ComboBox();
            this.Closelabel = new System.Windows.Forms.Label();
            this.ClosetextBox = new System.Windows.Forms.TextBox();
            this.OpencomboBox = new System.Windows.Forms.ComboBox();
            this.Openlabel = new System.Windows.Forms.Label();
            this.OpentextBox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(625, 60);
            this.panel1.TabIndex = 22;
            // 
            // panel2
            // 
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(72, 37);
            this.panel2.TabIndex = 0;
            // 
            // Cancelbutton
            // 
            this.Cancelbutton.BackColor = System.Drawing.Color.DimGray;
            this.Cancelbutton.Location = new System.Drawing.Point(209, 291);
            this.Cancelbutton.Name = "Cancelbutton";
            this.Cancelbutton.Size = new System.Drawing.Size(75, 23);
            this.Cancelbutton.TabIndex = 21;
            this.Cancelbutton.Text = "Cancel";
            this.Cancelbutton.UseVisualStyleBackColor = false;
            // 
            // Registerbutton
            // 
            this.Registerbutton.BackColor = System.Drawing.Color.SpringGreen;
            this.Registerbutton.Location = new System.Drawing.Point(299, 291);
            this.Registerbutton.Name = "Registerbutton";
            this.Registerbutton.Size = new System.Drawing.Size(75, 23);
            this.Registerbutton.TabIndex = 20;
            this.Registerbutton.Text = "Register";
            this.Registerbutton.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(160, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "UserID:";
            // 
            // UserIDtextBox
            // 
            this.UserIDtextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.UserIDtextBox.Location = new System.Drawing.Point(209, 161);
            this.UserIDtextBox.Name = "UserIDtextBox";
            this.UserIDtextBox.Size = new System.Drawing.Size(165, 20);
            this.UserIDtextBox.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(150, 268);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Password:";
            // 
            // PasswordtextBox
            // 
            this.PasswordtextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PasswordtextBox.Location = new System.Drawing.Point(209, 265);
            this.PasswordtextBox.Name = "PasswordtextBox";
            this.PasswordtextBox.Size = new System.Drawing.Size(165, 20);
            this.PasswordtextBox.TabIndex = 16;
            // 
            // Emaillabel
            // 
            this.Emaillabel.AutoSize = true;
            this.Emaillabel.Location = new System.Drawing.Point(168, 190);
            this.Emaillabel.Name = "Emaillabel";
            this.Emaillabel.Size = new System.Drawing.Size(35, 13);
            this.Emaillabel.TabIndex = 15;
            this.Emaillabel.Text = "Email:";
            // 
            // EmailtextBox
            // 
            this.EmailtextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.EmailtextBox.Location = new System.Drawing.Point(209, 187);
            this.EmailtextBox.Name = "EmailtextBox";
            this.EmailtextBox.Size = new System.Drawing.Size(165, 20);
            this.EmailtextBox.TabIndex = 14;
            // 
            // Namelabel
            // 
            this.Namelabel.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.Namelabel.AutoSize = true;
            this.Namelabel.Location = new System.Drawing.Point(120, 138);
            this.Namelabel.Name = "Namelabel";
            this.Namelabel.Size = new System.Drawing.Size(83, 13);
            this.Namelabel.TabIndex = 13;
            this.Namelabel.Text = "Business Name:";
            // 
            // NametextBox
            // 
            this.NametextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.NametextBox.Location = new System.Drawing.Point(209, 135);
            this.NametextBox.Name = "NametextBox";
            this.NametextBox.Size = new System.Drawing.Size(165, 20);
            this.NametextBox.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(101, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 20);
            this.label1.TabIndex = 23;
            this.label1.Text = "Create Account";
            // 
            // ClosecomboBox
            // 
            this.ClosecomboBox.BackColor = System.Drawing.SystemColors.Control;
            this.ClosecomboBox.FormattingEnabled = true;
            this.ClosecomboBox.Location = new System.Drawing.Point(263, 238);
            this.ClosecomboBox.Name = "ClosecomboBox";
            this.ClosecomboBox.Size = new System.Drawing.Size(40, 21);
            this.ClosecomboBox.TabIndex = 16;
            this.ClosecomboBox.Text = "pm";
            // 
            // Closelabel
            // 
            this.Closelabel.AutoSize = true;
            this.Closelabel.Location = new System.Drawing.Point(167, 242);
            this.Closelabel.Name = "Closelabel";
            this.Closelabel.Size = new System.Drawing.Size(36, 13);
            this.Closelabel.TabIndex = 15;
            this.Closelabel.Text = "Close:";
            // 
            // ClosetextBox
            // 
            this.ClosetextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClosetextBox.Location = new System.Drawing.Point(209, 239);
            this.ClosetextBox.Name = "ClosetextBox";
            this.ClosetextBox.Size = new System.Drawing.Size(48, 20);
            this.ClosetextBox.TabIndex = 14;
            // 
            // OpencomboBox
            // 
            this.OpencomboBox.BackColor = System.Drawing.SystemColors.Control;
            this.OpencomboBox.FormattingEnabled = true;
            this.OpencomboBox.Location = new System.Drawing.Point(263, 212);
            this.OpencomboBox.Name = "OpencomboBox";
            this.OpencomboBox.Size = new System.Drawing.Size(40, 21);
            this.OpencomboBox.TabIndex = 13;
            this.OpencomboBox.Text = "am";
            // 
            // Openlabel
            // 
            this.Openlabel.AutoSize = true;
            this.Openlabel.Location = new System.Drawing.Point(167, 216);
            this.Openlabel.Name = "Openlabel";
            this.Openlabel.Size = new System.Drawing.Size(36, 13);
            this.Openlabel.TabIndex = 12;
            this.Openlabel.Text = "Open:";
            // 
            // OpentextBox
            // 
            this.OpentextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.OpentextBox.Location = new System.Drawing.Point(209, 213);
            this.OpentextBox.Name = "OpentextBox";
            this.OpentextBox.Size = new System.Drawing.Size(48, 20);
            this.OpentextBox.TabIndex = 11;
            // 
            // BusinessForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 376);
            this.Controls.Add(this.ClosecomboBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Closelabel);
            this.Controls.Add(this.Cancelbutton);
            this.Controls.Add(this.ClosetextBox);
            this.Controls.Add(this.OpencomboBox);
            this.Controls.Add(this.Registerbutton);
            this.Controls.Add(this.Openlabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.OpentextBox);
            this.Controls.Add(this.UserIDtextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PasswordtextBox);
            this.Controls.Add(this.Emaillabel);
            this.Controls.Add(this.EmailtextBox);
            this.Controls.Add(this.Namelabel);
            this.Controls.Add(this.NametextBox);
            this.Controls.Add(this.label1);
            this.Name = "BusinessForm";
            this.Text = "Business Register";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Cancelbutton;
        private System.Windows.Forms.Button Registerbutton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox UserIDtextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PasswordtextBox;
        private System.Windows.Forms.Label Emaillabel;
        private System.Windows.Forms.TextBox EmailtextBox;
        private System.Windows.Forms.Label Namelabel;
        private System.Windows.Forms.TextBox NametextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ClosecomboBox;
        private System.Windows.Forms.Label Closelabel;
        private System.Windows.Forms.TextBox ClosetextBox;
        private System.Windows.Forms.ComboBox OpencomboBox;
        private System.Windows.Forms.Label Openlabel;
        private System.Windows.Forms.TextBox OpentextBox;
    }
}