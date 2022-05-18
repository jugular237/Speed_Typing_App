using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Speed_Typing_App
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TextToPrint textToPrnt = new TextToPrint();
            TextPanel.Text = textToPrnt.TextTPrint;
        }
        

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(Text, new Font("Times new Roman", 46, FontStyle.Regular), Brushes.Black, new PointF(50, 50));

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
    public class TextToPrint
    {
        public string TextTPrint { get; set; } = "Print this Text.";
    }
}
