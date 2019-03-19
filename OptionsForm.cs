using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Search
{
    public partial class OptionsForm : Form
    {
        int tmpGlobalKey;
        List<int> tmpGlobalModifiers = new List<int>();
        Form1 form;
        bool tmpOpenInternModifier;

        public OptionsForm(Form1 form)
        {
            InitializeComponent();
            this.form = form;

            // Configuration Tab
            setTextBoxes();
            tmpOpenInternModifier = true;

            // Engines Tab
            loadEnginesCombobox();
        }

        #region Configuration Tab

        void modifierTextBox_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (this.modifierTextBox.Enabled == true)
            {
                if (e.KeyCode == Keys.Escape)
                {
                    this.keyTextBox.Enabled = false;
                    this.setGlobalKeyButton.Text = "Set";
                }
                else if (e.Alt && !tmpGlobalModifiers.Contains(1))
                {
                    if (this.modifierTextBox.Text == "")
                        this.modifierTextBox.Text = "ALT";
                    else
                        this.modifierTextBox.Text += "+ ALT";
                    tmpGlobalModifiers.Add(1);
                }
                else if (e.Control && !tmpGlobalModifiers.Contains(2))
                {
                    if (this.modifierTextBox.Text == "")
                        this.modifierTextBox.Text = "CTRL";
                    else
                        this.modifierTextBox.Text += "+ CTRL";
                    tmpGlobalModifiers.Add(2);
                }
                else if (e.Shift && !tmpGlobalModifiers.Contains(4))
                {
                    if (this.modifierTextBox.Text == "")
                        this.modifierTextBox.Text = "SHIFT";
                    else
                        this.modifierTextBox.Text += "+ SHIFT";
                    tmpGlobalModifiers.Add(4);
                }
                else if (e.KeyCode == Keys.LWin && !tmpGlobalModifiers.Contains(8))
                {
                    if (this.modifierTextBox.Text == "")
                        this.modifierTextBox.Text = "WIN";
                    else
                        this.modifierTextBox.Text += "+ WIN";
                    tmpGlobalModifiers.Add(8);
                }
            }
        }

        void keyTextBox_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (this.keyTextBox.Enabled == true)
            {
                if (e.Alt)
                {
                    tmpGlobalKey = 0;
                    this.keyTextBox.Text = "None";
                }
                else
                {
                    tmpGlobalKey = e.KeyCode.GetHashCode();
                    this.keyTextBox.Text = e.ToString().Substring(0, 0);
                }
                this.keyTextBox.Enabled = false;
                this.setGlobalKeyButton.Text = "Set";
                this.hintLabel.Visible = false;
            }
        }        

        void setGlobalKeyButton_Click(object sender, System.EventArgs e)
        {
            if (this.setGlobalKeyButton.Text.Equals("Set"))
            {
                tmpGlobalKey = -1;
                this.keyTextBox.Text = "";
                this.setGlobalKeyButton.Text = "Done";
                this.keyTextBox.Enabled = true;
                this.hintLabel.Visible = true;
                this.keyTextBox.Focus();
            }
            else
            {
                this.keyTextBox.Enabled = false;
                this.hintLabel.Visible = false;
                this.setGlobalKeyButton.Text = "Set";
            }
        }

        void setGlobalModifiersButton_Click(object sender, System.EventArgs e)
        {
            if (this.setGlobalModifiersButton.Text.Equals("Set"))
            {
                tmpGlobalModifiers.Clear();
                this.modifierTextBox.Text = "";
                this.setGlobalModifiersButton.Text = "Done";
                this.modifierTextBox.Enabled = true;
                this.modifierTextBox.Focus();
            }
            else
            {
                this.modifierTextBox.Enabled = false;
                this.setGlobalModifiersButton.Text = "Set";
            }
        }

        private void setTextBoxes()
        {
            this.modifierTextBox.Text = form.config.getGlobalHotkeyModifierString();
            this.keyTextBox.Text = Enum.GetValues(typeof(Keys)).GetValue(form.config.GlobalHotkeyKey).ToString();
            tmpOpenInternModifier = form.config.OpenInternModifier;
            if (form.config.OpenInternModifier == true)
            {
                this.openInternTextBox.Text = "CTRL + Enter";
                this.openExternTextBox.Text = "Enter";
            }
            else
            {
                this.openInternTextBox.Text = "Enter";
                this.openExternTextBox.Text = "CTRL + Enter";
            }
        }

        private void swapButton_Click(object sender, EventArgs e)
        {
            string tmp = this.openExternTextBox.Text;
            this.openExternTextBox.Text = this.openInternTextBox.Text;
            this.openInternTextBox.Text = tmp;
            tmpOpenInternModifier = !tmpOpenInternModifier;
        }

        #endregion

        #region Engines Tab

        private void loadEnginesCombobox()
        {
            foreach (Engine e in form.ENGINES.Values)
            {
                this.enginesCombobox.Items.Add(e.Name);
            }
            this.enginesCombobox.SelectedIndex = 0;
        }

        void enginesCombobox_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            Engine tmp = form.ENGINES.Values.ElementAt(this.enginesCombobox.SelectedIndex);

            this.defaultCheckBox.Checked = tmp.DefaultEngine;

            this.nameTextBox.Text = tmp.Name;
            this.shortcutTextBox.Text = tmp.Shortcut;
            this.extURLTextBox.Text = tmp.ExtUrl;
            this.intURLTextBox.Text = tmp.IntUrl;

            StringBuilder sb = new StringBuilder();
            foreach (KeyValuePair<string, string> kvp in tmp.IntParams)
            {
                sb.Append(kvp.Key + "=\"" + kvp.Value + "\", ");
            }
            if (sb.Length > 0)
                this.intParamsTextBox.Text = sb.ToString().Substring(0, sb.Length - 2);
            else
                this.intParamsTextBox.Text = string.Empty;
        }

        #endregion

        #region General

        void cancelButton_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        void saveButton_Click(object sender, System.EventArgs e)
        {
            // Configuration Tab
            if (tmpGlobalKey != -1)
                form.config.GlobalHotkeyKey = tmpGlobalKey;

            if (tmpGlobalModifiers.Count > 0)
                form.config.setGlobalHotkeyModifers(tmpGlobalModifiers);

            XMLUtil.writeConfig();
            form.reloadConfig();

            // Engines Tab
            Engine tmp = form.ENGINES.Values.ElementAt(this.enginesCombobox.SelectedIndex);

            tmp.DefaultEngine = this.defaultCheckBox.Checked;

            tmp.Name = this.nameTextBox.Text;
            tmp.ExtUrl = this.extURLTextBox.Text;
            tmp.IntUrl = this.intURLTextBox.Text;

            Dictionary<string, string> intParams = new Dictionary<string, string>();
            string t;
            foreach (string s in this.intParamsTextBox.Text.Split(','))
            {
                t = s.Trim();
                intParams.Add(t.Split('=')[0], t.Split('=')[1].Substring(1, t.Split('=')[1].Length - 2));
            }

            if (intParams.Count > 0)
                tmp.IntParams = intParams;

            XMLUtil.writeEngines();

            this.Close();
        }

        #endregion
    }
}
