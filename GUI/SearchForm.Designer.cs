namespace WindowsFormsApp2
{
    partial class SearchForm
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
            this.FiltercomboBox = new System.Windows.Forms.ComboBox();
            this.SearchtextBox = new System.Windows.Forms.TextBox();
            this.Searchbutton = new System.Windows.Forms.Button();
            this.ResulttextBox = new System.Windows.Forms.TextBox();
            this.OpentextBox = new System.Windows.Forms.TextBox();
            this.Openlabel = new System.Windows.Forms.Label();
            this.OpencomboBox = new System.Windows.Forms.ComboBox();
            this.ClosecomboBox = new System.Windows.Forms.ComboBox();
            this.Closelabel = new System.Windows.Forms.Label();
            this.ClosetextBox = new System.Windows.Forms.TextBox();
            this.Queuebutton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // FiltercomboBox
            // 
            this.FiltercomboBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.FiltercomboBox.FormattingEnabled = true;
            this.FiltercomboBox.Location = new System.Drawing.Point(297, 73);
            this.FiltercomboBox.Name = "FiltercomboBox";
            this.FiltercomboBox.Size = new System.Drawing.Size(88, 21);
            this.FiltercomboBox.TabIndex = 0;
            this.FiltercomboBox.Text = "Filter";
            // 
            // SearchtextBox
            // 
            this.SearchtextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.SearchtextBox.ForeColor = System.Drawing.Color.Black;
            this.SearchtextBox.Location = new System.Drawing.Point(78, 73);
            this.SearchtextBox.Name = "SearchtextBox";
            this.SearchtextBox.Size = new System.Drawing.Size(213, 20);
            this.SearchtextBox.TabIndex = 1;
            this.SearchtextBox.Text = "Search";
            // 
            // Searchbutton
            // 
            this.Searchbutton.BackColor = System.Drawing.Color.RoyalBlue;
            this.Searchbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Searchbutton.Location = new System.Drawing.Point(391, 73);
            this.Searchbutton.Name = "Searchbutton";
            this.Searchbutton.Size = new System.Drawing.Size(75, 23);
            this.Searchbutton.TabIndex = 3;
            this.Searchbutton.Text = "Search";
            this.Searchbutton.UseVisualStyleBackColor = false;
            // 
            // ResulttextBox
            // 
            this.ResulttextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ResulttextBox.Location = new System.Drawing.Point(79, 131);
            this.ResulttextBox.Multiline = true;
            this.ResulttextBox.Name = "ResulttextBox";
            this.ResulttextBox.Size = new System.Drawing.Size(386, 214);
            this.ResulttextBox.TabIndex = 4;
            this.ResulttextBox.Text = "Results..";
            this.ResulttextBox.TextChanged += new System.EventHandler(this.ResulttextBox_TextChanged);
            // 
            // OpentextBox
            // 
            this.OpentextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.OpentextBox.Location = new System.Drawing.Point(118, 99);
            this.OpentextBox.Name = "OpentextBox";
            this.OpentextBox.Size = new System.Drawing.Size(48, 20);
            this.OpentextBox.TabIndex = 5;
            // 
            // Openlabel
            // 
            this.Openlabel.AutoSize = true;
            this.Openlabel.Location = new System.Drawing.Point(76, 102);
            this.Openlabel.Name = "Openlabel";
            this.Openlabel.Size = new System.Drawing.Size(36, 13);
            this.Openlabel.TabIndex = 6;
            this.Openlabel.Text = "Open:";
            // 
            // OpencomboBox
            // 
            this.OpencomboBox.BackColor = System.Drawing.SystemColors.Control;
            this.OpencomboBox.FormattingEnabled = true;
            this.OpencomboBox.Location = new System.Drawing.Point(172, 98);
            this.OpencomboBox.Name = "OpencomboBox";
            this.OpencomboBox.Size = new System.Drawing.Size(40, 21);
            this.OpencomboBox.TabIndex = 7;
            this.OpencomboBox.Text = "am";
            this.OpencomboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // ClosecomboBox
            // 
            this.ClosecomboBox.BackColor = System.Drawing.SystemColors.Control;
            this.ClosecomboBox.FormattingEnabled = true;
            this.ClosecomboBox.Location = new System.Drawing.Point(328, 98);
            this.ClosecomboBox.Name = "ClosecomboBox";
            this.ClosecomboBox.Size = new System.Drawing.Size(40, 21);
            this.ClosecomboBox.TabIndex = 10;
            this.ClosecomboBox.Text = "pm";
            // 
            // Closelabel
            // 
            this.Closelabel.AutoSize = true;
            this.Closelabel.Location = new System.Drawing.Point(232, 102);
            this.Closelabel.Name = "Closelabel";
            this.Closelabel.Size = new System.Drawing.Size(36, 13);
            this.Closelabel.TabIndex = 9;
            this.Closelabel.Text = "Close:";
            // 
            // ClosetextBox
            // 
            this.ClosetextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClosetextBox.Location = new System.Drawing.Point(274, 99);
            this.ClosetextBox.Name = "ClosetextBox";
            this.ClosetextBox.Size = new System.Drawing.Size(48, 20);
            this.ClosetextBox.TabIndex = 8;
            // 
            // Queuebutton
            // 
            this.Queuebutton.BackColor = System.Drawing.Color.SpringGreen;
            this.Queuebutton.Location = new System.Drawing.Point(391, 102);
            this.Queuebutton.Name = "Queuebutton";
            this.Queuebutton.Size = new System.Drawing.Size(75, 23);
            this.Queuebutton.TabIndex = 11;
            this.Queuebutton.Text = "Queue";
            this.Queuebutton.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(545, 60);
            this.panel1.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.SWicon30x30;
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(72, 37);
            this.panel2.TabIndex = 1;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(545, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Queuebutton);
            this.Controls.Add(this.ClosecomboBox);
            this.Controls.Add(this.Closelabel);
            this.Controls.Add(this.ClosetextBox);
            this.Controls.Add(this.OpencomboBox);
            this.Controls.Add(this.Openlabel);
            this.Controls.Add(this.OpentextBox);
            this.Controls.Add(this.ResulttextBox);
            this.Controls.Add(this.Searchbutton);
            this.Controls.Add(this.SearchtextBox);
            this.Controls.Add(this.FiltercomboBox);
            this.Name = "Form2";
            this.Text = "Search";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox FiltercomboBox;
        private System.Windows.Forms.TextBox SearchtextBox;
        private System.Windows.Forms.Button Searchbutton;
        private System.Windows.Forms.TextBox ResulttextBox;
        private System.Windows.Forms.TextBox OpentextBox;
        private System.Windows.Forms.Label Openlabel;
        private System.Windows.Forms.ComboBox OpencomboBox;
        private System.Windows.Forms.ComboBox ClosecomboBox;
        private System.Windows.Forms.Label Closelabel;
        private System.Windows.Forms.TextBox ClosetextBox;
        private System.Windows.Forms.Button Queuebutton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}