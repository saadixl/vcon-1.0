using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Recognition;
using System.Speech.Recognition.SrgsGrammar;
using System.Speech.Synthesis;
using System.Speech.Synthesis.TtsEngine;



namespace vCon_1._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
             
            notifyIcon1.ShowBalloonTip(50);
            notifyIcon1.ContextMenuStrip = contextMenuStrip1;

            SpeechRecognizer sr = new SpeechRecognizer();
            Choices commands = new Choices();
            commands.Add(new string[] { "up", "down", "right", "left", "ok", "back", "tab","escape", "close" });

            GrammarBuilder gbuilder = new GrammarBuilder();
            gbuilder.Append(commands);

            // Create the Grammar instance.
            Grammar g = new Grammar(gbuilder);
            sr.LoadGrammar(g);
            g.Priority = 127;
            sr.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(sr_SpeechRecognized);

        }
        void sr_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            string str = e.Result.Text;
            if (str == "up")
            {
                System.Windows.Forms.SendKeys.Send("{UP}");
            }

            else if (str == "down")
            {
                System.Windows.Forms.SendKeys.Send("{DOWN}");
            }

            else if (str == "right")
            {
                System.Windows.Forms.SendKeys.Send("{RIGHT}");
            }

            else if (str == "left")
            {
                System.Windows.Forms.SendKeys.Send("{LEFT}");
            }
           

            else if (str == "ok")
            {
                System.Windows.Forms.SendKeys.Send("{ENTER}");
            }
            else if (str == "back")
            {
                System.Windows.Forms.SendKeys.Send("{BACKSPACE}");
            }
            else if (str == "tab")
            {
                System.Windows.Forms.SendKeys.Send("{TAB}");
            }
            else if (str == "escape")
            {
                System.Windows.Forms.SendKeys.Send("{ESC}");
            }
            else if (str == "close")
            {
                System.Windows.Forms.SendKeys.Send("{^W}");
            }
           

           


            
        }

        private void notifyIcon1_MouseDoubleClick(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            notifyIcon1.ShowBalloonTip(50);
        }

       

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Name\tvCon 1.0\nVersion\tv1.0\nAuthor\tA.M. Masudul Haque\nEmail\tsaadixl@gmail.com","About vCon 1.0");
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        


      
    }
}
