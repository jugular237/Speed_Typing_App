using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.IO;
using System.Reflection;

namespace Speed_Typing_App
{
    public partial class Form3 : Form
    {
        bool lang = false;
        Form1 form1 = new Form1();
        public Form3()
        {
            System.Threading.Thread.CurrentThread.CurrentUICulture
               = CultureInfo.GetCultureInfo(Properties.Settings.Default.Language);
            System.Threading.Thread.CurrentThread.CurrentCulture
                = CultureInfo.GetCultureInfo(Properties.Settings.Default.Language);
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            form1.Show();
            this.Hide();
        }
    
        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            string[] recordsLines = File.ReadAllLines("records.txt");
            foreach (string line in recordsLines)
            {
                form2.RecordsBox.Text += line + "\n";
            }
            form2.RecordsBox.ReadOnly = true;
            form2.label1.Focus();
        }

        private void languages_SelectedIndexChanged(object sender, EventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
