using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Windows.Forms;

namespace Speed_Typing_App
{
    public partial class Form4 : Form
    {
        PlayersInput input = new PlayersInput();
        TextToPrint textToPrnt = new TextToPrint();

        const int recordsLength = 10;
        string[] lines = File.ReadAllLines("WOSrecords.txt");
        string[] linesToWrite = new string[recordsLength];

        int ticksTimerToStart = 6;
        int ticksTimerToEnd = 20;
       
        string text1 = "";
        int length = 0;
        int mistakes = 0;
        
        bool fl = true, fl1 = true;
        
        public Form4()
        {
            InitializeComponent();
        }
        
        
        
        void GenerateSent()
        {
            string[] readText = File.ReadAllLines("words.txt");
            Random random = new Random();
            int i = random.Next(readText.Length);
            textToPrnt.TextTPrint = readText[i];
        }
 
        private void TextPanel_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            TextPanel.ReadOnly = true;
            textBox1.ReadOnly = true;
            label2.Visible = false;
            label3.Visible = false;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            label4.Visible = true;
            label1.Visible = true;
            timer1.Start();
            GenerateSent();
            TextPanel.Text = textToPrnt.TextTPrint;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
            ticksTimerToStart--;
            timer1.Interval = 1000;
            if (ticksTimerToStart < 0&&fl==true)
            {
                timer1.Interval = 1;
                label1.Visible = false;
                textBox1.ReadOnly = false;
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = false;
                timer2.Start();

            }
            label1.Text = ticksTimerToStart.ToString();
            ChangeClr1(TextPanel, input);
            CheckOnEnd(input);
            if (ticksTimerToEnd < 1&&fl==true)
            {
                fl = false;
                timer2.Stop();
                label3.Visible=false;
                label2.Visible=false;
                CheckOnRecord(input.Wordcount);
                Print(input);
                
                
            }
        }
 
        public void CheckOnRecord(double wordsAmount)
        {
            List<string> list = new List<string>();
            bool swap = false;
            int number;
            lines.CopyTo(linesToWrite, 0);
            for (int i = 0; i < linesToWrite.Length; i++)
            {
                number = 0;
                if (!string.IsNullOrEmpty(linesToWrite[i]))
                {
                    string[] words = linesToWrite[i].Split(' ');
                    number = int.Parse(words[0]);
                }
                if (swap)
                {
                    list.Add(linesToWrite[i - 1]);
                }
                if (wordsAmount > number && !swap)
                {
                    swap = true;
                    list.Add($"{wordsAmount} words : {DateTime.Now.ToShortDateString()}");
                }
                else if (!swap)
                {
                    list.Add(linesToWrite[i]);
                }
            }
            File.WriteAllLines("WOSrecords.txt", list);
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            ticksTimerToEnd--;
            timer2.Interval = 1000;
            label2.Text = ticksTimerToEnd.ToString();
        }
        void ChangeClr1(RichTextBox TextPanel, PlayersInput input)
        {
            input.Text = textBox1.Text;
            int lng = input.Text.Length;
            string substring="";
            try
            {
                 fl1 = true;
                 substring = textToPrnt.TextTPrint.Substring(0, lng);
            }
            catch
            {
                timer1.Enabled = false;
                timer2.Enabled = false;
                MessageBox.Show("Забагато символів!");
                textBox1.Text = null;
            }
            if (fl1)
            {
                timer1.Enabled = true;
                timer2.Enabled = true;
            }
            string text2 = input.Text;
            if (substring == input.Text)
            {
                TextPanel.BackColor = Color.LightGreen;
            }
            else
            {
                TextPanel.BackColor = Color.LightCoral;
                if (text1 != text2 && length > lng)
                    mistakes++;
            }
            text1 = input.Text;
            length = lng;
        }
        void CheckOnEnd(PlayersInput input)
        {
            input.Text = textBox1.Text;
            if (input.Text.Length == textToPrnt.TextTPrint.Length
                && input.Text == textToPrnt.TextTPrint)
            {
                if (ticksTimerToEnd >= 0)
                {
                    input.Wordcount++;
                    textBox1.Text = null;
                    GenerateSent();
                    TextPanel.Text = textToPrnt.TextTPrint;
                }
               
            }
        }
        void Print(PlayersInput input)
        {
            MessageBox.Show($"Введено слів:{input.Wordcount:f0}\n Помилок:{mistakes:f0}");
            Form4 form = new Form4();
            this.Hide();
            form.Show();
        }

        private void ReturnToMenu_Click_1(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            this.Hide();
            form3.Show();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            label4.Visible = true;
            label1.Visible = true;
            timer1.Start();
            GenerateSent();
            TextPanel.Text = textToPrnt.TextTPrint;
        }

        private void ReturnToMenu_Click(object sender, EventArgs e)
        {

        }
    }
}
