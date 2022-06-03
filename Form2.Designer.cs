namespace Speed_Typing_App
{
    partial class Form2
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
            this.RecordsBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.WOSRecords = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // RecordsBox
            // 
            this.RecordsBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic);
            this.RecordsBox.Location = new System.Drawing.Point(13, 105);
            this.RecordsBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RecordsBox.Name = "RecordsBox";
            this.RecordsBox.Size = new System.Drawing.Size(333, 278);
            this.RecordsBox.TabIndex = 2;
            this.RecordsBox.Text = "";
            this.RecordsBox.TextChanged += new System.EventHandler(this.RecordsBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(491, 502);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 3;
            // 
            // WOSRecords
            // 
            this.WOSRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WOSRecords.Location = new System.Drawing.Point(372, 105);
            this.WOSRecords.Name = "WOSRecords";
            this.WOSRecords.Size = new System.Drawing.Size(327, 278);
            this.WOSRecords.TabIndex = 4;
            this.WOSRecords.Text = "";
            this.WOSRecords.TextChanged += new System.EventHandler(this.WOSRecords_TextChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(711, 443);
            this.Controls.Add(this.WOSRecords);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RecordsBox);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "рекорди";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.RichTextBox RecordsBox;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.RichTextBox WOSRecords;
    }
}