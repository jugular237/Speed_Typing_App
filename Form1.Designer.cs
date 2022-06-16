
namespace Speed_Typing_App
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.TextPanel = new System.Windows.Forms.RichTextBox();
            this.timerToStart = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelTimerToWrite = new System.Windows.Forms.Label();
            this.timerToWrite = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.labelTimerToStart = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.languages = new System.Windows.Forms.ComboBox();
            this.ReturnToMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // textBox1
            // 
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.Name = "textBox1";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // printPreviewDialog1
            // 
            resources.ApplyResources(this.printPreviewDialog1, "printPreviewDialog1");
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            // 
            // TextPanel
            // 
            resources.ApplyResources(this.TextPanel, "TextPanel");
            this.TextPanel.Name = "TextPanel";
            this.TextPanel.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // timer1
            // 
            this.timerToStart.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.labelTimerToWrite, "label2");
            this.labelTimerToWrite.Name = "label2";
            this.labelTimerToWrite.Click += new System.EventHandler(this.label2_Click);
            // 
            // timer2
            // 
            this.timerToWrite.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.labelTimerToStart, "label4");
            this.labelTimerToStart.Name = "label4";
            // 
            // button2
            // 
            resources.ApplyResources(this.button2, "button2");
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // languages
            // 
            resources.ApplyResources(this.languages, "languages");
            this.languages.BackColor = System.Drawing.Color.White;
            this.languages.FormattingEnabled = true;
            this.languages.Items.AddRange(new object[] {
            resources.GetString("languages.Items"),
            resources.GetString("languages.Items1"),
            resources.GetString("languages.Items2")});
            this.languages.Name = "languages";
            this.languages.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // ReturnToMenu
            // 
            resources.ApplyResources(this.ReturnToMenu, "ReturnToMenu");
            this.ReturnToMenu.Name = "ReturnToMenu";
            this.ReturnToMenu.UseVisualStyleBackColor = true;
            this.ReturnToMenu.Click += new System.EventHandler(this.ReturnToMenu_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.ReturnToMenu);
            this.Controls.Add(this.languages);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.labelTimerToStart);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelTimerToWrite);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TextPanel);
            this.Controls.Add(this.textBox1);
            this.HelpButton = true;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.RichTextBox TextPanel;
        private System.Windows.Forms.Timer timerToStart;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelTimerToWrite;
        private System.Windows.Forms.Timer timerToWrite;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelTimerToStart;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox languages;
        private System.Windows.Forms.Button ReturnToMenu;
    }
}

