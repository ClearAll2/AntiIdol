namespace AntiIdol
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageMain = new System.Windows.Forms.TabPage();
            this.groupBoxAutoKey = new System.Windows.Forms.GroupBox();
            this.comboBoxKey2Press = new System.Windows.Forms.ComboBox();
            this.numericUpDownIntervalAK = new System.Windows.Forms.NumericUpDown();
            this.labelIntervalAK = new System.Windows.Forms.Label();
            this.labelKey2Press = new System.Windows.Forms.Label();
            this.labelIntructAK = new System.Windows.Forms.Label();
            this.checkBoxAutoKey = new System.Windows.Forms.CheckBox();
            this.groupBoxAutoMouse = new System.Windows.Forms.GroupBox();
            this.numericUpDownIntervalAM = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownPixelNo = new System.Windows.Forms.NumericUpDown();
            this.labelIntervalAM = new System.Windows.Forms.Label();
            this.labelPixelMove = new System.Windows.Forms.Label();
            this.labelIntructAM = new System.Windows.Forms.Label();
            this.checkBoxAutoMouse = new System.Windows.Forms.CheckBox();
            this.tabPageSetting = new System.Windows.Forms.TabPage();
            this.groupBoxSettings = new System.Windows.Forms.GroupBox();
            this.checkBoxRunAtStartup = new System.Windows.Forms.CheckBox();
            this.groupBoxTrayOption = new System.Windows.Forms.GroupBox();
            this.labelIntructTrayIcon = new System.Windows.Forms.Label();
            this.comboBoxRightClickTray = new System.Windows.Forms.ComboBox();
            this.comboBoxMidClickTray = new System.Windows.Forms.ComboBox();
            this.comboBoxLeftClickTray = new System.Windows.Forms.ComboBox();
            this.labelRightClickTrayIcon = new System.Windows.Forms.Label();
            this.labelMidClickTrayIcon = new System.Windows.Forms.Label();
            this.labelLeftClickTray = new System.Windows.Forms.Label();
            this.checkBoxTrayIcon = new System.Windows.Forms.CheckBox();
            this.tabPageAbout = new System.Windows.Forms.TabPage();
            this.notifyIconTray = new System.Windows.Forms.NotifyIcon(this.components);
            this.timerAutoKey = new System.Windows.Forms.Timer(this.components);
            this.timerAutoMouse = new System.Windows.Forms.Timer(this.components);
            this.labelCredit = new System.Windows.Forms.Label();
            this.labelCompanyName = new System.Windows.Forms.Label();
            this.labelCopyright = new System.Windows.Forms.Label();
            this.labelVersion = new System.Windows.Forms.Label();
            this.labelProductName = new System.Windows.Forms.Label();
            this.tabControlMain.SuspendLayout();
            this.tabPageMain.SuspendLayout();
            this.groupBoxAutoKey.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIntervalAK)).BeginInit();
            this.groupBoxAutoMouse.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIntervalAM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPixelNo)).BeginInit();
            this.tabPageSetting.SuspendLayout();
            this.groupBoxSettings.SuspendLayout();
            this.groupBoxTrayOption.SuspendLayout();
            this.tabPageAbout.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPageMain);
            this.tabControlMain.Controls.Add(this.tabPageSetting);
            this.tabControlMain.Controls.Add(this.tabPageAbout);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Location = new System.Drawing.Point(0, 0);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(737, 358);
            this.tabControlMain.TabIndex = 0;
            // 
            // tabPageMain
            // 
            this.tabPageMain.Controls.Add(this.groupBoxAutoKey);
            this.tabPageMain.Controls.Add(this.groupBoxAutoMouse);
            this.tabPageMain.Location = new System.Drawing.Point(4, 26);
            this.tabPageMain.Name = "tabPageMain";
            this.tabPageMain.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMain.Size = new System.Drawing.Size(729, 328);
            this.tabPageMain.TabIndex = 0;
            this.tabPageMain.Text = "Anti Idol";
            this.tabPageMain.UseVisualStyleBackColor = true;
            // 
            // groupBoxAutoKey
            // 
            this.groupBoxAutoKey.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.groupBoxAutoKey.Controls.Add(this.comboBoxKey2Press);
            this.groupBoxAutoKey.Controls.Add(this.numericUpDownIntervalAK);
            this.groupBoxAutoKey.Controls.Add(this.labelIntervalAK);
            this.groupBoxAutoKey.Controls.Add(this.labelKey2Press);
            this.groupBoxAutoKey.Controls.Add(this.labelIntructAK);
            this.groupBoxAutoKey.Controls.Add(this.checkBoxAutoKey);
            this.groupBoxAutoKey.Location = new System.Drawing.Point(365, 6);
            this.groupBoxAutoKey.Name = "groupBoxAutoKey";
            this.groupBoxAutoKey.Size = new System.Drawing.Size(356, 314);
            this.groupBoxAutoKey.TabIndex = 1;
            this.groupBoxAutoKey.TabStop = false;
            this.groupBoxAutoKey.Text = "Auto Key";
            // 
            // comboBoxKey2Press
            // 
            this.comboBoxKey2Press.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxKey2Press.FormattingEnabled = true;
            this.comboBoxKey2Press.Location = new System.Drawing.Point(181, 231);
            this.comboBoxKey2Press.Name = "comboBoxKey2Press";
            this.comboBoxKey2Press.Size = new System.Drawing.Size(149, 25);
            this.comboBoxKey2Press.TabIndex = 8;
            // 
            // numericUpDownIntervalAK
            // 
            this.numericUpDownIntervalAK.Location = new System.Drawing.Point(241, 270);
            this.numericUpDownIntervalAK.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numericUpDownIntervalAK.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownIntervalAK.Name = "numericUpDownIntervalAK";
            this.numericUpDownIntervalAK.Size = new System.Drawing.Size(89, 25);
            this.numericUpDownIntervalAK.TabIndex = 6;
            this.numericUpDownIntervalAK.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownIntervalAK.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // labelIntervalAK
            // 
            this.labelIntervalAK.AutoSize = true;
            this.labelIntervalAK.Location = new System.Drawing.Point(34, 272);
            this.labelIntervalAK.Name = "labelIntervalAK";
            this.labelIntervalAK.Size = new System.Drawing.Size(182, 17);
            this.labelIntervalAK.TabIndex = 7;
            this.labelIntervalAK.Text = "Move mouse every (seconds):";
            // 
            // labelKey2Press
            // 
            this.labelKey2Press.AutoSize = true;
            this.labelKey2Press.Location = new System.Drawing.Point(34, 234);
            this.labelKey2Press.Name = "labelKey2Press";
            this.labelKey2Press.Size = new System.Drawing.Size(84, 17);
            this.labelKey2Press.TabIndex = 6;
            this.labelKey2Press.Text = "Key to press:";
            // 
            // labelIntructAK
            // 
            this.labelIntructAK.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelIntructAK.Location = new System.Drawing.Point(34, 60);
            this.labelIntructAK.Name = "labelIntructAK";
            this.labelIntructAK.Size = new System.Drawing.Size(296, 159);
            this.labelIntructAK.TabIndex = 6;
            this.labelIntructAK.Text = "When enabled, this service will simulate a periodical user input by automatically" +
    " pressing a key.";
            this.labelIntructAK.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // checkBoxAutoKey
            // 
            this.checkBoxAutoKey.AutoSize = true;
            this.checkBoxAutoKey.Location = new System.Drawing.Point(34, 36);
            this.checkBoxAutoKey.Name = "checkBoxAutoKey";
            this.checkBoxAutoKey.Size = new System.Drawing.Size(110, 21);
            this.checkBoxAutoKey.TabIndex = 6;
            this.checkBoxAutoKey.Text = "Enable service";
            this.checkBoxAutoKey.UseVisualStyleBackColor = true;
            this.checkBoxAutoKey.CheckedChanged += new System.EventHandler(this.checkBoxAutoKey_CheckedChanged);
            // 
            // groupBoxAutoMouse
            // 
            this.groupBoxAutoMouse.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.groupBoxAutoMouse.Controls.Add(this.numericUpDownIntervalAM);
            this.groupBoxAutoMouse.Controls.Add(this.numericUpDownPixelNo);
            this.groupBoxAutoMouse.Controls.Add(this.labelIntervalAM);
            this.groupBoxAutoMouse.Controls.Add(this.labelPixelMove);
            this.groupBoxAutoMouse.Controls.Add(this.labelIntructAM);
            this.groupBoxAutoMouse.Controls.Add(this.checkBoxAutoMouse);
            this.groupBoxAutoMouse.Location = new System.Drawing.Point(8, 6);
            this.groupBoxAutoMouse.Name = "groupBoxAutoMouse";
            this.groupBoxAutoMouse.Size = new System.Drawing.Size(351, 314);
            this.groupBoxAutoMouse.TabIndex = 0;
            this.groupBoxAutoMouse.TabStop = false;
            this.groupBoxAutoMouse.Text = "Auto Mouse";
            // 
            // numericUpDownIntervalAM
            // 
            this.numericUpDownIntervalAM.Location = new System.Drawing.Point(234, 270);
            this.numericUpDownIntervalAM.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numericUpDownIntervalAM.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownIntervalAM.Name = "numericUpDownIntervalAM";
            this.numericUpDownIntervalAM.Size = new System.Drawing.Size(89, 25);
            this.numericUpDownIntervalAM.TabIndex = 5;
            this.numericUpDownIntervalAM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownIntervalAM.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // numericUpDownPixelNo
            // 
            this.numericUpDownPixelNo.Location = new System.Drawing.Point(234, 232);
            this.numericUpDownPixelNo.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDownPixelNo.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownPixelNo.Name = "numericUpDownPixelNo";
            this.numericUpDownPixelNo.Size = new System.Drawing.Size(89, 25);
            this.numericUpDownPixelNo.TabIndex = 4;
            this.numericUpDownPixelNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownPixelNo.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // labelIntervalAM
            // 
            this.labelIntervalAM.AutoSize = true;
            this.labelIntervalAM.Location = new System.Drawing.Point(27, 272);
            this.labelIntervalAM.Name = "labelIntervalAM";
            this.labelIntervalAM.Size = new System.Drawing.Size(182, 17);
            this.labelIntervalAM.TabIndex = 3;
            this.labelIntervalAM.Text = "Move mouse every (seconds):";
            // 
            // labelPixelMove
            // 
            this.labelPixelMove.AutoSize = true;
            this.labelPixelMove.Location = new System.Drawing.Point(27, 234);
            this.labelPixelMove.Name = "labelPixelMove";
            this.labelPixelMove.Size = new System.Drawing.Size(201, 17);
            this.labelPixelMove.TabIndex = 2;
            this.labelPixelMove.Text = "Number of pixel to move mouse:";
            // 
            // labelIntructAM
            // 
            this.labelIntructAM.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelIntructAM.Location = new System.Drawing.Point(27, 60);
            this.labelIntructAM.Name = "labelIntructAM";
            this.labelIntructAM.Size = new System.Drawing.Size(296, 159);
            this.labelIntructAM.TabIndex = 1;
            this.labelIntructAM.Text = resources.GetString("labelIntructAM.Text");
            this.labelIntructAM.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // checkBoxAutoMouse
            // 
            this.checkBoxAutoMouse.AutoSize = true;
            this.checkBoxAutoMouse.Location = new System.Drawing.Point(27, 36);
            this.checkBoxAutoMouse.Name = "checkBoxAutoMouse";
            this.checkBoxAutoMouse.Size = new System.Drawing.Size(110, 21);
            this.checkBoxAutoMouse.TabIndex = 0;
            this.checkBoxAutoMouse.Text = "Enable service";
            this.checkBoxAutoMouse.UseVisualStyleBackColor = true;
            this.checkBoxAutoMouse.CheckedChanged += new System.EventHandler(this.checkBoxAutoMouse_CheckedChanged);
            // 
            // tabPageSetting
            // 
            this.tabPageSetting.Controls.Add(this.groupBoxSettings);
            this.tabPageSetting.Controls.Add(this.groupBoxTrayOption);
            this.tabPageSetting.Location = new System.Drawing.Point(4, 24);
            this.tabPageSetting.Name = "tabPageSetting";
            this.tabPageSetting.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSetting.Size = new System.Drawing.Size(729, 330);
            this.tabPageSetting.TabIndex = 1;
            this.tabPageSetting.Text = "Settings";
            this.tabPageSetting.UseVisualStyleBackColor = true;
            // 
            // groupBoxSettings
            // 
            this.groupBoxSettings.Controls.Add(this.checkBoxRunAtStartup);
            this.groupBoxSettings.Location = new System.Drawing.Point(438, 6);
            this.groupBoxSettings.Name = "groupBoxSettings";
            this.groupBoxSettings.Size = new System.Drawing.Size(285, 314);
            this.groupBoxSettings.TabIndex = 1;
            this.groupBoxSettings.TabStop = false;
            this.groupBoxSettings.Text = "Settings";
            // 
            // checkBoxRunAtStartup
            // 
            this.checkBoxRunAtStartup.AutoSize = true;
            this.checkBoxRunAtStartup.Location = new System.Drawing.Point(27, 36);
            this.checkBoxRunAtStartup.Name = "checkBoxRunAtStartup";
            this.checkBoxRunAtStartup.Size = new System.Drawing.Size(166, 21);
            this.checkBoxRunAtStartup.TabIndex = 1;
            this.checkBoxRunAtStartup.Text = "Run at Windows startup";
            this.checkBoxRunAtStartup.UseVisualStyleBackColor = true;
            // 
            // groupBoxTrayOption
            // 
            this.groupBoxTrayOption.Controls.Add(this.labelIntructTrayIcon);
            this.groupBoxTrayOption.Controls.Add(this.comboBoxRightClickTray);
            this.groupBoxTrayOption.Controls.Add(this.comboBoxMidClickTray);
            this.groupBoxTrayOption.Controls.Add(this.comboBoxLeftClickTray);
            this.groupBoxTrayOption.Controls.Add(this.labelRightClickTrayIcon);
            this.groupBoxTrayOption.Controls.Add(this.labelMidClickTrayIcon);
            this.groupBoxTrayOption.Controls.Add(this.labelLeftClickTray);
            this.groupBoxTrayOption.Controls.Add(this.checkBoxTrayIcon);
            this.groupBoxTrayOption.Location = new System.Drawing.Point(8, 6);
            this.groupBoxTrayOption.Name = "groupBoxTrayOption";
            this.groupBoxTrayOption.Size = new System.Drawing.Size(424, 316);
            this.groupBoxTrayOption.TabIndex = 0;
            this.groupBoxTrayOption.TabStop = false;
            this.groupBoxTrayOption.Text = "Tray Icon Option";
            // 
            // labelIntructTrayIcon
            // 
            this.labelIntructTrayIcon.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelIntructTrayIcon.Location = new System.Drawing.Point(27, 60);
            this.labelIntructTrayIcon.Name = "labelIntructTrayIcon";
            this.labelIntructTrayIcon.Size = new System.Drawing.Size(359, 101);
            this.labelIntructTrayIcon.TabIndex = 7;
            this.labelIntructTrayIcon.Text = "Tray icon indicates what services Anti Idol are runnings.\r\n\r\nYou can also set act" +
    "ions when clicking on tray icon for fast switching state.";
            this.labelIntructTrayIcon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboBoxRightClickTray
            // 
            this.comboBoxRightClickTray.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRightClickTray.FormattingEnabled = true;
            this.comboBoxRightClickTray.Location = new System.Drawing.Point(245, 263);
            this.comboBoxRightClickTray.Name = "comboBoxRightClickTray";
            this.comboBoxRightClickTray.Size = new System.Drawing.Size(141, 25);
            this.comboBoxRightClickTray.TabIndex = 6;
            // 
            // comboBoxMidClickTray
            // 
            this.comboBoxMidClickTray.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMidClickTray.FormattingEnabled = true;
            this.comboBoxMidClickTray.Location = new System.Drawing.Point(245, 224);
            this.comboBoxMidClickTray.Name = "comboBoxMidClickTray";
            this.comboBoxMidClickTray.Size = new System.Drawing.Size(141, 25);
            this.comboBoxMidClickTray.TabIndex = 5;
            // 
            // comboBoxLeftClickTray
            // 
            this.comboBoxLeftClickTray.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLeftClickTray.FormattingEnabled = true;
            this.comboBoxLeftClickTray.Location = new System.Drawing.Point(245, 182);
            this.comboBoxLeftClickTray.Name = "comboBoxLeftClickTray";
            this.comboBoxLeftClickTray.Size = new System.Drawing.Size(141, 25);
            this.comboBoxLeftClickTray.TabIndex = 4;
            // 
            // labelRightClickTrayIcon
            // 
            this.labelRightClickTrayIcon.AutoSize = true;
            this.labelRightClickTrayIcon.Location = new System.Drawing.Point(27, 266);
            this.labelRightClickTrayIcon.Name = "labelRightClickTrayIcon";
            this.labelRightClickTrayIcon.Size = new System.Drawing.Size(163, 17);
            this.labelRightClickTrayIcon.TabIndex = 3;
            this.labelRightClickTrayIcon.Text = "Right-click tray icon action:";
            // 
            // labelMidClickTrayIcon
            // 
            this.labelMidClickTrayIcon.AutoSize = true;
            this.labelMidClickTrayIcon.Location = new System.Drawing.Point(27, 227);
            this.labelMidClickTrayIcon.Name = "labelMidClickTrayIcon";
            this.labelMidClickTrayIcon.Size = new System.Drawing.Size(174, 17);
            this.labelMidClickTrayIcon.TabIndex = 2;
            this.labelMidClickTrayIcon.Text = "Middle-click tray icon action:";
            // 
            // labelLeftClickTray
            // 
            this.labelLeftClickTray.AutoSize = true;
            this.labelLeftClickTray.Location = new System.Drawing.Point(27, 185);
            this.labelLeftClickTray.Name = "labelLeftClickTray";
            this.labelLeftClickTray.Size = new System.Drawing.Size(154, 17);
            this.labelLeftClickTray.TabIndex = 1;
            this.labelLeftClickTray.Text = "Left-click tray icon action:";
            // 
            // checkBoxTrayIcon
            // 
            this.checkBoxTrayIcon.AutoSize = true;
            this.checkBoxTrayIcon.Location = new System.Drawing.Point(27, 36);
            this.checkBoxTrayIcon.Name = "checkBoxTrayIcon";
            this.checkBoxTrayIcon.Size = new System.Drawing.Size(108, 21);
            this.checkBoxTrayIcon.TabIndex = 0;
            this.checkBoxTrayIcon.Text = "Hide tray icon";
            this.checkBoxTrayIcon.UseVisualStyleBackColor = true;
            this.checkBoxTrayIcon.CheckedChanged += new System.EventHandler(this.checkBoxTrayIcon_CheckedChanged);
            // 
            // tabPageAbout
            // 
            this.tabPageAbout.Controls.Add(this.labelCredit);
            this.tabPageAbout.Controls.Add(this.labelCompanyName);
            this.tabPageAbout.Controls.Add(this.labelCopyright);
            this.tabPageAbout.Controls.Add(this.labelVersion);
            this.tabPageAbout.Controls.Add(this.labelProductName);
            this.tabPageAbout.Location = new System.Drawing.Point(4, 26);
            this.tabPageAbout.Name = "tabPageAbout";
            this.tabPageAbout.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAbout.Size = new System.Drawing.Size(729, 328);
            this.tabPageAbout.TabIndex = 2;
            this.tabPageAbout.Text = "About";
            this.tabPageAbout.UseVisualStyleBackColor = true;
            // 
            // notifyIconTray
            // 
            this.notifyIconTray.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIconTray.Icon")));
            this.notifyIconTray.Text = "Idol/Idle";
            this.notifyIconTray.Visible = true;
            this.notifyIconTray.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIconTray_MouseClick);
            // 
            // timerAutoKey
            // 
            this.timerAutoKey.Tick += new System.EventHandler(this.timerAutoKey_Tick);
            // 
            // timerAutoMouse
            // 
            this.timerAutoMouse.Tick += new System.EventHandler(this.timerAutoMouse_Tick);
            // 
            // labelCredit
            // 
            this.labelCredit.Location = new System.Drawing.Point(208, 159);
            this.labelCredit.Name = "labelCredit";
            this.labelCredit.Size = new System.Drawing.Size(312, 132);
            this.labelCredit.TabIndex = 32;
            this.labelCredit.Text = "Icons made by Freepik from Flaticon.\r\nhttps://www.flaticon.com/authors/freepik\r\n\r" +
    "\nThis app is made possible by auto_mouse_mover project of ebellocchia.\r\nhttps://" +
    "github.com/ebellocchia/auto_mouse_mover";
            // 
            // labelCompanyName
            // 
            this.labelCompanyName.AutoSize = true;
            this.labelCompanyName.Location = new System.Drawing.Point(208, 121);
            this.labelCompanyName.Name = "labelCompanyName";
            this.labelCompanyName.Size = new System.Drawing.Size(63, 17);
            this.labelCompanyName.TabIndex = 31;
            this.labelCompanyName.Text = "Company";
            // 
            // labelCopyright
            // 
            this.labelCopyright.AutoSize = true;
            this.labelCopyright.Location = new System.Drawing.Point(208, 92);
            this.labelCopyright.Name = "labelCopyright";
            this.labelCopyright.Size = new System.Drawing.Size(65, 17);
            this.labelCopyright.TabIndex = 30;
            this.labelCopyright.Text = "Copyright";
            // 
            // labelVersion
            // 
            this.labelVersion.AutoSize = true;
            this.labelVersion.Location = new System.Drawing.Point(208, 65);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(51, 17);
            this.labelVersion.TabIndex = 29;
            this.labelVersion.Text = "Version";
            // 
            // labelProductName
            // 
            this.labelProductName.AutoSize = true;
            this.labelProductName.Location = new System.Drawing.Point(208, 38);
            this.labelProductName.Name = "labelProductName";
            this.labelProductName.Size = new System.Drawing.Size(92, 17);
            this.labelProductName.TabIndex = 28;
            this.labelProductName.Text = "Product Name";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(737, 358);
            this.Controls.Add(this.tabControlMain);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Anti Idol";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.tabControlMain.ResumeLayout(false);
            this.tabPageMain.ResumeLayout(false);
            this.groupBoxAutoKey.ResumeLayout(false);
            this.groupBoxAutoKey.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIntervalAK)).EndInit();
            this.groupBoxAutoMouse.ResumeLayout(false);
            this.groupBoxAutoMouse.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIntervalAM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPixelNo)).EndInit();
            this.tabPageSetting.ResumeLayout(false);
            this.groupBoxSettings.ResumeLayout(false);
            this.groupBoxSettings.PerformLayout();
            this.groupBoxTrayOption.ResumeLayout(false);
            this.groupBoxTrayOption.PerformLayout();
            this.tabPageAbout.ResumeLayout(false);
            this.tabPageAbout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControlMain;
        private TabPage tabPageMain;
        private TabPage tabPageSetting;
        private TabPage tabPageAbout;
        private GroupBox groupBoxAutoKey;
        private GroupBox groupBoxAutoMouse;
        private NumericUpDown numericUpDownIntervalAM;
        private NumericUpDown numericUpDownPixelNo;
        private Label labelIntervalAM;
        private Label labelPixelMove;
        private Label labelIntructAM;
        private CheckBox checkBoxAutoMouse;
        private ComboBox comboBoxKey2Press;
        private NumericUpDown numericUpDownIntervalAK;
        private Label labelIntervalAK;
        private Label labelKey2Press;
        private Label labelIntructAK;
        private CheckBox checkBoxAutoKey;
        private NotifyIcon notifyIconTray;
        private System.Windows.Forms.Timer timerAutoKey;
        private System.Windows.Forms.Timer timerAutoMouse;
        private GroupBox groupBoxTrayOption;
        private Label labelRightClickTrayIcon;
        private Label labelMidClickTrayIcon;
        private Label labelLeftClickTray;
        private CheckBox checkBoxTrayIcon;
        private Label labelIntructTrayIcon;
        private ComboBox comboBoxRightClickTray;
        private ComboBox comboBoxMidClickTray;
        private ComboBox comboBoxLeftClickTray;
        private GroupBox groupBoxSettings;
        private CheckBox checkBoxRunAtStartup;
        private Label labelCredit;
        private Label labelCompanyName;
        private Label labelCopyright;
        private Label labelVersion;
        private Label labelProductName;
    }
}