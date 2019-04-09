namespace WindowsFormsApp2
{
    partial class CustumerPageForm
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.UserIDtextBox = new System.Windows.Forms.TextBox();
            this.Emaillabel = new System.Windows.Forms.Label();
            this.EmailtextBox = new System.Windows.Forms.TextBox();
            this.Namelabel = new System.Windows.Forms.Label();
            this.NametextBox = new System.Windows.Forms.TextBox();
            this.Cancelbutton = new System.Windows.Forms.Button();
            this.ChangePasswordbutton = new System.Windows.Forms.Button();
            this.LogOutbutton = new System.Windows.Forms.Button();
            this.Editbutton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Red;
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(72, 37);
            this.panel2.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 60);
            this.panel1.TabIndex = 65;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(261, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "User\'s Profile";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(295, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "UserID:";
            // 
            // UserIDtextBox
            // 
            this.UserIDtextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.UserIDtextBox.Location = new System.Drawing.Point(344, 179);
            this.UserIDtextBox.Name = "UserIDtextBox";
            this.UserIDtextBox.Size = new System.Drawing.Size(165, 20);
            this.UserIDtextBox.TabIndex = 18;
            // 
            // Emaillabel
            // 
            this.Emaillabel.AutoSize = true;
            this.Emaillabel.Location = new System.Drawing.Point(303, 208);
            this.Emaillabel.Name = "Emaillabel";
            this.Emaillabel.Size = new System.Drawing.Size(35, 13);
            this.Emaillabel.TabIndex = 15;
            this.Emaillabel.Text = "Email:";
            // 
            // EmailtextBox
            // 
            this.EmailtextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.EmailtextBox.Location = new System.Drawing.Point(344, 205);
            this.EmailtextBox.Name = "EmailtextBox";
            this.EmailtextBox.Size = new System.Drawing.Size(165, 20);
            this.EmailtextBox.TabIndex = 14;
            // 
            // Namelabel
            // 
            this.Namelabel.AutoSize = true;
            this.Namelabel.Location = new System.Drawing.Point(303, 156);
            this.Namelabel.Name = "Namelabel";
            this.Namelabel.Size = new System.Drawing.Size(38, 13);
            this.Namelabel.TabIndex = 13;
            this.Namelabel.Text = "Name:";
            // 
            // NametextBox
            // 
            this.NametextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.NametextBox.Location = new System.Drawing.Point(344, 153);
            this.NametextBox.Name = "NametextBox";
            this.NametextBox.Size = new System.Drawing.Size(165, 20);
            this.NametextBox.TabIndex = 12;
            // 
            // Cancelbutton
            // 
            this.Cancelbutton.BackColor = System.Drawing.Color.DimGray;
            this.Cancelbutton.Location = new System.Drawing.Point(434, 281);
            this.Cancelbutton.Name = "Cancelbutton";
            this.Cancelbutton.Size = new System.Drawing.Size(75, 23);
            this.Cancelbutton.TabIndex = 67;
            this.Cancelbutton.Text = "Cancel";
            this.Cancelbutton.UseVisualStyleBackColor = false;
            // 
            // ChangePasswordbutton
            // 
            this.ChangePasswordbutton.BackColor = System.Drawing.Color.SpringGreen;
            this.ChangePasswordbutton.Location = new System.Drawing.Point(373, 231);
            this.ChangePasswordbutton.Name = "ChangePasswordbutton";
            this.ChangePasswordbutton.Size = new System.Drawing.Size(101, 23);
            this.ChangePasswordbutton.TabIndex = 66;
            this.ChangePasswordbutton.Text = "Change Password";
            this.ChangePasswordbutton.UseVisualStyleBackColor = false;
            // 
            // LogOutbutton
            // 
            this.LogOutbutton.BackColor = System.Drawing.Color.Salmon;
            this.LogOutbutton.Location = new System.Drawing.Point(344, 281);
            this.LogOutbutton.Name = "LogOutbutton";
            this.LogOutbutton.Size = new System.Drawing.Size(75, 23);
            this.LogOutbutton.TabIndex = 68;
            this.LogOutbutton.Text = "Log Out";
            this.LogOutbutton.UseVisualStyleBackColor = false;
            // 
            // Editbutton
            // 
            this.Editbutton.BackColor = System.Drawing.Color.Lavender;
            this.Editbutton.Location = new System.Drawing.Point(471, 124);
            this.Editbutton.Name = "Editbutton";
            this.Editbutton.Size = new System.Drawing.Size(38, 23);
            this.Editbutton.TabIndex = 69;
            this.Editbutton.Text = "Edit";
            this.Editbutton.UseVisualStyleBackColor = false;
            // 
            // CustumerPageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Editbutton);
            this.Controls.Add(this.LogOutbutton);
            this.Controls.Add(this.Cancelbutton);
            this.Controls.Add(this.ChangePasswordbutton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.UserIDtextBox);
            this.Controls.Add(this.NametextBox);
            this.Controls.Add(this.Namelabel);
            this.Controls.Add(this.EmailtextBox);
            this.Controls.Add(this.Emaillabel);
            this.Name = "CustumerPageForm";
            this.Text = "CustumerPageForm";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox UserIDtextBox;
        private System.Windows.Forms.Label Emaillabel;
        private System.Windows.Forms.TextBox EmailtextBox;
        private System.Windows.Forms.Label Namelabel;
        private System.Windows.Forms.TextBox NametextBox;
        private System.Windows.Forms.Button Cancelbutton;
        private System.Windows.Forms.Button ChangePasswordbutton;
        private System.Windows.Forms.Button LogOutbutton;
        private System.Windows.Forms.Button Editbutton;
    }
}