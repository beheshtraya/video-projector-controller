namespace ControlProjector
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.openFileFlash = new System.Windows.Forms.OpenFileDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.openFileLogo = new System.Windows.Forms.OpenFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flashObj = new AxShockwaveFlashObjects.AxShockwaveFlash();
            this.openFileVideo = new System.Windows.Forms.OpenFileDialog();
            this.tabVideo = new System.Windows.Forms.TabPage();
            this.lblVideos = new System.Windows.Forms.Label();
            this.btnVideo = new System.Windows.Forms.Button();
            this.btnPlayVideo = new System.Windows.Forms.Button();
            this.tabSubtitle = new System.Windows.Forms.TabPage();
            this.tabsSubtitles = new System.Windows.Forms.TabControl();
            this.tabSubMain = new System.Windows.Forms.TabPage();
            this.label13 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.btnPauseSubtitle = new System.Windows.Forms.Button();
            this.btnResumeSubtitle = new System.Windows.Forms.Button();
            this.btnRefreshSubtitle = new System.Windows.Forms.Button();
            this.btnApplySubtitle = new System.Windows.Forms.Button();
            this.lblComboSubText = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxSubSource = new System.Windows.Forms.ComboBox();
            this.comboBoxSubText = new System.Windows.Forms.ComboBox();
            this.chboxSubtitle = new System.Windows.Forms.CheckBox();
            this.chboxTitle = new System.Windows.Forms.CheckBox();
            this.tabSubText = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSubtitle = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.tabSubSave = new System.Windows.Forms.TabPage();
            this.btnSave = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.txtInputSubtitle = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtInputTitle = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtInputItem = new System.Windows.Forms.TextBox();
            this.tabSubSettings = new System.Windows.Forms.TabPage();
            this.btnLogoImage = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtx = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.tabFont = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblTitleFont = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnTitleFont = new System.Windows.Forms.Button();
            this.btnSaveFont = new System.Windows.Forms.Button();
            this.gboxSubtitle = new System.Windows.Forms.GroupBox();
            this.btnForeColor = new System.Windows.Forms.Button();
            this.lblSubtitleFont = new System.Windows.Forms.Label();
            this.btnBackColor = new System.Windows.Forms.Button();
            this.btnSubtitleFont = new System.Windows.Forms.Button();
            this.tabFlash = new System.Windows.Forms.TabPage();
            this.lblFlashFileName = new System.Windows.Forms.Label();
            this.btnStartFlash = new System.Windows.Forms.Button();
            this.btnBrowseFlash = new System.Windows.Forms.Button();
            this.tabs = new System.Windows.Forms.TabControl();
            this.tabPlayer = new System.Windows.Forms.TabPage();
            this.btnClosePlayer = new System.Windows.Forms.Button();
            this.fontDialogTitle = new System.Windows.Forms.FontDialog();
            this.fontDialogSubtitle = new System.Windows.Forms.FontDialog();
            this.colorDialogTitleBackground = new System.Windows.Forms.ColorDialog();
            this.colorDialogTitleForeground = new System.Windows.Forms.ColorDialog();
            this.colorDialogSubBackground = new System.Windows.Forms.ColorDialog();
            this.colorDialogSubForeground = new System.Windows.Forms.ColorDialog();
            this.txty = new System.Windows.Forms.NumericUpDown();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flashObj)).BeginInit();
            this.tabVideo.SuspendLayout();
            this.tabSubtitle.SuspendLayout();
            this.tabsSubtitles.SuspendLayout();
            this.tabSubMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.tabSubText.SuspendLayout();
            this.tabSubSave.SuspendLayout();
            this.tabSubSettings.SuspendLayout();
            this.tabFont.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gboxSubtitle.SuspendLayout();
            this.tabFlash.SuspendLayout();
            this.tabs.SuspendLayout();
            this.tabPlayer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txty)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileFlash
            // 
            resources.ApplyResources(this.openFileFlash, "openFileFlash");
            this.openFileFlash.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileFlash_FileOk);
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // openFileLogo
            // 
            this.openFileLogo.FileName = "openFileLogo";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.flashObj);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // flashObj
            // 
            resources.ApplyResources(this.flashObj, "flashObj");
            this.flashObj.Name = "flashObj";
            this.flashObj.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("flashObj.OcxState")));
            // 
            // openFileVideo
            // 
            this.openFileVideo.FileName = "openFileVideo";
            resources.ApplyResources(this.openFileVideo, "openFileVideo");
            this.openFileVideo.Multiselect = true;
            this.openFileVideo.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileVideo_FileOk);
            // 
            // tabVideo
            // 
            this.tabVideo.Controls.Add(this.lblVideos);
            this.tabVideo.Controls.Add(this.btnVideo);
            this.tabVideo.Controls.Add(this.btnPlayVideo);
            resources.ApplyResources(this.tabVideo, "tabVideo");
            this.tabVideo.Name = "tabVideo";
            this.tabVideo.UseVisualStyleBackColor = true;
            // 
            // lblVideos
            // 
            resources.ApplyResources(this.lblVideos, "lblVideos");
            this.lblVideos.Name = "lblVideos";
            // 
            // btnVideo
            // 
            resources.ApplyResources(this.btnVideo, "btnVideo");
            this.btnVideo.Name = "btnVideo";
            this.btnVideo.UseVisualStyleBackColor = true;
            this.btnVideo.Click += new System.EventHandler(this.btnVideo_Click);
            // 
            // btnPlayVideo
            // 
            resources.ApplyResources(this.btnPlayVideo, "btnPlayVideo");
            this.btnPlayVideo.Name = "btnPlayVideo";
            this.btnPlayVideo.UseVisualStyleBackColor = true;
            this.btnPlayVideo.Click += new System.EventHandler(this.btnPlayVideo_Click);
            // 
            // tabSubtitle
            // 
            this.tabSubtitle.Controls.Add(this.tabsSubtitles);
            resources.ApplyResources(this.tabSubtitle, "tabSubtitle");
            this.tabSubtitle.Name = "tabSubtitle";
            this.tabSubtitle.UseVisualStyleBackColor = true;
            // 
            // tabsSubtitles
            // 
            this.tabsSubtitles.Controls.Add(this.tabSubMain);
            this.tabsSubtitles.Controls.Add(this.tabSubText);
            this.tabsSubtitles.Controls.Add(this.tabSubSave);
            this.tabsSubtitles.Controls.Add(this.tabSubSettings);
            this.tabsSubtitles.Controls.Add(this.tabFont);
            resources.ApplyResources(this.tabsSubtitles, "tabsSubtitles");
            this.tabsSubtitles.Name = "tabsSubtitles";
            this.tabsSubtitles.SelectedIndex = 0;
            // 
            // tabSubMain
            // 
            this.tabSubMain.Controls.Add(this.label13);
            this.tabSubMain.Controls.Add(this.numericUpDown1);
            this.tabSubMain.Controls.Add(this.btnPauseSubtitle);
            this.tabSubMain.Controls.Add(this.btnResumeSubtitle);
            this.tabSubMain.Controls.Add(this.btnRefreshSubtitle);
            this.tabSubMain.Controls.Add(this.btnApplySubtitle);
            this.tabSubMain.Controls.Add(this.lblComboSubText);
            this.tabSubMain.Controls.Add(this.label7);
            this.tabSubMain.Controls.Add(this.comboBoxSubSource);
            this.tabSubMain.Controls.Add(this.comboBoxSubText);
            this.tabSubMain.Controls.Add(this.chboxSubtitle);
            this.tabSubMain.Controls.Add(this.chboxTitle);
            resources.ApplyResources(this.tabSubMain, "tabSubMain");
            this.tabSubMain.Name = "tabSubMain";
            this.tabSubMain.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            resources.ApplyResources(this.label13, "label13");
            this.label13.Name = "label13";
            // 
            // numericUpDown1
            // 
            resources.ApplyResources(this.numericUpDown1, "numericUpDown1");
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // btnPauseSubtitle
            // 
            resources.ApplyResources(this.btnPauseSubtitle, "btnPauseSubtitle");
            this.btnPauseSubtitle.Name = "btnPauseSubtitle";
            this.btnPauseSubtitle.UseVisualStyleBackColor = true;
            this.btnPauseSubtitle.Click += new System.EventHandler(this.btnPauseSubtitle_Click);
            // 
            // btnResumeSubtitle
            // 
            resources.ApplyResources(this.btnResumeSubtitle, "btnResumeSubtitle");
            this.btnResumeSubtitle.Name = "btnResumeSubtitle";
            this.btnResumeSubtitle.UseVisualStyleBackColor = true;
            this.btnResumeSubtitle.Click += new System.EventHandler(this.btnResumeSubtitle_Click);
            // 
            // btnRefreshSubtitle
            // 
            resources.ApplyResources(this.btnRefreshSubtitle, "btnRefreshSubtitle");
            this.btnRefreshSubtitle.Name = "btnRefreshSubtitle";
            this.btnRefreshSubtitle.UseVisualStyleBackColor = true;
            this.btnRefreshSubtitle.Click += new System.EventHandler(this.btnRefreshSubtitle_Click);
            // 
            // btnApplySubtitle
            // 
            resources.ApplyResources(this.btnApplySubtitle, "btnApplySubtitle");
            this.btnApplySubtitle.Name = "btnApplySubtitle";
            this.btnApplySubtitle.UseVisualStyleBackColor = true;
            this.btnApplySubtitle.Click += new System.EventHandler(this.btnApplySubtitle_Click);
            // 
            // lblComboSubText
            // 
            resources.ApplyResources(this.lblComboSubText, "lblComboSubText");
            this.lblComboSubText.Name = "lblComboSubText";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // comboBoxSubSource
            // 
            this.comboBoxSubSource.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSubSource.FormattingEnabled = true;
            this.comboBoxSubSource.Items.AddRange(new object[] {
            resources.GetString("comboBoxSubSource.Items"),
            resources.GetString("comboBoxSubSource.Items1")});
            resources.ApplyResources(this.comboBoxSubSource, "comboBoxSubSource");
            this.comboBoxSubSource.Name = "comboBoxSubSource";
            this.comboBoxSubSource.SelectedIndexChanged += new System.EventHandler(this.comboBoxSubSource_SelectedIndexChanged);
            // 
            // comboBoxSubText
            // 
            this.comboBoxSubText.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSubText.FormattingEnabled = true;
            resources.ApplyResources(this.comboBoxSubText, "comboBoxSubText");
            this.comboBoxSubText.Name = "comboBoxSubText";
            // 
            // chboxSubtitle
            // 
            resources.ApplyResources(this.chboxSubtitle, "chboxSubtitle");
            this.chboxSubtitle.Checked = true;
            this.chboxSubtitle.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chboxSubtitle.Name = "chboxSubtitle";
            this.chboxSubtitle.UseVisualStyleBackColor = true;
            // 
            // chboxTitle
            // 
            resources.ApplyResources(this.chboxTitle, "chboxTitle");
            this.chboxTitle.Checked = true;
            this.chboxTitle.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chboxTitle.Name = "chboxTitle";
            this.chboxTitle.UseVisualStyleBackColor = true;
            // 
            // tabSubText
            // 
            this.tabSubText.Controls.Add(this.label9);
            this.tabSubText.Controls.Add(this.label8);
            this.tabSubText.Controls.Add(this.txtSubtitle);
            this.tabSubText.Controls.Add(this.txtTitle);
            resources.ApplyResources(this.tabSubText, "tabSubText");
            this.tabSubText.Name = "tabSubText";
            this.tabSubText.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // txtSubtitle
            // 
            resources.ApplyResources(this.txtSubtitle, "txtSubtitle");
            this.txtSubtitle.Name = "txtSubtitle";
            // 
            // txtTitle
            // 
            resources.ApplyResources(this.txtTitle, "txtTitle");
            this.txtTitle.Name = "txtTitle";
            // 
            // tabSubSave
            // 
            this.tabSubSave.Controls.Add(this.btnSave);
            this.tabSubSave.Controls.Add(this.label12);
            this.tabSubSave.Controls.Add(this.txtInputSubtitle);
            this.tabSubSave.Controls.Add(this.label11);
            this.tabSubSave.Controls.Add(this.txtInputTitle);
            this.tabSubSave.Controls.Add(this.label10);
            this.tabSubSave.Controls.Add(this.txtInputItem);
            resources.ApplyResources(this.tabSubSave, "tabSubSave");
            this.tabSubSave.Name = "tabSubSave";
            this.tabSubSave.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            resources.ApplyResources(this.btnSave, "btnSave");
            this.btnSave.Name = "btnSave";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label12
            // 
            resources.ApplyResources(this.label12, "label12");
            this.label12.Name = "label12";
            // 
            // txtInputSubtitle
            // 
            resources.ApplyResources(this.txtInputSubtitle, "txtInputSubtitle");
            this.txtInputSubtitle.Name = "txtInputSubtitle";
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.Name = "label11";
            // 
            // txtInputTitle
            // 
            resources.ApplyResources(this.txtInputTitle, "txtInputTitle");
            this.txtInputTitle.Name = "txtInputTitle";
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // txtInputItem
            // 
            resources.ApplyResources(this.txtInputItem, "txtInputItem");
            this.txtInputItem.Name = "txtInputItem";
            // 
            // tabSubSettings
            // 
            this.tabSubSettings.Controls.Add(this.txty);
            this.tabSubSettings.Controls.Add(this.btnLogoImage);
            this.tabSubSettings.Controls.Add(this.label1);
            this.tabSubSettings.Controls.Add(this.label4);
            this.tabSubSettings.Controls.Add(this.txtx);
            this.tabSubSettings.Controls.Add(this.label5);
            this.tabSubSettings.Controls.Add(this.label6);
            this.tabSubSettings.Controls.Add(this.label2);
            this.tabSubSettings.Controls.Add(this.txtHeight);
            this.tabSubSettings.Controls.Add(this.label3);
            this.tabSubSettings.Controls.Add(this.txtWidth);
            resources.ApplyResources(this.tabSubSettings, "tabSubSettings");
            this.tabSubSettings.Name = "tabSubSettings";
            this.tabSubSettings.UseVisualStyleBackColor = true;
            // 
            // btnLogoImage
            // 
            resources.ApplyResources(this.btnLogoImage, "btnLogoImage");
            this.btnLogoImage.Name = "btnLogoImage";
            this.btnLogoImage.UseVisualStyleBackColor = true;
            this.btnLogoImage.Click += new System.EventHandler(this.btnLogoImage_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // txtx
            // 
            resources.ApplyResources(this.txtx, "txtx");
            this.txtx.Name = "txtx";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // txtHeight
            // 
            resources.ApplyResources(this.txtHeight, "txtHeight");
            this.txtHeight.Name = "txtHeight";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // txtWidth
            // 
            resources.ApplyResources(this.txtWidth, "txtWidth");
            this.txtWidth.Name = "txtWidth";
            // 
            // tabFont
            // 
            this.tabFont.Controls.Add(this.groupBox1);
            this.tabFont.Controls.Add(this.btnSaveFont);
            this.tabFont.Controls.Add(this.gboxSubtitle);
            resources.ApplyResources(this.tabFont, "tabFont");
            this.tabFont.Name = "tabFont";
            this.tabFont.UseVisualStyleBackColor = true;
            this.tabFont.Enter += new System.EventHandler(this.tabFont_Enter);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblTitleFont);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.btnTitleFont);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // lblTitleFont
            // 
            resources.ApplyResources(this.lblTitleFont, "lblTitleFont");
            this.lblTitleFont.Name = "lblTitleFont";
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            resources.ApplyResources(this.button2, "button2");
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnTitleFont
            // 
            resources.ApplyResources(this.btnTitleFont, "btnTitleFont");
            this.btnTitleFont.Name = "btnTitleFont";
            this.btnTitleFont.UseVisualStyleBackColor = true;
            this.btnTitleFont.Click += new System.EventHandler(this.btnTitleFont_Click);
            // 
            // btnSaveFont
            // 
            resources.ApplyResources(this.btnSaveFont, "btnSaveFont");
            this.btnSaveFont.Name = "btnSaveFont";
            this.btnSaveFont.UseVisualStyleBackColor = true;
            this.btnSaveFont.Click += new System.EventHandler(this.btnSaveFont_Click);
            // 
            // gboxSubtitle
            // 
            this.gboxSubtitle.Controls.Add(this.btnForeColor);
            this.gboxSubtitle.Controls.Add(this.lblSubtitleFont);
            this.gboxSubtitle.Controls.Add(this.btnBackColor);
            this.gboxSubtitle.Controls.Add(this.btnSubtitleFont);
            resources.ApplyResources(this.gboxSubtitle, "gboxSubtitle");
            this.gboxSubtitle.Name = "gboxSubtitle";
            this.gboxSubtitle.TabStop = false;
            // 
            // btnForeColor
            // 
            resources.ApplyResources(this.btnForeColor, "btnForeColor");
            this.btnForeColor.Name = "btnForeColor";
            this.btnForeColor.UseVisualStyleBackColor = true;
            this.btnForeColor.Click += new System.EventHandler(this.btnForeColor_Click);
            // 
            // lblSubtitleFont
            // 
            resources.ApplyResources(this.lblSubtitleFont, "lblSubtitleFont");
            this.lblSubtitleFont.Name = "lblSubtitleFont";
            this.lblSubtitleFont.Click += new System.EventHandler(this.label19_Click);
            // 
            // btnBackColor
            // 
            resources.ApplyResources(this.btnBackColor, "btnBackColor");
            this.btnBackColor.Name = "btnBackColor";
            this.btnBackColor.UseVisualStyleBackColor = true;
            this.btnBackColor.Click += new System.EventHandler(this.btnBackColor_Click);
            // 
            // btnSubtitleFont
            // 
            resources.ApplyResources(this.btnSubtitleFont, "btnSubtitleFont");
            this.btnSubtitleFont.Name = "btnSubtitleFont";
            this.btnSubtitleFont.UseVisualStyleBackColor = true;
            this.btnSubtitleFont.Click += new System.EventHandler(this.btnSubtitleFont_Click);
            // 
            // tabFlash
            // 
            this.tabFlash.Controls.Add(this.lblFlashFileName);
            this.tabFlash.Controls.Add(this.btnStartFlash);
            this.tabFlash.Controls.Add(this.btnBrowseFlash);
            resources.ApplyResources(this.tabFlash, "tabFlash");
            this.tabFlash.Name = "tabFlash";
            this.tabFlash.UseVisualStyleBackColor = true;
            // 
            // lblFlashFileName
            // 
            resources.ApplyResources(this.lblFlashFileName, "lblFlashFileName");
            this.lblFlashFileName.Name = "lblFlashFileName";
            // 
            // btnStartFlash
            // 
            resources.ApplyResources(this.btnStartFlash, "btnStartFlash");
            this.btnStartFlash.Name = "btnStartFlash";
            this.btnStartFlash.UseVisualStyleBackColor = true;
            this.btnStartFlash.Click += new System.EventHandler(this.btnStartFlash_Click);
            // 
            // btnBrowseFlash
            // 
            resources.ApplyResources(this.btnBrowseFlash, "btnBrowseFlash");
            this.btnBrowseFlash.Name = "btnBrowseFlash";
            this.btnBrowseFlash.UseVisualStyleBackColor = true;
            this.btnBrowseFlash.Click += new System.EventHandler(this.btnBrowseFlash_Click);
            // 
            // tabs
            // 
            this.tabs.Controls.Add(this.tabFlash);
            this.tabs.Controls.Add(this.tabSubtitle);
            this.tabs.Controls.Add(this.tabVideo);
            this.tabs.Controls.Add(this.tabPlayer);
            resources.ApplyResources(this.tabs, "tabs");
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            // 
            // tabPlayer
            // 
            this.tabPlayer.Controls.Add(this.btnClosePlayer);
            resources.ApplyResources(this.tabPlayer, "tabPlayer");
            this.tabPlayer.Name = "tabPlayer";
            this.tabPlayer.UseVisualStyleBackColor = true;
            // 
            // btnClosePlayer
            // 
            this.btnClosePlayer.BackColor = System.Drawing.Color.Transparent;
            this.btnClosePlayer.ForeColor = System.Drawing.SystemColors.ControlText;
            resources.ApplyResources(this.btnClosePlayer, "btnClosePlayer");
            this.btnClosePlayer.Name = "btnClosePlayer";
            this.btnClosePlayer.UseVisualStyleBackColor = false;
            this.btnClosePlayer.Click += new System.EventHandler(this.btnClosePlayer_Click);
            // 
            // fontDialogTitle
            // 
            this.fontDialogTitle.Apply += new System.EventHandler(this.fontDialogTitle_Apply);
            // 
            // fontDialogSubtitle
            // 
            this.fontDialogSubtitle.ShowColor = true;
            this.fontDialogSubtitle.Apply += new System.EventHandler(this.fontDialogSubtitle_Apply);
            // 
            // colorDialogTitleBackground
            // 
            this.colorDialogTitleBackground.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.colorDialogTitleBackground.FullOpen = true;
            // 
            // colorDialogSubBackground
            // 
            this.colorDialogSubBackground.Color = System.Drawing.Color.White;
            // 
            // txty
            // 
            resources.ApplyResources(this.txty, "txty");
            this.txty.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.txty.Name = "txty";
            this.txty.ValueChanged += new System.EventHandler(this.txty_ValueChanged);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tabs);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.flashObj)).EndInit();
            this.tabVideo.ResumeLayout(false);
            this.tabVideo.PerformLayout();
            this.tabSubtitle.ResumeLayout(false);
            this.tabsSubtitles.ResumeLayout(false);
            this.tabSubMain.ResumeLayout(false);
            this.tabSubMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.tabSubText.ResumeLayout(false);
            this.tabSubText.PerformLayout();
            this.tabSubSave.ResumeLayout(false);
            this.tabSubSave.PerformLayout();
            this.tabSubSettings.ResumeLayout(false);
            this.tabSubSettings.PerformLayout();
            this.tabFont.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gboxSubtitle.ResumeLayout(false);
            this.gboxSubtitle.PerformLayout();
            this.tabFlash.ResumeLayout(false);
            this.tabFlash.PerformLayout();
            this.tabs.ResumeLayout(false);
            this.tabPlayer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txty)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileFlash;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.OpenFileDialog openFileLogo;
        private System.Windows.Forms.Panel panel1;
        private AxShockwaveFlashObjects.AxShockwaveFlash flashObj;
        private System.Windows.Forms.OpenFileDialog openFileVideo;
        private System.Windows.Forms.TabPage tabVideo;
        private System.Windows.Forms.Button btnVideo;
        private System.Windows.Forms.Button btnPlayVideo;
        private System.Windows.Forms.TabPage tabSubtitle;
        private System.Windows.Forms.Button btnLogoImage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtx;
        private System.Windows.Forms.CheckBox chboxSubtitle;
        private System.Windows.Forms.TextBox txtSubtitle;
        private System.Windows.Forms.ComboBox comboBoxSubText;
        private System.Windows.Forms.CheckBox chboxTitle;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TabPage tabFlash;
        private System.Windows.Forms.Button btnStartFlash;
        private System.Windows.Forms.Button btnBrowseFlash;
        private System.Windows.Forms.TabControl tabs;
        private System.Windows.Forms.Label lblFlashFileName;
        private System.Windows.Forms.TabControl tabsSubtitles;
        private System.Windows.Forms.TabPage tabSubMain;
        private System.Windows.Forms.TabPage tabSubText;
        private System.Windows.Forms.TabPage tabSubSave;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtInputSubtitle;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtInputTitle;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtInputItem;
        private System.Windows.Forms.TabPage tabSubSettings;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxSubSource;
        private System.Windows.Forms.Label lblComboSubText;
        private System.Windows.Forms.Button btnApplySubtitle;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnRefreshSubtitle;
        private System.Windows.Forms.Button btnPauseSubtitle;
        private System.Windows.Forms.Button btnResumeSubtitle;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TabPage tabPlayer;
        private System.Windows.Forms.Button btnClosePlayer;
        private System.Windows.Forms.Label lblVideos;
        private System.Windows.Forms.TabPage tabFont;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblTitleFont;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnTitleFont;
        private System.Windows.Forms.Button btnSaveFont;
        private System.Windows.Forms.GroupBox gboxSubtitle;
        private System.Windows.Forms.Button btnForeColor;
        private System.Windows.Forms.Label lblSubtitleFont;
        private System.Windows.Forms.Button btnBackColor;
        private System.Windows.Forms.Button btnSubtitleFont;
        private System.Windows.Forms.FontDialog fontDialogTitle;
        private System.Windows.Forms.FontDialog fontDialogSubtitle;
        private System.Windows.Forms.ColorDialog colorDialogTitleBackground;
        private System.Windows.Forms.ColorDialog colorDialogTitleForeground;
        private System.Windows.Forms.ColorDialog colorDialogSubBackground;
        private System.Windows.Forms.ColorDialog colorDialogSubForeground;
        private System.Windows.Forms.NumericUpDown txty;
    }
}

