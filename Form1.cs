using System;
using System.Drawing;
using System.Windows.Forms;
using System.Globalization;
using System.IO;
using System.Collections.Generic;

namespace Speed_Typing_App
{

    public partial class Form1 : Form
    {
<<<<<<< HEAD
        TextToPrint textToPrnt = new TextToPrint();

        int ticksTimerToStart = 6;
        int ticksTimerToWrite = 0;

        bool reachedEnd = true;
        bool defaultLanguage = false;

        int mistakes = 0;
        const int records1Number = 100;
        const int delayInMlseconds = 1000;
        
        string[] lines = File.ReadAllLines("records.txt");
        string[] linesToWrite = new string[records1Number];

=======
        //основні класси:
        public class Result
        {
            public readonly double wpmRes;

            public readonly DateTime date;

            public Result(double wpm, DateTime date)
            {
                wpmRes = wpm;
                this.date = date;
            }
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
        //загальні змінні:
        string[] lines = File.ReadAllLines("records.txt");
        string[] linesToWrite = new string[100];
        int ticks = 6;
        int ticks1 = 0;
        bool flag = true;
        int misc = 0;
        bool lang = false;
        string text1 = "";
        int length = 0;
        TextToPrint textToPrnt = new TextToPrint();
>>>>>>> 7be850ff5147df191a90368769588dc2969d2b29
        public Form1()
        {
            System.Threading.Thread.CurrentThread.CurrentUICulture
               = CultureInfo.GetCultureInfo(Properties.Settings.Default.Language);
            System.Threading.Thread.CurrentThread.CurrentCulture
                = CultureInfo.GetCultureInfo(Properties.Settings.Default.Language);
            InitializeComponent();
        }
<<<<<<< HEAD
        
=======

>>>>>>> 7be850ff5147df191a90368769588dc2969d2b29
        private void Form1_Load(object sender, EventArgs e)
        {
            TextPanel.ReadOnly = true;
            textBox1.ReadOnly = true;
<<<<<<< HEAD
            labelTimerToWrite.Visible = false;
            label3.Visible=false;
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(Text, new Font("Times new Roman", 46, FontStyle.Regular), 
                Brushes.Black, new PointF(50, 50));
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
=======
            label2.Visible = false;
            label3.Visible = false;
        }

