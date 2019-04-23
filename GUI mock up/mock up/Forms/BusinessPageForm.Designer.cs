namespace mock_up.Forms
{
    partial class BusinessPageForm
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
            this.deleteBut = new System.Windows.Forms.Button();
            this.confirmBut = new System.Windows.Forms.Button();
            this.Editbutton = new System.Windows.Forms.Button();
            this.Cancelbutton = new System.Windows.Forms.Button();
            this.ChangePasswordbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.UserIDtextBox = new System.Windows.Forms.TextBox();
            this.EmailtextBox = new System.Windows.Forms.TextBox();
            this.Emaillabel = new System.Windows.Forms.Label();
            this.closeTextBox = new System.Windows.Forms.TextBox();
            this.openTextBox = new System.Windows.Forms.TextBox();
            this.openLabel = new System.Windows.Forms.Label();
            this.closeLabel = new System.Windows.Forms.Label();
            this.typeLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.typeCombo = new System.Windows.Forms.ComboBox();
            this.closeCombo = new System.Windows.Forms.ComboBox();
            this.openCombo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // deleteBut
            // 
            this.deleteBut.BackColor = System.Drawing.Color.Crimson;
            this.deleteBut.Location = new System.Drawing.Point(86, 273);
            this.deleteBut.Margin = new System.Windows.Forms.Padding(2);
            this.deleteBut.Name = "deleteBut";
            this.deleteBut.Size = new System.Drawing.Size(164, 28);
            this.deleteBut.TabIndex = 94;
            this.deleteBut.Text = "Delete Account";
            this.deleteBut.UseVisualStyleBackColor = false;
            this.deleteBut.Click += new System.EventHandler(this.deleteBut_Click);
            // 
            // confirmBut
            // 
            this.confirmBut.BackColor = System.Drawing.Color.Lavender;
            this.confirmBut.Location = new System.Drawing.Point(86, 245);
            this.confirmBut.Name = "confirmBut";
            this.confirmBut.Size = new System.Drawing.Size(75, 23);
            this.confirmBut.TabIndex = 93;
            this.confirmBut.Text = "Confirm";
            this.confirmBut.UseVisualStyleBackColor = false;
            this.confirmBut.Visible = false;
            this.confirmBut.Click += new System.EventHandler(this.confirmBut_Click);
            // 
            // Editbutton
            // 
            this.Editbutton.BackColor = System.Drawing.Color.Lavender;
            this.Editbutton.Location = new System.Drawing.Point(86, 245);
            this.Editbutton.Name = "Editbutton";
            this.Editbutton.Size = new System.Drawing.Size(75, 23);
            this.Editbutton.TabIndex = 92;
            this.Editbutton.Text = "Edit";
            this.Editbutton.UseVisualStyleBackColor = false;
            this.Editbutton.Click += new System.EventHandler(this.Editbutton_Click);
            // 
            // Cancelbutton
            // 
            this.Cancelbutton.BackColor = System.Drawing.Color.DimGray;
            this.Cancelbutton.Location = new System.Drawing.Point(176, 245);
            this.Cancelbutton.Name = "Cancelbutton";
            this.Cancelbutton.Size = new System.Drawing.Size(75, 23);
            this.Cancelbutton.TabIndex = 91;
            this.Cancelbutton.Text = "Cancel";
            this.Cancelbutton.UseVisualStyleBackColor = false;
            this.Cancelbutton.Click += new System.EventHandler(this.Cancelbutton_Click);
            // 
            // ChangePasswordbutton
            // 
            this.ChangePasswordbutton.BackColor = System.Drawing.Color.SpringGreen;
            this.ChangePasswordbutton.Location = new System.Drawing.Point(112, 205);
            this.ChangePasswordbutton.Name = "ChangePasswordbutton";
            this.ChangePasswordbutton.Size = new System.Drawing.Size(112, 23);
            this.ChangePasswordbutton.TabIndex = 90;
            this.ChangePasswordbutton.Text = "Change Passwords";
            this.ChangePasswordbutton.UseVisualStyleBackColor = false;
            this.ChangePasswordbutton.Click += new System.EventHandler(this.ChangePasswordbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(10, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 88;
            this.label1.Text = "User\'s Profile";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(285, 60);
            this.panel1.TabIndex = 89;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 87;
            this.label4.Text = "UserID:";
            // 
            // UserIDtextBox
            // 
            this.UserIDtextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.UserIDtextBox.Location = new System.Drawing.Point(80, 82);
            this.UserIDtextBox.Name = "UserIDtextBox";
            this.UserIDtextBox.ReadOnly = true;
            this.UserIDtextBox.Size = new System.Drawing.Size(165, 20);
            this.UserIDtextBox.TabIndex = 86;
            // 
            // EmailtextBox
            // 
            this.EmailtextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.EmailtextBox.Location = new System.Drawing.Point(80, 108);
            this.EmailtextBox.Name = "EmailtextBox";
            this.EmailtextBox.ReadOnly = true;
            this.EmailtextBox.Size = new System.Drawing.Size(165, 20);
            this.EmailtextBox.TabIndex = 84;
            // 
            // Emaillabel
            // 
            this.Emaillabel.AutoSize = true;
            this.Emaillabel.Location = new System.Drawing.Point(39, 108);
            this.Emaillabel.Name = "Emaillabel";
            this.Emaillabel.Size = new System.Drawing.Size(35, 13);
            this.Emaillabel.TabIndex = 85;
            this.Emaillabel.Text = "Email:";
            // 
            // closeTextBox
            // 
            this.closeTextBox.Location = new System.Drawing.Point(191, 132);
            this.closeTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.closeTextBox.Name = "closeTextBox";
            this.closeTextBox.ReadOnly = true;
            this.closeTextBox.Size = new System.Drawing.Size(33, 20);
            this.closeTextBox.TabIndex = 95;
            // 
            // openTextBox
            // 
            this.openTextBox.Location = new System.Drawing.Point(80, 132);
            this.openTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.openTextBox.Name = "openTextBox";
            this.openTextBox.ReadOnly = true;
            this.openTextBox.Size = new System.Drawing.Size(31, 20);
            this.openTextBox.TabIndex = 96;
            // 
            // openLabel
            // 
            this.openLabel.AutoSize = true;
            this.openLabel.Location = new System.Drawing.Point(40, 132);
            this.openLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.openLabel.Name = "openLabel";
            this.openLabel.Size = new System.Drawing.Size(36, 13);
            this.openLabel.TabIndex = 97;
            this.openLabel.Text = "Open:";
            // 
            // closeLabel
            // 
            this.closeLabel.AutoSize = true;
            this.closeLabel.Location = new System.Drawing.Point(152, 132);
            this.closeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.closeLabel.Name = "closeLabel";
            this.closeLabel.Size = new System.Drawing.Size(36, 13);
            this.closeLabel.TabIndex = 98;
            this.closeLabel.Text = "Close:";
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Location = new System.Drawing.Point(42, 154);
            this.typeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(34, 13);
            this.typeLabel.TabIndex = 99;
            this.typeLabel.Text = "Type:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(78, 179);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.ReadOnly = true;
            this.nameTextBox.Size = new System.Drawing.Size(167, 20);
            this.nameTextBox.TabIndex = 100;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(37, 179);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(38, 13);
            this.nameLabel.TabIndex = 101;
            this.nameLabel.Text = "Name:";
            // 
            // typeCombo
            // 
            this.typeCombo.FormattingEnabled = true;
            this.typeCombo.Items.AddRange(new object[] {
            "Restraunt"});
            this.typeCombo.Location = new System.Drawing.Point(78, 154);
            this.typeCombo.Margin = new System.Windows.Forms.Padding(2);
            this.typeCombo.Name = "typeCombo";
            this.typeCombo.Size = new System.Drawing.Size(167, 21);
            this.typeCombo.TabIndex = 102;
            // 
            // closeCombo
            // 
            this.closeCombo.FormattingEnabled = true;
            this.closeCombo.Items.AddRange(new object[] {
            "am",
            "pm"});
            this.closeCombo.Location = new System.Drawing.Point(228, 132);
            this.closeCombo.Margin = new System.Windows.Forms.Padding(2);
            this.closeCombo.Name = "closeCombo";
            this.closeCombo.Size = new System.Drawing.Size(37, 21);
            this.closeCombo.TabIndex = 103;
            // 
            // openCombo
            // 
            this.openCombo.FormattingEnabled = true;
            this.openCombo.Items.AddRange(new object[] {
            "am",
            "pm"});
            this.openCombo.Location = new System.Drawing.Point(115, 132);
            this.openCombo.Margin = new System.Windows.Forms.Padding(2);
            this.openCombo.Name = "openCombo";
            this.openCombo.Size = new System.Drawing.Size(33, 21);
            this.openCombo.TabIndex = 104;
            // 
            // BusinessPageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(285, 306);
            this.Controls.Add(this.openCombo);
            this.Controls.Add(this.closeCombo);
            this.Controls.Add(this.typeCombo);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.typeLabel);
            this.Controls.Add(this.closeLabel);
            this.Controls.Add(this.openLabel);
            this.Controls.Add(this.openTextBox);
            this.Controls.Add(this.closeTextBox);
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
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "BusinessPageForm";
            this.Text = "BusinessPageForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button deleteBut;
        private System.Windows.Forms.Button confirmBut;
        private System.Windows.Forms.Button Editbutton;
        private System.Windows.Forms.Button Cancelbutton;
        private System.Windows.Forms.Button ChangePasswordbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox UserIDtextBox;
        private System.Windows.Forms.TextBox EmailtextBox;
        private System.Windows.Forms.Label Emaillabel;
        private System.Windows.Forms.TextBox closeTextBox;
        private System.Windows.Forms.TextBox openTextBox;
        private System.Windows.Forms.Label openLabel;
        private System.Windows.Forms.Label closeLabel;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.ComboBox typeCombo;
        private System.Windows.Forms.ComboBox closeCombo;
        private System.Windows.Forms.ComboBox openCombo;
    }
}