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
<<<<<<< HEAD
        Form1 form1 = new Form1();
        Form4 form4 = new Form4();

        bool language = false;
        
=======
>>>>>>> 7be850ff5147df191a90368769588dc2969d2b29
        public Form3()
        {
            System.Threading.Thread.CurrentThread.CurrentUICulture
               = CultureInfo.GetCultureInfo(Properties.Settings.Default.Language);
            System.Threading.Thread.CurrentThread.CurrentCulture
                = CultureInfo.GetCultureInfo(Properties.Settings.Default.Language);
            InitializeComponent();
        }
<<<<<<< HEAD
        
=======
        //загальні змінні
        bool lang = false;
        Form1 form1 = new Form1();
        Form4 form4 = new Form4();
        //класичний режим
>>>>>>> 7be850ff5147df191a90368769588dc2969d2b29
        private void startButton_Click(object sender, EventArgs e)
        {
            form1.Show();
            this.Hide();
        }
        //WOS режим
        private void start2Button_Click(object sender, EventArgs e)
        {
            form4.Show();
            this.Hide();
        }

        //метод для зчитування даних із файлу і запису рекордів у форму
        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            ReadRecords(form2);
        }

        private void ReadRecords(Form2 form2)
        {
            string[] recordsLines = File.ReadAllLines("records.txt");
            string[] wosRecordsLines = File.ReadAllLines("WOSrecords.txt");
            foreach (string line in recordsLines)
                form2.RecordsBox.Text += line + "\n";
            foreach (string line in wosRecordsLines)
                form2.WOSRecords.Text += line + "\n";
            form2.RecordsBox.ReadOnly = true;
            form2.RecordsBox.ReadOnly = true;
            form2.label1.Focus();
        }
<<<<<<< HEAD

        void SetLanguage(string language_Country)
        {
            System.Threading.Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo(language_Country);
            System.Threading.Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo(language_Country);
            Properties.Settings.Default.Language = language_Country;
            Properties.Settings.Default.Save();
            Application.Restart();
        }
=======
        //локалізація
>>>>>>> 7be850ff5147df191a90368769588dc2969d2b29
        private void languages_SelectedIndexChanged(object sender, EventArgs e)
        {
            language = true;
            if (languages.SelectedIndex == 0 && language) 
            {
                SetLanguage("uk-UA");
                languages.Text = "Українська";
            }
            else if (languages.SelectedIndex == 1)
            {
                SetLanguage("en-US");
                languages.Text = "English";
            }
            else if (languages.SelectedIndex == 2)
            {
                SetLanguage("ja-JP");
                languages.Text = "日本";
            }
        }
        //вихід
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
<<<<<<< HEAD

        private void start2Button_Click(object sender, EventArgs e)
        {
            form4.Show();
            this.Hide();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
=======
       
>>>>>>> 7be850ff5147df191a90368769588dc2969d2b29
    }
}
