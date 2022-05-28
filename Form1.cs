using System;
using System.Drawing;
using System.Windows.Forms;
using System.Globalization;
using System.IO;
using System.Collections.Generic;

namespace Speed_Typing_App
{

    public partial class Form1 : Form
    {
        int ticks = 6;
        int ticks1 = 0;
        bool flag = true;
        int misc = 0;
        bool lang=false;
        Form2 form2 = new Form2();
        public Form1()
        {
            InitializeComponent();
        }
        public class Result
        {
            public readonly double wpmRes;

            public readonly DateTime date;

            public Result(double wpm, DateTime date)
            {
                wpmRes = wpm;
                this.date = date;
            }
        }
        
        public class TextToPrint
        {
            public string TextTPrint { get; set; }
            public int SymbCount = 0;
        }
        public class Input
        {
            public string Text;
            public double acc;
            public double wordcount = 0;
            public double time;
            public double Time
            {
                get { return time; }
                set { time = value; }
            }
        }
        TextToPrint textToPrnt = new TextToPrint();
        private void Form1_Load(object sender, EventArgs e)
        {
            ShowText();
            TextPanel.ReadOnly = true;
            textBox1.ReadOnly = true;
            label2.Visible = false;
            label3.Visible=false;
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(Text, new Font("Times new Roman", 46, FontStyle.Regular), 
                Brushes.Black, new PointF(50, 50));

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void label5_Click(object sender, EventArgs e)
        {

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            Input input = new Input();
            ticks--;
            timer1.Interval = 1000;
            if (ticks < 0)
            {
                timer1.Interval = 1;
                label1.Visible = false;
                textBox1.ReadOnly = false;
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = false;
                timer2.Start();

            }
            label1.Text = ticks.ToString();
            ChangeClr1(TextPanel,input);
            CheckOnEnd(input);
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            ticks1++;
            timer2.Interval = 1000;
            label2.Text = ticks1.ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            label4.Visible = true;
            timer1.Start();
            GenerateSent();
            TextPanel.Text = textToPrnt.TextTPrint;
        }
        string text1 = "";
        int length = 0;
        void ChangeClr1(RichTextBox TextPanel, Input input)
        {
            input.Text = textBox1.Text;
            int lng = input.Text.Length;
            string sub=textToPrnt.TextTPrint.Substring(0, lng);
            string text2 = input.Text;
            if (sub == input.Text)
            {
                sub.ToCharArray();
                foreach (char c in sub)
                {
                    if (c == ' ')
                    {
                        input.wordcount++;
                    }
                }
                TextPanel.BackColor = Color.LightGreen;
            }
            else if(sub!= input.Text)
            {
                TextPanel.BackColor = Color.LightCoral;
                
                if (text1 != text2 && length > lng)
                {
                    misc ++;
                }
            }
            text1 = input.Text;
            length = lng;
        }
        void CheckOnEnd(Input input)
        {
            input.Text = textBox1.Text;
            if (input.Text.Length == textToPrnt.TextTPrint.Length 
                && input.Text == textToPrnt.TextTPrint 
                && flag == true)
            {
                flag = false;
                timer1.Stop();
                timer2.Stop();
                input.Time = ticks1;
                Print(input);
            }
        }
        void Print(Input input)
        {
            if (misc > 0)
                misc++;
            double correlem = textToPrnt.TextTPrint.Length - misc;
            input.acc = (correlem / textToPrnt.TextTPrint.Length) * 100.0;
            double wpm = (((input.wordcount + 1)/input.Time)*60);
            CheckOnRecord(wpm);
            MessageBox.Show($"Швидкість,слів в хвилину(WPM):{wpm:f0}\nТочність(accuracy)={input.acc:f1}%");
        }
       
        string[] lines = File.ReadAllLines("records.txt");
        string[] linesToWrite = new string[7];
        public void CheckOnRecord(double wpm)
        {
            List<string> list = new List<string>();
            bool swap = false;
            int number;
            Result result = new Result((double)wpm, DateTime.Now);
            lines.CopyTo(linesToWrite, 0);
            ReadRecordsFile();
            for (int i=0; i< linesToWrite.Length; i++)
            {
                number=0;
                if (!string.IsNullOrEmpty(linesToWrite[i]))
                {
                    string[] words = linesToWrite[i].Split(' ');
                    number = int.Parse(words[0]);
                }
                if (swap)
                {
                    list.Add(linesToWrite[i-1]);
                }
                if (result.wpmRes > number && !swap)
                {
                    swap = true;
                    list.Add($"{(int)result.wpmRes} wpm : {result.date.ToShortDateString()}");
                }
                else if (!swap)
                {
                    list.Add(linesToWrite[i]);
                }
            }
            File.WriteAllLines("records.txt", list);
        }
        public void ReadRecordsFile()
        {
            lines = File.ReadAllLines("records.txt");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        public void PrintRecords()
        {
            string[] recordsLines = File.ReadAllLines("records.txt");
            foreach (string line in recordsLines)
            {
                form2.RecordsBox.Text += line + "\n";
            }
        }
        private void RecordsButton_Click_1(object sender, EventArgs e)
        {
            form2.Show();
            PrintRecords();
        }
        public void ShowText()
        {
           languages.Text = "Обрати мову";
        }
        void GenerateSent()
        {
            string[] readText = File.ReadAllLines("text.txt");
            Random random = new Random();
            int i = random.Next(readText.Length);
            textToPrnt.TextTPrint=readText[i];
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lang = true;
            if (languages.SelectedIndex == 0 && lang)
            {
                System.Threading.Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("uk-UA");
                System.Threading.Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("uk-UA");
                Properties.Settings.Default.Language = "uk-UA";
                Properties.Settings.Default.Save();
                Application.Restart();
                languages.Text = "Українська";
            }
            else if (languages.SelectedIndex == 1)
            {
                System.Threading.Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("en-US");
                System.Threading.Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-US");
                Properties.Settings.Default.Language = "en-US";
                Properties.Settings.Default.Save();
                Application.Restart();
                languages.Text = "English";
            }
            else if (languages.SelectedIndex == 2)
            {
                System.Threading.Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("ja-JP");
                System.Threading.Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("ja-JP");
                Properties.Settings.Default.Language = "ja-JP";
                Properties.Settings.Default.Save();
                Application.Restart();
                languages.Text = "日本";
            }   
        }
        
        private void ReturnToMenu_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            this.Hide();
            form3.Show();
        }
    }
}
    
