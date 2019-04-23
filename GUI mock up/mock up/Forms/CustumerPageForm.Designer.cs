namespace mock_up.Forms
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
            this.Editbutton = new System.Windows.Forms.Button();
            this.Cancelbutton = new System.Windows.Forms.Button();
            this.ChangePasswordbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.UserIDtextBox = new System.Windows.Forms.TextBox();
            this.EmailtextBox = new System.Windows.Forms.TextBox();
            this.Emaillabel = new System.Windows.Forms.Label();
            this.confirmBut = new System.Windows.Forms.Button();
            this.deleteBut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Editbutton
            // 
            this.Editbutton.BackColor = System.Drawing.Color.Lavender;
            this.Editbutton.Location = new System.Drawing.Point(227, 245);
            this.Editbutton.Name = "Editbutton";
            this.Editbutton.Size = new System.Drawing.Size(75, 23);
            this.Editbutton.TabIndex = 81;
            this.Editbutton.Text = "Edit";
            this.Editbutton.UseVisualStyleBackColor = false;
            this.Editbutton.Click += new System.EventHandler(this.Editbutton_Click);
            // 
            // Cancelbutton
            // 
            this.Cancelbutton.BackColor = System.Drawing.Color.DimGray;
            this.Cancelbutton.Location = new System.Drawing.Point(317, 245);
            this.Cancelbutton.Name = "Cancelbutton";
            this.Cancelbutton.Size = new System.Drawing.Size(75, 23);
            this.Cancelbutton.TabIndex = 79;
            this.Cancelbutton.Text = "Cancel";
            this.Cancelbutton.UseVisualStyleBackColor = false;
            this.Cancelbutton.Click += new System.EventHandler(this.Cancelbutton_Click);
            // 
            // ChangePasswordbutton
            // 
            this.ChangePasswordbutton.BackColor = System.Drawing.Color.SpringGreen;
            this.ChangePasswordbutton.Location = new System.Drawing.Point(253, 205);
            this.ChangePasswordbutton.Name = "ChangePasswordbutton";
            this.ChangePasswordbutton.Size = new System.Drawing.Size(101, 23);
            this.ChangePasswordbutton.TabIndex = 78;
            this.ChangePasswordbutton.Text = "Change Password";
            this.ChangePasswordbutton.UseVisualStyleBackColor = false;
            this.ChangePasswordbutton.Click += new System.EventHandler(this.ChangePasswordbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(153, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 76;
            this.label1.Text = "User\'s Profile";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(597, 60);
            this.panel1.TabIndex = 77;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(180, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 75;
            this.label4.Text = "UserID:";
            // 
            // UserIDtextBox
            // 
            this.UserIDtextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.UserIDtextBox.Location = new System.Drawing.Point(227, 125);
            this.UserIDtextBox.Name = "UserIDtextBox";
            this.UserIDtextBox.ReadOnly = true;
            this.UserIDtextBox.Size = new System.Drawing.Size(165, 20);
            this.UserIDtextBox.TabIndex = 74;
            // 
            // EmailtextBox
            // 
            this.EmailtextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.EmailtextBox.Location = new System.Drawing.Point(227, 168);
            this.EmailtextBox.Name = "EmailtextBox";
            this.EmailtextBox.ReadOnly = true;
            this.EmailtextBox.Size = new System.Drawing.Size(165, 20);
            this.EmailtextBox.TabIndex = 72;
            // 
            // Emaillabel
            // 
            this.Emaillabel.AutoSize = true;
            this.Emaillabel.Location = new System.Drawing.Point(187, 168);
            this.Emaillabel.Name = "Emaillabel";
            this.Emaillabel.Size = new System.Drawing.Size(35, 13);
            this.Emaillabel.TabIndex = 73;
            this.Emaillabel.Text = "Email:";
            // 
            // confirmBut
            // 
            this.confirmBut.BackColor = System.Drawing.Color.Lavender;
            this.confirmBut.Location = new System.Drawing.Point(227, 245);
            this.confirmBut.Name = "confirmBut";
            this.confirmBut.Size = new System.Drawing.Size(75, 23);
            this.confirmBut.TabIndex = 82;
            this.confirmBut.Text = "Confirm";
            this.confirmBut.UseVisualStyleBackColor = false;
            this.confirmBut.Visible = false;
            this.confirmBut.Click += new System.EventHandler(this.confirmBut_Click);
            // 
            // deleteBut
            // 
            this.deleteBut.BackColor = System.Drawing.Color.Crimson;
            this.deleteBut.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.deleteBut.Location = new System.Drawing.Point(227, 281);
            this.deleteBut.Margin = new System.Windows.Forms.Padding(2);
            this.deleteBut.Name = "deleteBut";
            this.deleteBut.Size = new System.Drawing.Size(164, 28);
            this.deleteBut.TabIndex = 83;
            this.deleteBut.Text = "Delete Account";
            this.deleteBut.UseVisualStyleBackColor = false;
            this.deleteBut.Click += new System.EventHandler(this.deleteBut_Click);
            // 
            // CustumerPageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(597, 367);
            this.Controls.Add(this.deleteBut);
            this.Controls.Add(this.confirmBut);
            this.Controls.Add(this.Editbutton);
            this.Controls.Add(this.Cancelbutton);
            this.Controls.Add(this.ChangePasswordbutton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.UserIDtextBox);
            this.Controls.Add(this.EmailtextBox);
            this.Controls.Add(this.Emaillabel);
            this.Name = "CustumerPageForm";
            this.Text = "CustumerPageForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Editbutton;
        private System.Windows.Forms.Button Cancelbutton;
        private System.Windows.Forms.Button ChangePasswordbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox UserIDtextBox;
        private System.Windows.Forms.TextBox EmailtextBox;
        private System.Windows.Forms.Label Emaillabel;
        private System.Windows.Forms.Button confirmBut;
        private System.Windows.Forms.Button deleteBut;
    }
}