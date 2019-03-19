using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Search
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();

            XMLUtil.init(this);
            XMLUtil.readEngines();
            XMLUtil.readConfig();

            reloadConfig();

            TrayMenu();

            MinimizeToTray();
        }   

        #region Listeners

        private void Form1_Load(object sender, EventArgs e)
        {
            Register();
            MinimizeToTray();
        }

        protected void Form1_LostFocus(object sender, System.EventArgs e) // Close window then focus is lost
        {
            MinimizeToTray();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            UnRegister();
            notifyIcon.Visible = false;
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e) // Listen for navigation keys
        {
            if (e.KeyCode == Keys.Space)
            {
                if (ENGINES.ContainsKey(textBox1.Text))
                {
                    SelectEngine(ENGINES[textBox1.Text]);
                }
            }
            else if (e.KeyCode == Keys.Escape)
            {
                DeselectEngine();
                MinimizeToTray();
                //if (home)
                //{
                //    MinimizeToTray();
                //}
                //else
                //{
                //    DeselectEngine();
                //}
            }
            else if (e.KeyCode == Keys.Return)
            {
                RunSearch(e);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e) // Remove single whitespace after engine selection
        {
            if (textBox1.Text == " ")
            {
                textBox1.Clear();
            }
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e) // Scroll to desired position
        {
            scrollWebBrowser();
        }

        protected void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            RestoreFromTray();
        }

        protected void notifyIcon_OpenClick(object sender, EventArgs e)
        {
            RestoreFromTray();
        }

        protected void notifyIcon_OptionsClick(object sender, EventArgs e)
        {
            OpenOptions();
        }

        protected void notifyIcon_ExitClick(object sender, EventArgs e)
        {
            Close();
        }

        #endregion

    }
}