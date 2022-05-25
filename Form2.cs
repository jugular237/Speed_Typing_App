using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace Speed_Typing_App
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            string path = @"c:\Users\bakma\source\repos\курсова\text.txt";
            string[] readText = File.ReadAllLines(path);
           Random random = new Random();
           int i=random.Next(readText.Length);
           richTextBox1.Text=readText[i];

        }
    }
}