       //метод для тіка першого таймеру(таймер відліку)
>>>>>>> 7be850ff5147df191a90368769588dc2969d2b29
        private void timer1_Tick(object sender, EventArgs e)
        {
            PlayersInput input = new PlayersInput();
            ticksTimerToStart--;
            timerToStart.Interval = delayInMlseconds;
            if (ticksTimerToStart < 0)
            {
                timerToStart.Interval = 1;
                label1.Visible = false;
                textBox1.ReadOnly = false;
                labelTimerToWrite.Visible = true;
                label3.Visible = true;
                labelTimerToStart.Visible = false;
                timerToWrite.Start();
                button2.Visible = false;

            }
<<<<<<< HEAD
            label1.Text = ticksTimerToStart.ToString();
=======
            label1.Text = ticks.ToString();
>>>>>>> 7be850ff5147df191a90368769588dc2969d2b29
            ChangeClr1(TextPanel, input);
            CheckOnEnd(input);
        }
        //метод для тіка другого таймера(таймер під час гри)
        private void timer2_Tick(object sender, EventArgs e)
        {
            ticksTimerToWrite++;
            timerToWrite.Interval = 1000;
            labelTimerToWrite.Text = ticksTimerToWrite.ToString();
        }
        //початок гри
        private void button1_Click(object sender, EventArgs e)
        {
            labelTimerToStart.Visible = true;
            timerToStart.Start();
            GenerateSent();
            TextPanel.Text = textToPrnt.TextTPrint;
        }
<<<<<<< HEAD
        string textCopy = "";
        int length = 0;
        void ChangeClr1(RichTextBox TextPanel, PlayersInput input)
        {
            input.Text = textBox1.Text;
            int inputLngth = input.Text.Length;
            string substring = textToPrnt.TextTPrint.Substring(0, inputLngth);
            string plyrsInput = input.Text;
            if (substring == input.Text)
                InputIsCorrect(substring, ref input);
            else
                InputIsWrong(plyrsInput, inputLngth);
            textCopy = input.Text;
            length = inputLngth;
        }
        void InputIsCorrect(string sub, ref PlayersInput input)
        {
            foreach (var letter in sub)
                input.Wordcount++;
            TextPanel.BackColor = Color.LightGreen;
        }
        void InputIsWrong(string playersInput, int inputLngth)
        {
            if (textCopy != playersInput && length > inputLngth)
                mistakes++;
            TextPanel.BackColor = Color.LightCoral;
        }
        void CheckOnEnd(PlayersInput input)
        {
            input.Text = textBox1.Text;
            bool checkLngthSize = input.Text.Length == textToPrnt.TextTPrint.Length;
            bool checkText = input.Text == textToPrnt.TextTPrint;
            if (checkLngthSize && checkText && reachedEnd)
=======
        //метод для перевірки правильності вводу
        void ChangeClr1(RichTextBox TextPanel, Input input)
        {
            input.Text = textBox1.Text;
            int lng = input.Text.Length;
            string sub = textToPrnt.TextTPrint.Substring(0, lng);
            string text2 = input.Text;
            if (sub == input.Text)
            {
                sub.ToCharArray();
                foreach (char c in sub)
                {
                    input.wordcount++;
                }
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
        //метод для перевірки кінця гри
        void CheckOnEnd(Input input)
        {
            input.Text = textBox1.Text;
            if (input.Text.Length == textToPrnt.TextTPrint.Length
                && input.Text == textToPrnt.TextTPrint
                && flag == true)
>>>>>>> 7be850ff5147df191a90368769588dc2969d2b29
            {
                reachedEnd = false;
                timerToStart.Stop();
                timerToWrite.Stop();
                input.Time = ticksTimerToWrite;
                Print(input);
            }
        }
<<<<<<< HEAD
        void Print(PlayersInput input)
        {
            if (mistakes > 0)
                mistakes++;
            double correlem = textToPrnt.TextTPrint.Length - mistakes;
            input.Acc = (correlem / textToPrnt.TextTPrint.Length) * 100.0;
            double wpm = (((input.Wordcount/5)/input.Time)*60);
=======
        //метод для для обчислення значень wpm та accuracy та виводу інформації
        void Print(Input input)
        {
            if (misc > 0)
                misc++;
            double correlem = textToPrnt.TextTPrint.Length - misc;
            input.acc = (correlem / textToPrnt.TextTPrint.Length) * 100.0;
            double wpm = (((input.wordcount / 5) / input.Time) * 60);
>>>>>>> 7be850ff5147df191a90368769588dc2969d2b29
            CheckOnRecord(wpm);
            MessageBox.Show($"Швидкість,слів в хвилину(WPM):{wpm:f0}\nТочність(accuracy)={input.Acc:f1}%");
            Form1 form = new Form1();
            this.Hide();
            form.Show();
        }
<<<<<<< HEAD
       
      
=======
        //метод для обробки результату та запису у файл
>>>>>>> 7be850ff5147df191a90368769588dc2969d2b29
        public void CheckOnRecord(double wpm)
        {
            List<string> list = new List<string>();
            bool swap = false;
            int number;
            Result result = new Result((double)wpm, DateTime.Now);
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
                if (result.wpmRes > number && !swap)
                {
                    swap = true;
                    list.Add($"{(int)result.wpmRes} wpm : {result.date.ToShortDateString()}");
                }
                else if (!swap)
                {
                    list.Add(linesToWrite[i]);
                }
            }
            File.WriteAllLines("records.txt", list);
        }
        //зміна тексту для вводу
        private void button2_Click(object sender, EventArgs e)
        {
            timerToStart.Stop();
            timerToStart.Start();
            GenerateSent();
            TextPanel.Text = textToPrnt.TextTPrint;
        }
        //метод для генерації тексту для вводу
        void GenerateSent()
        {
            string[] readText = File.ReadAllLines("text.txt");
            Random random = new Random();
            int i = random.Next(readText.Length);
            textToPrnt.TextTPrint = readText[i];
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
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            defaultLanguage = true;
            if (languages.SelectedIndex == 0 && defaultLanguage)
                SetLanguage("uk-UA");
            else if (languages.SelectedIndex == 1)
                SetLanguage("en-US");
            else if (languages.SelectedIndex == 2)
                SetLanguage("ja-JP");
        }
        
=======
       //в меню
>>>>>>> 7be850ff5147df191a90368769588dc2969d2b29
        private void ReturnToMenu_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            this.Hide();
            form3.Show();
        }
    }
}

