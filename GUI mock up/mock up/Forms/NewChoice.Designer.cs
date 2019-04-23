namespace mock_up
{
    partial class NewChoice
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
            this.busBut = new System.Windows.Forms.Button();
            this.userBut = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // busBut
            // 
            this.busBut.BackColor = System.Drawing.Color.CornflowerBlue;
            this.busBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.busBut.Location = new System.Drawing.Point(170, 106);
            this.busBut.Margin = new System.Windows.Forms.Padding(2);
            this.busBut.Name = "busBut";
            this.busBut.Size = new System.Drawing.Size(258, 70);
            this.busBut.TabIndex = 0;
            this.busBut.Text = "Business";
            this.busBut.UseVisualStyleBackColor = false;
            this.busBut.Click += new System.EventHandler(this.busBut_Click);
            // 
            // userBut
            // 
            this.userBut.BackColor = System.Drawing.Color.LightSlateGray;
            this.userBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userBut.Location = new System.Drawing.Point(170, 197);
            this.userBut.Margin = new System.Windows.Forms.Padding(2);
            this.userBut.Name = "userBut";
            this.userBut.Size = new System.Drawing.Size(258, 70);
            this.userBut.TabIndex = 1;
            this.userBut.Text = "User";
            this.userBut.UseVisualStyleBackColor = false;
            this.userBut.Click += new System.EventHandler(this.userBut_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Text", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(112, 8);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(370, 69);
            this.label2.TabIndex = 8;
            this.label2.Text = "Quicker Queue";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // NewChoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(597, 367);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.userBut);
            this.Controls.Add(this.busBut);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "NewChoice";
            this.Text = "ShockWave Inc.";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button busBut;
        private System.Windows.Forms.Button userBut;
        private System.Windows.Forms.Label label2;
    }
}

