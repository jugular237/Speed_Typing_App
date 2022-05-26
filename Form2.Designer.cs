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
            this.Exit = new System.Windows.Forms.Button();
            this.RecordsBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(148, 338);
            this.Exit.Margin = new System.Windows.Forms.Padding(4);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(293, 134);
            this.Exit.TabIndex = 1;
            this.Exit.Text = "button1";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // RecordsBox
            // 
            this.RecordsBox.Location = new System.Drawing.Point(148, 124);
            this.RecordsBox.Margin = new System.Windows.Forms.Padding(4);
            this.RecordsBox.Name = "RecordsBox";
            this.RecordsBox.Size = new System.Drawing.Size(292, 186);
            this.RecordsBox.TabIndex = 2;
            this.RecordsBox.Text = "";
            this.RecordsBox.TextChanged += new System.EventHandler(this.RecordsBox_TextChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(609, 554);
            this.Controls.Add(this.RecordsBox);
            this.Controls.Add(this.Exit);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "рекорди";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Exit;
        public System.Windows.Forms.RichTextBox RecordsBox;
    }
}