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


namespace Speed_Typing_App
{

    public partial class Form1 : Form
    {
        int ticks=6;
        int ticks1 = 0;
        public Form1()
        {
            InitializeComponent();
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

        static System.Windows.Forms.Timer myTimer = new System.Windows.Forms.Timer();
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
        private void timer1_Tick(object sender, EventArgs e)
        {
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
            
            //ChangeClr(TextPanel);
            ChangeClr1(TextPanel);

        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            TextPanel.Font = new Font(TextPanel.Font, FontStyle.Regular);
            timer1.Start();
           
        }
        void ChangeClr1(RichTextBox TextPanel)
        {
            Input input = new Input();
            TextToPrint textToPrnt = new TextToPrint();
            input.Text = textBox1.Text;
            int lng = input.Text.Length;
            string sub=textToPrnt.TextTPrint.Substring(0, lng);
            if (sub == input.Text)
            { 
                sub.ToCharArray();
                foreach(char c in sub)
                if (c==' ')
                {
                        input.wordcount++;
                }
                TextPanel.BackColor = Color.Green;
            }
            else TextPanel.BackColor = Color.Red;
            //Print(input);
        }
        //void Print(Input input)
        //{
        //    label1.Text=input.wordcount.ToString();
        //   label1.Visible=true;
        //}

        public class TextToPrint
        {
            public string TextTPrint { get; set; } = "I love eat little childs and fuck kakashka ";
            
        }
        public class Input
        {
            public string Text;
            public double acc;
            public double wordcount = 0;
            public int time;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            ticks1++;
            timer2.Interval = 1000;
            label2.Text = ticks1.ToString();
            
        }
    }
}
    
