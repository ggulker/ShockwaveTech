namespace mock_up.Forms
{
    partial class Finalize
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
            this.QueueBut = new System.Windows.Forms.Button();
            this.CloseBut = new System.Windows.Forms.Button();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timeTextBox = new System.Windows.Forms.TextBox();
            this.timeCombo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // QueueBut
            // 
            this.QueueBut.BackColor = System.Drawing.Color.Lime;
            this.QueueBut.Location = new System.Drawing.Point(85, 79);
            this.QueueBut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.QueueBut.Name = "QueueBut";
            this.QueueBut.Size = new System.Drawing.Size(107, 36);
            this.QueueBut.TabIndex = 0;
            this.QueueBut.Text = "Queue";
            this.QueueBut.UseVisualStyleBackColor = false;
            this.QueueBut.Click += new System.EventHandler(this.QueueBut_Click);
            // 
            // CloseBut
            // 
            this.CloseBut.Location = new System.Drawing.Point(85, 119);
            this.CloseBut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CloseBut.Name = "CloseBut";
            this.CloseBut.Size = new System.Drawing.Size(107, 36);
            this.CloseBut.TabIndex = 1;
            this.CloseBut.Text = "Close";
            this.CloseBut.UseVisualStyleBackColor = true;
            this.CloseBut.Click += new System.EventHandler(this.CloseBut_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(85, 21);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(186, 22);
            this.nameTextBox.TabIndex = 2;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(30, 21);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(49, 17);
            this.nameLabel.TabIndex = 4;
            this.nameLabel.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Time:";
            // 
            // timeTextBox
            // 
            this.timeTextBox.Location = new System.Drawing.Point(85, 52);
            this.timeTextBox.Name = "timeTextBox";
            this.timeTextBox.Size = new System.Drawing.Size(121, 22);
            this.timeTextBox.TabIndex = 6;
            // 
            // timeCombo
            // 
            this.timeCombo.FormattingEnabled = true;
            this.timeCombo.Items.AddRange(new object[] {
            "AM",
            "PM"});
            this.timeCombo.Location = new System.Drawing.Point(213, 52);
            this.timeCombo.Name = "timeCombo";
            this.timeCombo.Size = new System.Drawing.Size(58, 24);
            this.timeCombo.TabIndex = 7;
            this.timeCombo.Text = "AM";
            // 
            // Finalize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(283, 164);
            this.Controls.Add(this.timeCombo);
            this.Controls.Add(this.timeTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.CloseBut);
            this.Controls.Add(this.QueueBut);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Finalize";
            this.Text = "Queue";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button QueueBut;
        private System.Windows.Forms.Button CloseBut;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox timeTextBox;
        private System.Windows.Forms.ComboBox timeCombo;
    }
}