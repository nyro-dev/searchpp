using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Xml.Linq;
using System.IO;
using System.Windows.Forms;

namespace Search
{
    partial class Form1
    {
        #region Vars

        // User search engine database
        internal bool home = true;
        internal Engine selectedEngine;
        internal Engine defaultEngine;
        internal Dictionary<string, Engine> ENGINES = new Dictionary<string, Engine>();

        // Default window size and position
        int defaultWidth = SystemInformation.WorkingArea.Width / 3; // 400;
        int defaultHeight = SystemInformation.WorkingArea.Height / 3; // 600;

        //int offsetX = 5;
        //int offsetY = 5;

        // Global Hotkey
        internal GlobalHotkey globalHotkey;

        // Options
        internal Config config = new Config();

        #endregion

        #region WebBrowser Stuff

        private void ShowWebbrowser()
        {
            webBrowser1.Show();

            string width;
            if (!selectedEngine.IntParams.TryGetValue("width", out width))
                width = defaultWidth.ToString();

            string height;
            if (!selectedEngine.IntParams.TryGetValue("height", out height))
                height = defaultHeight.ToString();

            ResizeWindow(Convert.ToInt32(width), Convert.ToInt32(height));
        }      

        private void HideWebbrowser()
        {
            webBrowser1.Navigate("about:blank");
            webBrowser1.Hide();

            ResizeWindow(defaultWidth, 0);
        }

        private void scrollWebBrowser()
        {
            string left = "0";
            selectedEngine.IntParams.TryGetValue("left", out left);
            string top = "0";
            selectedEngine.IntParams.TryGetValue("top", out top);

            webBrowser1.Document.Window.ScrollTo(new Point(Convert.ToInt32(left), Convert.ToInt32(top)));
        }

        #endregion       

        #region Hotkey Stuff

        private void SelectEngine(Engine engine)
        {
            if (home && engine != null)
            {
                home = false;
                selectedEngine = engine;
                this.Text = "Search++ > " + selectedEngine.Name;
                textBox1.Clear();
            }
        }

        private void DeselectEngine()
        {
            home = true;
            selectedEngine = defaultEngine;

            this.Text = "Search++";
            textBox1.Clear();

            HideWebbrowser();
        }

        private void RunSearch(KeyEventArgs e)
        {
            if (selectedEngine != null)
            {
                string query = System.Web.HttpUtility.UrlEncode(textBox1.Text.Trim());

                if (e.Control)
                {
                    if (config.OpenInternModifier == true)
                        RunInternal(query);
                    else
                        RunExternal(query);
                }
                else
                {
                    if (config.OpenInternModifier == false)
                        RunInternal(query);
                    else
                        RunExternal(query);
                }
            }
        }

        private void RunInternal(string query)
        {
            string url = selectedEngine.IntUrl;
            ShowWebbrowser();
            webBrowser1.Navigate(new Uri(url.Replace("{q}", query)));
        }

        private void RunExternal(string query)
        {
            string url = selectedEngine.ExtUrl;
            System.Diagnostics.Process.Start(url.Replace("{q}", query));
            textBox1.Clear();
            MinimizeToTray();
        }

        #endregion

        #region Global Hotkey

        private void HandleHotkey()
        {
            Console.WriteLine("Hotkey pressed");
            ToggleTray();
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == Constants.WM_HOTKEY_MSG_ID)
                HandleHotkey();
            base.WndProc(ref m);
        }

        private void Register()
        {
            Console.WriteLine("Trying to register global hotkey");
            if (globalHotkey.Register())
                Console.WriteLine("Hotkey registered.");
            else
                Console.WriteLine("Hotkey failed to register");
        }

        private void UnRegister()
        {
            if (!globalHotkey.Unregister())
                MessageBox.Show("Hotkey failed to unregister!");
        }

        private void setGlobalHotkey()
        {
            globalHotkey = new GlobalHotkey(config.getGlobalHotkeyModifierValue(), config.GlobalHotkeyKey, this);
        }
        
        #endregion

        #region Window actions

        private void ResizeWindow(int x, int y)
        {
            this.ClientSize = new System.Drawing.Size(x, y + 20);
            this.textBox1.Size = new System.Drawing.Size(x, 20);
            this.webBrowser1.Size = new System.Drawing.Size(x, y);

            ResetPosition(y);
        }

        private void ResetPosition(int wHeight)
        {
            // Open at bottom left
            Rectangle workingArea = SystemInformation.WorkingArea;
            //Point nLocation = new Point(offsetX, workingArea.Height - this.Height - offsetY);
            int wFrac = workingArea.Width / 3;
            int hFrac = workingArea.Height / 3;
            Point nLocation = new Point(wFrac, workingArea.Height - hFrac - wHeight);
            this.Location = nLocation;
        }

        #endregion

        #region Tray Stuff

        private void ToggleTray()
        {
            if (this.Visible)
                MinimizeToTray();
            else
                RestoreFromTray();
        }

        private void MinimizeToTray()
        {
            DeselectEngine();

            this.Hide();
            this.WindowState = FormWindowState.Minimized;
        }

        internal void RestoreFromTray()
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
            this.Activate(); // Set focus on form
        }

        private void TrayMenu()
        {
            ContextMenu trayMenu = new ContextMenu();

            trayMenu.MenuItems.Add("&Open", notifyIcon_OpenClick).DefaultItem = true;
            trayMenu.MenuItems.Add("O&ptions", notifyIcon_OptionsClick);
            trayMenu.MenuItems.Add("-");
            trayMenu.MenuItems.Add("E&xit", notifyIcon_ExitClick);

            notifyIcon.ContextMenu = trayMenu;
        }

        #endregion

        #region Options

        private void OpenOptions()
        {
            OptionsForm options = new OptionsForm(this);
            options.Show();
        }

        public void reloadConfig()
        {
            setGlobalHotkey();
        }

        #endregion
    }
}