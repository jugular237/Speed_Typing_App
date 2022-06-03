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
        int ticks = 6;
        int ticks1 = 20;
       
        string text1 = "";
        int length = 0;
        int misc = 0;
        bool flag = true;
        bool fl = true, fl1 = true;
        Input input = new Input();
        TextToPrint textToPrnt = new TextToPrint();
        public Form4()
        {
            InitializeComponent();
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
           
            ticks--;
            timer1.Interval = 1000;
            if (ticks < 0&&fl==true)
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
            ChangeClr1(TextPanel, input);
            CheckOnEnd(input);
            if (ticks1 < 1&&fl==true)
            {
                fl = false;
                timer2.Stop();
                label3.Visible=false;
                label2.Visible=false;
                Print(input);
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            ticks1--;
            timer2.Interval = 1000;
            label2.Text = ticks1.ToString();
        }
        void ChangeClr1(RichTextBox TextPanel, Input input)
        {
            input.Text = textBox1.Text;
            int lng = input.Text.Length;
            string sub="";
            try
            {
                fl1 = true;
                 sub = textToPrnt.TextTPrint.Substring(0, lng);
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
            if (sub == input.Text)
            {
                TextPanel.BackColor = Color.LightGreen;
            }
            else if (sub != input.Text)
            {
                TextPanel.BackColor = Color.LightCoral;

                if (text1 != text2 && length > lng)
                {
                    misc++;
                }
            }
            text1 = input.Text;
            length = lng;
        }
        void CheckOnEnd(Input input)
        {
            input.Text = textBox1.Text;
            if (input.Text.Length == textToPrnt.TextTPrint.Length
                && input.Text == textToPrnt.TextTPrint)
            {
                if (ticks1 >= 0)
                {
                    input.wordcount++;
                    textBox1.Text = null;
                    GenerateSent();
                    TextPanel.Text = textToPrnt.TextTPrint;
                }
               
            }
        }
        void Print(Input input)
        {
            MessageBox.Show($"Введено слів:{input.wordcount:f0}\n Помилок:{misc:f0}");
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
