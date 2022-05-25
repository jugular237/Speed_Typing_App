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
            PrintRecords();
            
        }

        private void PrintRecords()
        {
            string[] recordsLines = File.ReadAllLines("records.txt");
            foreach (string line in recordsLines)
            {
                RecordsBox.Text += line + "\n";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           //string[] readText = File.ReadAllLines("text.txt");   <- нашо це?
           //Random random = new Random();
           //int i=random.Next(readText.Length);
           //RecordsBox.Text=readText[i];
        }

        private void RecordsBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
