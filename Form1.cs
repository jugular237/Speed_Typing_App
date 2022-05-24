using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Globalization;



namespace Speed_Typing_App
{

    public partial class Form1 : Form
    {
        int ticks = 6;
        int ticks1 = 0;
        bool flag = true;
        int misc = 0;
        public Form1()
        {
                InitializeComponent();
        }
       
        public class TextToPrint
        {
            public string TextTPrint { get; set; } = "I like eat little childs and i love shasha mandrik";
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
        private void Form1_Load(object sender, EventArgs e)
        {
            TextToPrint textToPrnt = new TextToPrint();
            TextPanel.Text = textToPrnt.TextTPrint;
            TextPanel.ReadOnly = true;
            textBox1.ReadOnly = true;
            label2.Visible = false;
            label3.Visible=false;
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(Text, new Font("Times new Roman", 46, FontStyle.Regular), Brushes.Black, new PointF(50, 50));

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
            TextToPrint textToPrnt = new TextToPrint();
            ticks1++;
            timer2.Interval = 1000;
            label2.Text = ticks1.ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();

        }
        void ChangeClr1(RichTextBox TextPanel, Input input)
        {
            TextToPrint textToPrnt = new TextToPrint();
            input.Text = textBox1.Text;
            int lng = input.Text.Length;
            string sub=textToPrnt.TextTPrint.Substring(0, lng);
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
                //MessageBox.Show("end");
                TextPanel.BackColor = Color.LightGreen;
            }
            else if(sub!= input.Text)
            {
                misc++;
                TextPanel.BackColor = Color.LightCoral;
            }
            
        }
        void CheckOnEnd(Input input)
        {
            input.Text = textBox1.Text;
            TextToPrint textToPrnt = new TextToPrint();
            if (input.Text.Length == textToPrnt.TextTPrint.Length && input.Text == textToPrnt.TextTPrint && flag == true)
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
            label5.Visible = true;
            label5.Text = misc.ToString();
            TextToPrint textToPrnt = new TextToPrint();
            double correlem = textToPrnt.TextTPrint.Length - misc;
            input.acc = (correlem / textToPrnt.TextTPrint.Length) * 100.0;
            double wpm = (((input.wordcount + 1)/input.Time)*60);
            MessageBox.Show($"Швидкість,слів в хвилину(WPM):{wpm:f0}\nТочність(accuracy)={input.acc:f1}%");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
    
