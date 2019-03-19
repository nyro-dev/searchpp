namespace Search
{
    partial class OptionsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.globalHotkeyLabel = new System.Windows.Forms.Label();
            this.modifierTextBox = new System.Windows.Forms.TextBox();
            this.keyTextBox = new System.Windows.Forms.TextBox();
            this.setGlobalModifiersButton = new System.Windows.Forms.Button();
            this.setGlobalKeyButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.hotkeyLabel = new System.Windows.Forms.Label();
            this.internLabel = new System.Windows.Forms.Label();
            this.openInternTextBox = new System.Windows.Forms.TextBox();
            this.openExternTextBox = new System.Windows.Forms.TextBox();
            this.externLabel = new System.Windows.Forms.Label();
            this.swapButton = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.hintLabel = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.defaultCheckBox = new System.Windows.Forms.CheckBox();
            this.intParamsTextBox = new System.Windows.Forms.TextBox();
            this.intURLTextBox = new System.Windows.Forms.TextBox();
            this.extURLTextBox = new System.Windows.Forms.TextBox();
            this.shortcutTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.intParamsLabel = new System.Windows.Forms.Label();
            this.intURLLabel = new System.Windows.Forms.Label();
            this.extURLLabel = new System.Windows.Forms.Label();
            this.shortcutLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.propertiesLabel = new System.Windows.Forms.Label();
            this.delEngineButton = new System.Windows.Forms.Button();
            this.addEngineButton = new System.Windows.Forms.Button();
            this.enginesCombobox = new System.Windows.Forms.ComboBox();
            this.enginesLabel = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // globalHotkeyLabel
            // 
            this.globalHotkeyLabel.AutoSize = true;
            this.globalHotkeyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.globalHotkeyLabel.Location = new System.Drawing.Point(10, 10);
            this.globalHotkeyLabel.Name = "globalHotkeyLabel";
            this.globalHotkeyLabel.Size = new System.Drawing.Size(87, 13);
            this.globalHotkeyLabel.TabIndex = 0;
            this.globalHotkeyLabel.Text = "Global Hotkey";
            // 
            // modifierTextBox
            // 
            this.modifierTextBox.Enabled = false;
            this.modifierTextBox.Location = new System.Drawing.Point(13, 26);
            this.modifierTextBox.Name = "modifierTextBox";
            this.modifierTextBox.Size = new System.Drawing.Size(100, 20);
            this.modifierTextBox.TabIndex = 1;
            this.modifierTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.modifierTextBox_KeyDown);
            // 
            // keyTextBox
            // 
            this.keyTextBox.Enabled = false;
            this.keyTextBox.Location = new System.Drawing.Point(119, 26);
            this.keyTextBox.Name = "keyTextBox";
            this.keyTextBox.Size = new System.Drawing.Size(100, 20);
            this.keyTextBox.TabIndex = 2;
            this.keyTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyTextBox_KeyDown);
            // 
            // setGlobalModifiersButton
            // 
            this.setGlobalModifiersButton.Location = new System.Drawing.Point(13, 53);
            this.setGlobalModifiersButton.Name = "setGlobalModifiersButton";
            this.setGlobalModifiersButton.Size = new System.Drawing.Size(75, 23);
            this.setGlobalModifiersButton.TabIndex = 3;
            this.setGlobalModifiersButton.Text = "Set";
            this.setGlobalModifiersButton.UseVisualStyleBackColor = true;
            this.setGlobalModifiersButton.Click += new System.EventHandler(this.setGlobalModifiersButton_Click);
            // 
            // setGlobalKeyButton
            // 
            this.setGlobalKeyButton.Location = new System.Drawing.Point(119, 53);
            this.setGlobalKeyButton.Name = "setGlobalKeyButton";
            this.setGlobalKeyButton.Size = new System.Drawing.Size(75, 23);
            this.setGlobalKeyButton.TabIndex = 4;
            this.setGlobalKeyButton.Text = "Set";
            this.setGlobalKeyButton.UseVisualStyleBackColor = true;
            this.setGlobalKeyButton.Click += new System.EventHandler(this.setGlobalKeyButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(22, 226);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 5;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(103, 226);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 6;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // hotkeyLabel
            // 
            this.hotkeyLabel.AutoSize = true;
            this.hotkeyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hotkeyLabel.Location = new System.Drawing.Point(10, 86);
            this.hotkeyLabel.Name = "hotkeyLabel";
            this.hotkeyLabel.Size = new System.Drawing.Size(97, 13);
            this.hotkeyLabel.TabIndex = 7;
            this.hotkeyLabel.Text = "Search Hotkeys";
            // 
            // internLabel
            // 
            this.internLabel.AutoSize = true;
            this.internLabel.Location = new System.Drawing.Point(12, 99);
            this.internLabel.Name = "internLabel";
            this.internLabel.Size = new System.Drawing.Size(60, 13);
            this.internLabel.TabIndex = 8;
            this.internLabel.Text = "open intern";
            // 
            // openInternTextBox
            // 
            this.openInternTextBox.Enabled = false;
            this.openInternTextBox.Location = new System.Drawing.Point(13, 115);
            this.openInternTextBox.Name = "openInternTextBox";
            this.openInternTextBox.Size = new System.Drawing.Size(100, 20);
            this.openInternTextBox.TabIndex = 9;
            // 
            // openExternTextBox
            // 
            this.openExternTextBox.Enabled = false;
            this.openExternTextBox.Location = new System.Drawing.Point(119, 115);
            this.openExternTextBox.Name = "openExternTextBox";
            this.openExternTextBox.Size = new System.Drawing.Size(100, 20);
            this.openExternTextBox.TabIndex = 10;
            // 
            // externLabel
            // 
            this.externLabel.AutoSize = true;
            this.externLabel.Location = new System.Drawing.Point(116, 99);
            this.externLabel.Name = "externLabel";
            this.externLabel.Size = new System.Drawing.Size(63, 13);
            this.externLabel.TabIndex = 11;
            this.externLabel.Text = "open extern";
            // 
            // swapButton
            // 
            this.swapButton.Location = new System.Drawing.Point(13, 141);
            this.swapButton.Name = "swapButton";
            this.swapButton.Size = new System.Drawing.Size(75, 23);
            this.swapButton.TabIndex = 12;
            this.swapButton.Text = "Swap";
            this.swapButton.UseVisualStyleBackColor = true;
            this.swapButton.Click += new System.EventHandler(this.swapButton_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(5, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(275, 215);
            this.tabControl1.TabIndex = 13;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.hintLabel);
            this.tabPage1.Controls.Add(this.swapButton);
            this.tabPage1.Controls.Add(this.externLabel);
            this.tabPage1.Controls.Add(this.openExternTextBox);
            this.tabPage1.Controls.Add(this.openInternTextBox);
            this.tabPage1.Controls.Add(this.internLabel);
            this.tabPage1.Controls.Add(this.hotkeyLabel);
            this.tabPage1.Controls.Add(this.setGlobalKeyButton);
            this.tabPage1.Controls.Add(this.setGlobalModifiersButton);
            this.tabPage1.Controls.Add(this.keyTextBox);
            this.tabPage1.Controls.Add(this.modifierTextBox);
            this.tabPage1.Controls.Add(this.globalHotkeyLabel);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(267, 189);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Configuration";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // hintLabel
            // 
            this.hintLabel.AutoSize = true;
            this.hintLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hintLabel.Location = new System.Drawing.Point(201, 53);
            this.hintLabel.Name = "hintLabel";
            this.hintLabel.Size = new System.Drawing.Size(58, 36);
            this.hintLabel.TabIndex = 13;
            this.hintLabel.Text = "Hint:\r\nPress ALT to\r\nset to \'None\'";
            this.hintLabel.Visible = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.defaultCheckBox);
            this.tabPage2.Controls.Add(this.intParamsTextBox);
            this.tabPage2.Controls.Add(this.intURLTextBox);
            this.tabPage2.Controls.Add(this.extURLTextBox);
            this.tabPage2.Controls.Add(this.shortcutTextBox);
            this.tabPage2.Controls.Add(this.nameTextBox);
            this.tabPage2.Controls.Add(this.intParamsLabel);
            this.tabPage2.Controls.Add(this.intURLLabel);
            this.tabPage2.Controls.Add(this.extURLLabel);
            this.tabPage2.Controls.Add(this.shortcutLabel);
            this.tabPage2.Controls.Add(this.nameLabel);
            this.tabPage2.Controls.Add(this.propertiesLabel);
            this.tabPage2.Controls.Add(this.delEngineButton);
            this.tabPage2.Controls.Add(this.addEngineButton);
            this.tabPage2.Controls.Add(this.enginesCombobox);
            this.tabPage2.Controls.Add(this.enginesLabel);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(267, 189);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Engines";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // defaultCheckBox
            // 
            this.defaultCheckBox.AutoSize = true;
            this.defaultCheckBox.Location = new System.Drawing.Point(137, 58);
            this.defaultCheckBox.Name = "defaultCheckBox";
            this.defaultCheckBox.Size = new System.Drawing.Size(58, 17);
            this.defaultCheckBox.TabIndex = 15;
            this.defaultCheckBox.Text = "default";
            this.defaultCheckBox.UseVisualStyleBackColor = true;
            // 
            // intParamsTextBox
            // 
            this.intParamsTextBox.Location = new System.Drawing.Point(69, 157);
            this.intParamsTextBox.Name = "intParamsTextBox";
            this.intParamsTextBox.Size = new System.Drawing.Size(174, 20);
            this.intParamsTextBox.TabIndex = 14;
            // 
            // intURLTextBox
            // 
            this.intURLTextBox.Location = new System.Drawing.Point(69, 137);
            this.intURLTextBox.Name = "intURLTextBox";
            this.intURLTextBox.Size = new System.Drawing.Size(174, 20);
            this.intURLTextBox.TabIndex = 13;
            // 
            // extURLTextBox
            // 
            this.extURLTextBox.Location = new System.Drawing.Point(69, 117);
            this.extURLTextBox.Name = "extURLTextBox";
            this.extURLTextBox.Size = new System.Drawing.Size(174, 20);
            this.extURLTextBox.TabIndex = 12;
            // 
            // shortcutTextBox
            // 
            this.shortcutTextBox.Enabled = false;
            this.shortcutTextBox.Location = new System.Drawing.Point(69, 97);
            this.shortcutTextBox.Name = "shortcutTextBox";
            this.shortcutTextBox.Size = new System.Drawing.Size(174, 20);
            this.shortcutTextBox.TabIndex = 11;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(69, 77);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(174, 20);
            this.nameTextBox.TabIndex = 10;
            // 
            // intParamsLabel
            // 
            this.intParamsLabel.AutoSize = true;
            this.intParamsLabel.Location = new System.Drawing.Point(7, 160);
            this.intParamsLabel.Name = "intParamsLabel";
            this.intParamsLabel.Size = new System.Drawing.Size(53, 13);
            this.intParamsLabel.TabIndex = 9;
            this.intParamsLabel.Text = "intParams";
            // 
            // intURLLabel
            // 
            this.intURLLabel.AutoSize = true;
            this.intURLLabel.Location = new System.Drawing.Point(7, 140);
            this.intURLLabel.Name = "intURLLabel";
            this.intURLLabel.Size = new System.Drawing.Size(40, 13);
            this.intURLLabel.TabIndex = 8;
            this.intURLLabel.Text = "intURL";
            // 
            // extURLLabel
            // 
            this.extURLLabel.AutoSize = true;
            this.extURLLabel.Location = new System.Drawing.Point(7, 120);
            this.extURLLabel.Name = "extURLLabel";
            this.extURLLabel.Size = new System.Drawing.Size(43, 13);
            this.extURLLabel.TabIndex = 7;
            this.extURLLabel.Text = "extURL";
            // 
            // shortcutLabel
            // 
            this.shortcutLabel.AutoSize = true;
            this.shortcutLabel.Location = new System.Drawing.Point(7, 100);
            this.shortcutLabel.Name = "shortcutLabel";
            this.shortcutLabel.Size = new System.Drawing.Size(47, 13);
            this.shortcutLabel.TabIndex = 6;
            this.shortcutLabel.Text = "Shortcut";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(7, 80);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(35, 13);
            this.nameLabel.TabIndex = 5;
            this.nameLabel.Text = "Name";
            // 
            // propertiesLabel
            // 
            this.propertiesLabel.AutoSize = true;
            this.propertiesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.propertiesLabel.Location = new System.Drawing.Point(7, 59);
            this.propertiesLabel.Name = "propertiesLabel";
            this.propertiesLabel.Size = new System.Drawing.Size(64, 13);
            this.propertiesLabel.TabIndex = 4;
            this.propertiesLabel.Text = "Properties";
            // 
            // delEngineButton
            // 
            this.delEngineButton.Location = new System.Drawing.Point(193, 24);
            this.delEngineButton.Name = "delEngineButton";
            this.delEngineButton.Size = new System.Drawing.Size(50, 23);
            this.delEngineButton.TabIndex = 3;
            this.delEngineButton.Text = "Delete";
            this.delEngineButton.UseVisualStyleBackColor = true;
            // 
            // addEngineButton
            // 
            this.addEngineButton.Location = new System.Drawing.Point(137, 24);
            this.addEngineButton.Name = "addEngineButton";
            this.addEngineButton.Size = new System.Drawing.Size(50, 23);
            this.addEngineButton.TabIndex = 2;
            this.addEngineButton.Text = "Add";
            this.addEngineButton.UseVisualStyleBackColor = true;
            // 
            // enginesCombobox
            // 
            this.enginesCombobox.FormattingEnabled = true;
            this.enginesCombobox.Location = new System.Drawing.Point(10, 24);
            this.enginesCombobox.Name = "enginesCombobox";
            this.enginesCombobox.Size = new System.Drawing.Size(121, 21);
            this.enginesCombobox.TabIndex = 1;
            this.enginesCombobox.SelectedIndexChanged += new System.EventHandler(this.enginesCombobox_SelectedIndexChanged);
            // 
            // enginesLabel
            // 
            this.enginesLabel.AutoSize = true;
            this.enginesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enginesLabel.Location = new System.Drawing.Point(7, 7);
            this.enginesLabel.Name = "enginesLabel";
            this.enginesLabel.Size = new System.Drawing.Size(52, 13);
            this.enginesLabel.TabIndex = 0;
            this.enginesLabel.Text = "Engines";
            // 
            // OptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = global::Search.Properties.Resources.Search;
            this.MaximizeBox = false;
            this.Name = "OptionsForm";
            this.Text = "Options";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label globalHotkeyLabel;
        private System.Windows.Forms.TextBox modifierTextBox;
        private System.Windows.Forms.TextBox keyTextBox;
        private System.Windows.Forms.Button setGlobalModifiersButton;
        private System.Windows.Forms.Button setGlobalKeyButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label hotkeyLabel;
        private System.Windows.Forms.Label internLabel;
        private System.Windows.Forms.TextBox openInternTextBox;
        private System.Windows.Forms.TextBox openExternTextBox;
        private System.Windows.Forms.Label externLabel;
        private System.Windows.Forms.Button swapButton;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label enginesLabel;
        private System.Windows.Forms.ComboBox enginesCombobox;
        private System.Windows.Forms.Label hintLabel;
        private System.Windows.Forms.Label propertiesLabel;
        private System.Windows.Forms.Button delEngineButton;
        private System.Windows.Forms.Button addEngineButton;
        private System.Windows.Forms.Label intParamsLabel;
        private System.Windows.Forms.Label intURLLabel;
        private System.Windows.Forms.Label extURLLabel;
        private System.Windows.Forms.Label shortcutLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox intParamsTextBox;
        private System.Windows.Forms.TextBox intURLTextBox;
        private System.Windows.Forms.TextBox extURLTextBox;
        private System.Windows.Forms.TextBox shortcutTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.CheckBox defaultCheckBox;
    }
}