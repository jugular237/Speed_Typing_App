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
            }
            else
                label1.Text = ticks.ToString();
            //ChangeClr(TextPanel);
            ChangeClr1(TextPanel);

        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            TextPanel.Font = new Font(TextPanel.Font, FontStyle.Regular);
            timer1.Start();
           
        }
        void ChangeClr(RichTextBox TextPanel)
        {
            int index = 0;
            Input input = new Input();
            TextToPrint textToPrnt = new TextToPrint();
            input.Text = textBox1.Text;
            foreach (var i in input.Text)
            {
                if (i == textToPrnt.TextTPrint[index])
                {
                    
                    TextPanel.BackColor = Color.Green;
                }
                else TextPanel.BackColor = Color.Red;
                index++;
            }
            //label2.Text= textToPrnt.TextTPrint[index].ToString();
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
                TextPanel.BackColor = Color.Green;
            }
            else TextPanel.BackColor = Color.Red;
        }

        public class TextToPrint
        {
            public string TextTPrint { get; set; } = "I love eat little childs and fuck kakashka";
        }
        public class Input
        {
            public string Text;
        }
    }
}
    
