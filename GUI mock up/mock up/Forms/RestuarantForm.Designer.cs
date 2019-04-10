namespace WindowsFormsApp2
{
    partial class RestuarantForm
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
            this.Notifybutton = new System.Windows.Forms.Button();
            this.Queuelabel = new System.Windows.Forms.Label();
            this.Removebutton = new System.Windows.Forms.Button();
            this.Table1checkBox = new System.Windows.Forms.CheckBox();
            this.Bar1checkBox = new System.Windows.Forms.CheckBox();
            this.Booth1checkBox = new System.Windows.Forms.CheckBox();
            this.Bar2checkBox = new System.Windows.Forms.CheckBox();
            this.Bar3checkBox = new System.Windows.Forms.CheckBox();
            this.Bar4checkBox = new System.Windows.Forms.CheckBox();
            this.Bar5checkBox = new System.Windows.Forms.CheckBox();
            this.Table2checkBox = new System.Windows.Forms.CheckBox();
            this.Table3checkBox = new System.Windows.Forms.CheckBox();
            this.Table4checkBox = new System.Windows.Forms.CheckBox();
            this.Booth2checkBox = new System.Windows.Forms.CheckBox();
            this.Booth3checkBox = new System.Windows.Forms.CheckBox();
            this.Booth4checkBox = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.BiggerTable1checkBox = new System.Windows.Forms.CheckBox();
            this.BiggerTable2checkBox = new System.Windows.Forms.CheckBox();
            this.BiggerTable3checkBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Seatlabel = new System.Windows.Forms.Label();
            this.QueuelistBox = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 60);
            this.panel1.TabIndex = 24;
            // 
            // panel2
            // 
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(72, 37);
            this.panel2.TabIndex = 1;
            // 
            // Notifybutton
            // 
            this.Notifybutton.BackColor = System.Drawing.Color.SpringGreen;
            this.Notifybutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Notifybutton.Location = new System.Drawing.Point(141, 343);
            this.Notifybutton.Name = "Notifybutton";
            this.Notifybutton.Size = new System.Drawing.Size(75, 23);
            this.Notifybutton.TabIndex = 23;
            this.Notifybutton.Text = "Notify";
            this.Notifybutton.UseVisualStyleBackColor = false;
            // 
            // Queuelabel
            // 
            this.Queuelabel.AutoSize = true;
            this.Queuelabel.BackColor = System.Drawing.Color.Silver;
            this.Queuelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Queuelabel.ForeColor = System.Drawing.Color.Black;
            this.Queuelabel.Location = new System.Drawing.Point(46, 93);
            this.Queuelabel.Name = "Queuelabel";
            this.Queuelabel.Size = new System.Drawing.Size(62, 20);
            this.Queuelabel.TabIndex = 18;
            this.Queuelabel.Text = "Queue";
            this.Queuelabel.Click += new System.EventHandler(this.Openlabel_Click);
            // 
            // Removebutton
            // 
            this.Removebutton.BackColor = System.Drawing.Color.IndianRed;
            this.Removebutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Removebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Removebutton.Location = new System.Drawing.Point(50, 343);
            this.Removebutton.Name = "Removebutton";
            this.Removebutton.Size = new System.Drawing.Size(75, 23);
            this.Removebutton.TabIndex = 15;
            this.Removebutton.Text = "Remove";
            this.Removebutton.UseVisualStyleBackColor = false;
            // 
            // Table1checkBox
            // 
            this.Table1checkBox.AutoSize = true;
            this.Table1checkBox.BackColor = System.Drawing.Color.CadetBlue;
            this.Table1checkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Table1checkBox.Location = new System.Drawing.Point(359, 178);
            this.Table1checkBox.Name = "Table1checkBox";
            this.Table1checkBox.Size = new System.Drawing.Size(80, 24);
            this.Table1checkBox.TabIndex = 25;
            this.Table1checkBox.Text = "Table 1";
            this.Table1checkBox.UseVisualStyleBackColor = false;
            // 
            // Bar1checkBox
            // 
            this.Bar1checkBox.AutoSize = true;
            this.Bar1checkBox.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.Bar1checkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bar1checkBox.Location = new System.Drawing.Point(359, 134);
            this.Bar1checkBox.Name = "Bar1checkBox";
            this.Bar1checkBox.Size = new System.Drawing.Size(66, 24);
            this.Bar1checkBox.TabIndex = 26;
            this.Bar1checkBox.Text = "Bar 1";
            this.Bar1checkBox.UseVisualStyleBackColor = false;
            // 
            // Booth1checkBox
            // 
            this.Booth1checkBox.AutoSize = true;
            this.Booth1checkBox.BackColor = System.Drawing.Color.PaleVioletRed;
            this.Booth1checkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Booth1checkBox.Location = new System.Drawing.Point(666, 178);
            this.Booth1checkBox.Name = "Booth1checkBox";
            this.Booth1checkBox.Size = new System.Drawing.Size(84, 24);
            this.Booth1checkBox.TabIndex = 27;
            this.Booth1checkBox.Text = "Booth 1";
            this.Booth1checkBox.UseVisualStyleBackColor = false;
            // 
            // Bar2checkBox
            // 
            this.Bar2checkBox.AutoSize = true;
            this.Bar2checkBox.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.Bar2checkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bar2checkBox.Location = new System.Drawing.Point(440, 134);
            this.Bar2checkBox.Name = "Bar2checkBox";
            this.Bar2checkBox.Size = new System.Drawing.Size(66, 24);
            this.Bar2checkBox.TabIndex = 28;
            this.Bar2checkBox.Text = "Bar 2";
            this.Bar2checkBox.UseVisualStyleBackColor = false;
            // 
            // Bar3checkBox
            // 
            this.Bar3checkBox.AutoSize = true;
            this.Bar3checkBox.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.Bar3checkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bar3checkBox.Location = new System.Drawing.Point(521, 134);
            this.Bar3checkBox.Name = "Bar3checkBox";
            this.Bar3checkBox.Size = new System.Drawing.Size(66, 24);
            this.Bar3checkBox.TabIndex = 29;
            this.Bar3checkBox.Text = "Bar 3";
            this.Bar3checkBox.UseVisualStyleBackColor = false;
            // 
            // Bar4checkBox
            // 
            this.Bar4checkBox.AutoSize = true;
            this.Bar4checkBox.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.Bar4checkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bar4checkBox.Location = new System.Drawing.Point(603, 134);
            this.Bar4checkBox.Name = "Bar4checkBox";
            this.Bar4checkBox.Size = new System.Drawing.Size(66, 24);
            this.Bar4checkBox.TabIndex = 30;
            this.Bar4checkBox.Text = "Bar 4";
            this.Bar4checkBox.UseVisualStyleBackColor = false;
            // 
            // Bar5checkBox
            // 
            this.Bar5checkBox.AutoSize = true;
            this.Bar5checkBox.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.Bar5checkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bar5checkBox.Location = new System.Drawing.Point(684, 134);
            this.Bar5checkBox.Name = "Bar5checkBox";
            this.Bar5checkBox.Size = new System.Drawing.Size(66, 24);
            this.Bar5checkBox.TabIndex = 31;
            this.Bar5checkBox.Text = "Bar 5";
            this.Bar5checkBox.UseVisualStyleBackColor = false;
            // 
            // Table2checkBox
            // 
            this.Table2checkBox.AutoSize = true;
            this.Table2checkBox.BackColor = System.Drawing.Color.CadetBlue;
            this.Table2checkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Table2checkBox.Location = new System.Drawing.Point(359, 220);
            this.Table2checkBox.Name = "Table2checkBox";
            this.Table2checkBox.Size = new System.Drawing.Size(80, 24);
            this.Table2checkBox.TabIndex = 32;
            this.Table2checkBox.Text = "Table 2";
            this.Table2checkBox.UseVisualStyleBackColor = false;
            // 
            // Table3checkBox
            // 
            this.Table3checkBox.AutoSize = true;
            this.Table3checkBox.BackColor = System.Drawing.Color.CadetBlue;
            this.Table3checkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Table3checkBox.Location = new System.Drawing.Point(359, 262);
            this.Table3checkBox.Name = "Table3checkBox";
            this.Table3checkBox.Size = new System.Drawing.Size(80, 24);
            this.Table3checkBox.TabIndex = 33;
            this.Table3checkBox.Text = "Table 3";
            this.Table3checkBox.UseVisualStyleBackColor = false;
            // 
            // Table4checkBox
            // 
            this.Table4checkBox.AutoSize = true;
            this.Table4checkBox.BackColor = System.Drawing.Color.CadetBlue;
            this.Table4checkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Table4checkBox.Location = new System.Drawing.Point(359, 304);
            this.Table4checkBox.Name = "Table4checkBox";
            this.Table4checkBox.Size = new System.Drawing.Size(80, 24);
            this.Table4checkBox.TabIndex = 34;
            this.Table4checkBox.Text = "Table 4";
            this.Table4checkBox.UseVisualStyleBackColor = false;
            // 
            // Booth2checkBox
            // 
            this.Booth2checkBox.AutoSize = true;
            this.Booth2checkBox.BackColor = System.Drawing.Color.PaleVioletRed;
            this.Booth2checkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Booth2checkBox.Location = new System.Drawing.Point(666, 220);
            this.Booth2checkBox.Name = "Booth2checkBox";
            this.Booth2checkBox.Size = new System.Drawing.Size(84, 24);
            this.Booth2checkBox.TabIndex = 35;
            this.Booth2checkBox.Text = "Booth 2";
            this.Booth2checkBox.UseVisualStyleBackColor = false;
            // 
            // Booth3checkBox
            // 
            this.Booth3checkBox.AutoSize = true;
            this.Booth3checkBox.BackColor = System.Drawing.Color.PaleVioletRed;
            this.Booth3checkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Booth3checkBox.Location = new System.Drawing.Point(666, 262);
            this.Booth3checkBox.Name = "Booth3checkBox";
            this.Booth3checkBox.Size = new System.Drawing.Size(84, 24);
            this.Booth3checkBox.TabIndex = 36;
            this.Booth3checkBox.Text = "Booth 3";
            this.Booth3checkBox.UseVisualStyleBackColor = false;
            // 
            // Booth4checkBox
            // 
            this.Booth4checkBox.AutoSize = true;
            this.Booth4checkBox.BackColor = System.Drawing.Color.PaleVioletRed;
            this.Booth4checkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Booth4checkBox.Location = new System.Drawing.Point(666, 304);
            this.Booth4checkBox.Name = "Booth4checkBox";
            this.Booth4checkBox.Size = new System.Drawing.Size(84, 24);
            this.Booth4checkBox.TabIndex = 37;
            this.Booth4checkBox.Text = "Booth 4";
            this.Booth4checkBox.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkOrange;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(233, 343);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 38;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // BiggerTable1checkBox
            // 
            this.BiggerTable1checkBox.AutoSize = true;
            this.BiggerTable1checkBox.BackColor = System.Drawing.Color.CadetBlue;
            this.BiggerTable1checkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BiggerTable1checkBox.Location = new System.Drawing.Point(486, 196);
            this.BiggerTable1checkBox.Name = "BiggerTable1checkBox";
            this.BiggerTable1checkBox.Size = new System.Drawing.Size(130, 24);
            this.BiggerTable1checkBox.TabIndex = 39;
            this.BiggerTable1checkBox.Text = "Bigger Table 1";
            this.BiggerTable1checkBox.UseVisualStyleBackColor = false;
            // 
            // BiggerTable2checkBox
            // 
            this.BiggerTable2checkBox.AutoSize = true;
            this.BiggerTable2checkBox.BackColor = System.Drawing.Color.CadetBlue;
            this.BiggerTable2checkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BiggerTable2checkBox.Location = new System.Drawing.Point(486, 243);
            this.BiggerTable2checkBox.Name = "BiggerTable2checkBox";
            this.BiggerTable2checkBox.Size = new System.Drawing.Size(130, 24);
            this.BiggerTable2checkBox.TabIndex = 40;
            this.BiggerTable2checkBox.Text = "Bigger Table 2";
            this.BiggerTable2checkBox.UseVisualStyleBackColor = false;
            // 
            // BiggerTable3checkBox
            // 
            this.BiggerTable3checkBox.AutoSize = true;
            this.BiggerTable3checkBox.BackColor = System.Drawing.Color.CadetBlue;
            this.BiggerTable3checkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BiggerTable3checkBox.Location = new System.Drawing.Point(486, 286);
            this.BiggerTable3checkBox.Name = "BiggerTable3checkBox";
            this.BiggerTable3checkBox.Size = new System.Drawing.Size(130, 24);
            this.BiggerTable3checkBox.TabIndex = 41;
            this.BiggerTable3checkBox.Text = "Bigger Table 3";
            this.BiggerTable3checkBox.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(359, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 36);
            this.label1.TabIndex = 2;
            this.label1.Text = "Restuarant";
            // 
            // Seatlabel
            // 
            this.Seatlabel.AutoSize = true;
            this.Seatlabel.BackColor = System.Drawing.Color.Silver;
            this.Seatlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Seatlabel.ForeColor = System.Drawing.Color.Black;
            this.Seatlabel.Location = new System.Drawing.Point(355, 93);
            this.Seatlabel.Name = "Seatlabel";
            this.Seatlabel.Size = new System.Drawing.Size(99, 20);
            this.Seatlabel.TabIndex = 42;
            this.Seatlabel.Text = "Seat Types";
            // 
            // QueuelistBox
            // 
            this.QueuelistBox.FormattingEnabled = true;
            this.QueuelistBox.Location = new System.Drawing.Point(50, 125);
            this.QueuelistBox.Name = "QueuelistBox";
            this.QueuelistBox.Size = new System.Drawing.Size(258, 212);
            this.QueuelistBox.TabIndex = 71;
            // 
            // RestuarantForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.QueuelistBox);
            this.Controls.Add(this.Seatlabel);
            this.Controls.Add(this.BiggerTable3checkBox);
            this.Controls.Add(this.BiggerTable2checkBox);
            this.Controls.Add(this.BiggerTable1checkBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Booth4checkBox);
            this.Controls.Add(this.Booth3checkBox);
            this.Controls.Add(this.Booth2checkBox);
            this.Controls.Add(this.Table4checkBox);
            this.Controls.Add(this.Table3checkBox);
            this.Controls.Add(this.Table2checkBox);
            this.Controls.Add(this.Bar5checkBox);
            this.Controls.Add(this.Bar4checkBox);
            this.Controls.Add(this.Bar3checkBox);
            this.Controls.Add(this.Bar2checkBox);
            this.Controls.Add(this.Booth1checkBox);
            this.Controls.Add(this.Bar1checkBox);
            this.Controls.Add(this.Table1checkBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Notifybutton);
            this.Controls.Add(this.Queuelabel);
            this.Controls.Add(this.Removebutton);
            this.Name = "RestuarantForm";
            this.Text = "RestuarantForm";
            this.Load += new System.EventHandler(this.RestuarantForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Notifybutton;
        private System.Windows.Forms.Label Queuelabel;
        private System.Windows.Forms.Button Removebutton;
        private System.Windows.Forms.CheckBox Table1checkBox;
        private System.Windows.Forms.CheckBox Bar1checkBox;
        private System.Windows.Forms.CheckBox Booth1checkBox;
        private System.Windows.Forms.CheckBox Bar2checkBox;
        private System.Windows.Forms.CheckBox Bar3checkBox;
        private System.Windows.Forms.CheckBox Bar4checkBox;
        private System.Windows.Forms.CheckBox Bar5checkBox;
        private System.Windows.Forms.CheckBox Table2checkBox;
        private System.Windows.Forms.CheckBox Table3checkBox;
        private System.Windows.Forms.CheckBox Table4checkBox;
        private System.Windows.Forms.CheckBox Booth2checkBox;
        private System.Windows.Forms.CheckBox Booth3checkBox;
        private System.Windows.Forms.CheckBox Booth4checkBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox BiggerTable1checkBox;
        private System.Windows.Forms.CheckBox BiggerTable2checkBox;
        private System.Windows.Forms.CheckBox BiggerTable3checkBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Seatlabel;
        private System.Windows.Forms.ListBox QueuelistBox;
    }
}