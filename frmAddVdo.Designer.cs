namespace WebVideoDownloader_2
{
    partial class frmAddVdo
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.vdo_panel = new System.Windows.Forms.Panel();
            this.comboDelsound = new System.Windows.Forms.ComboBox();
            this.comboAspectRatio = new System.Windows.Forms.ComboBox();
            this.comboFrameRate = new System.Windows.Forms.ComboBox();
            this.comboVdoBitrate = new System.Windows.Forms.ComboBox();
            this.comboResolution = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.sound_panel = new System.Windows.Forms.Panel();
            this.comboHZSound = new System.Windows.Forms.ComboBox();
            this.comboSoundType = new System.Windows.Forms.ComboBox();
            this.comboBitrateSound = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboFormatType = new System.Windows.Forms.ComboBox();
            this.radioVdoCustom = new System.Windows.Forms.RadioButton();
            this.radioVdoDefault = new System.Windows.Forms.RadioButton();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.vdo_panel.SuspendLayout();
            this.sound_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Youtube Link :";
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(103, 17);
            this.txtUrl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(303, 22);
            this.txtUrl.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.vdo_panel);
            this.groupBox1.Controls.Add(this.sound_panel);
            this.groupBox1.Controls.Add(this.comboFormatType);
            this.groupBox1.Controls.Add(this.radioVdoCustom);
            this.groupBox1.Controls.Add(this.radioVdoDefault);
            this.groupBox1.Location = new System.Drawing.Point(12, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(391, 296);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "รูปแบบการบันทึก";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // vdo_panel
            // 
            this.vdo_panel.Controls.Add(this.comboDelsound);
            this.vdo_panel.Controls.Add(this.comboAspectRatio);
            this.vdo_panel.Controls.Add(this.comboFrameRate);
            this.vdo_panel.Controls.Add(this.comboVdoBitrate);
            this.vdo_panel.Controls.Add(this.comboResolution);
            this.vdo_panel.Controls.Add(this.label9);
            this.vdo_panel.Controls.Add(this.label8);
            this.vdo_panel.Controls.Add(this.label7);
            this.vdo_panel.Controls.Add(this.label6);
            this.vdo_panel.Controls.Add(this.label5);
            this.vdo_panel.Location = new System.Drawing.Point(24, 118);
            this.vdo_panel.Name = "vdo_panel";
            this.vdo_panel.Size = new System.Drawing.Size(349, 162);
            this.vdo_panel.TabIndex = 4;
            this.vdo_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.vdo_panel_Paint);
            // 
            // comboDelsound
            // 
            this.comboDelsound.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboDelsound.FormattingEnabled = true;
            this.comboDelsound.Items.AddRange(new object[] {
            "ไม่ใช่",
            "ใช่"});
            this.comboDelsound.Location = new System.Drawing.Point(111, 123);
            this.comboDelsound.Name = "comboDelsound";
            this.comboDelsound.Size = new System.Drawing.Size(220, 22);
            this.comboDelsound.TabIndex = 13;
            // 
            // comboAspectRatio
            // 
            this.comboAspectRatio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboAspectRatio.FormattingEnabled = true;
            this.comboAspectRatio.Items.AddRange(new object[] {
            "Auto",
            "1:1",
            "3:2",
            "4:3",
            "5:4",
            "16:9",
            "16:10"});
            this.comboAspectRatio.Location = new System.Drawing.Point(111, 95);
            this.comboAspectRatio.Name = "comboAspectRatio";
            this.comboAspectRatio.Size = new System.Drawing.Size(220, 22);
            this.comboAspectRatio.TabIndex = 13;
            // 
            // comboFrameRate
            // 
            this.comboFrameRate.FormattingEnabled = true;
            this.comboFrameRate.Items.AddRange(new object[] {
            "Auto",
            "12",
            "15",
            "18",
            "20",
            "24",
            "25",
            "29.97",
            "30"});
            this.comboFrameRate.Location = new System.Drawing.Point(111, 68);
            this.comboFrameRate.Name = "comboFrameRate";
            this.comboFrameRate.Size = new System.Drawing.Size(220, 22);
            this.comboFrameRate.TabIndex = 12;
            this.comboFrameRate.SelectedIndexChanged += new System.EventHandler(this.comboFrameRate_SelectedIndexChanged);
            this.comboFrameRate.KeyUp += new System.Windows.Forms.KeyEventHandler(this.comboFrameRate_KeyUp);
            // 
            // comboVdoBitrate
            // 
            this.comboVdoBitrate.FormattingEnabled = true;
            this.comboVdoBitrate.Items.AddRange(new object[] {
            "Auto",
            "128",
            "256",
            "384",
            "512",
            "768",
            "800",
            "1000",
            "1024",
            "1200",
            "1600",
            "2000",
            "2400",
            "5000",
            "10000",
            "16000"});
            this.comboVdoBitrate.Location = new System.Drawing.Point(111, 40);
            this.comboVdoBitrate.Name = "comboVdoBitrate";
            this.comboVdoBitrate.Size = new System.Drawing.Size(220, 22);
            this.comboVdoBitrate.TabIndex = 11;
            this.comboVdoBitrate.KeyUp += new System.Windows.Forms.KeyEventHandler(this.comboVdoBitrate_KeyUp);
            // 
            // comboResolution
            // 
            this.comboResolution.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboResolution.FormattingEnabled = true;
            this.comboResolution.Items.AddRange(new object[] {
            "Auto",
            "128 x 128      Mobile Standard",
            "160 x 128      Mobile Standard",
            "160 x 160      Mobile Standard",
            "208 x 176      Mobile Standard",
            "208 x 208      Mobile Standard",
            "220 x 176      Mobile Standard",
            "240 x 180      Mobile Standard",
            "256 x 256      Mobile Standard",
            "280 x 220      Mobile Standard",
            "288 x 160      Mobile Standard",
            "320 x 240      Mobile Standard",
            "320 x 256      Mobile Standard",
            "320 x 320      Mobile Standard",
            "345 x 240      Mobile Standard",
            "384 x 234      Mobile Standard",
            "400 x 240      Mobile Standard",
            "416 x 352      Mobile Standard",
            "480 x 234      Mobile Standard",
            "480 x 272      Mobile Standard",
            "480 x 320      Mobile Standard",
            "640 x 480      Mobile Standard",
            "800 x 480      Mobile Standard",
            "800 x 600      Mobile Standard",
            "960 x 540      Mobile Standard",
            "320 x 200      CGA",
            "320 x 240      QVGA",
            "640 x 480      VGA",
            "800 x 600      SVGA",
            "854 x 480      WVGA",
            "1024 x 768    XGA",
            "1152 x 768    XGA+",
            "1280 x 800    WXGA",
            "1280 x 854    WXGA",
            "1280 x 960    WXGA",
            "1280 x 1024  SXGA",
            "1400 x 1050  SXGA+",
            "1440 x 900    WXGA",
            "1440 x 960    WXGA",
            "1600 x 1200  UXGA",
            "1680 x 1050  WSXGA+",
            "1920 x 1200  WUXGA",
            "2048 x 1536  QXGA",
            "2560 x 1600  WQXGA",
            "2560 x 2048  QSXGA",
            "176 x 144      QCIF",
            "352 x 288      CIF",
            "720 x 480      NTSC (DV)",
            "720 x 486      NTSC (D1)",
            "720 x 540      NTSC (4:3)",
            "720 x 576      PAL (D1/DV)",
            "768 x 576      PAL (4:3)",
            "864 x 486      NTSC Widescreen",
            "960 x 720      DVCPRO",
            "960 x 720      HD 720",
            "1024 x 576    PAL Widescreen",
            "1280 x 720    HDTV 720",
            "1366 x 768    HDTV 720",
            "1280 x 1080  DVCPRO",
            "1280 x 1080  HD 1080",
            "1440 x 1080  HDV",
            "1440 x 1080  AVCHD",
            "1440 x 1024  D4",
            "1920 x 1080  HDTV 1080",
            "2880 x 2048  D16"});
            this.comboResolution.Location = new System.Drawing.Point(111, 12);
            this.comboResolution.Name = "comboResolution";
            this.comboResolution.Size = new System.Drawing.Size(220, 22);
            this.comboResolution.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(51, 126);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 14);
            this.label9.TabIndex = 9;
            this.label9.Text = "ลบเสียง :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 98);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 14);
            this.label8.TabIndex = 8;
            this.label8.Text = "Aspect Ratio :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(51, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 14);
            this.label7.TabIndex = 7;
            this.label7.Text = "เฟรมเรต :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 14);
            this.label6.TabIndex = 6;
            this.label6.Text = "อัตราบิต (KB/s) :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 14);
            this.label5.TabIndex = 0;
            this.label5.Text = "ความละเอียด :";
            // 
            // sound_panel
            // 
            this.sound_panel.Controls.Add(this.comboHZSound);
            this.sound_panel.Controls.Add(this.comboSoundType);
            this.sound_panel.Controls.Add(this.comboBitrateSound);
            this.sound_panel.Controls.Add(this.label4);
            this.sound_panel.Controls.Add(this.label3);
            this.sound_panel.Controls.Add(this.label2);
            this.sound_panel.Location = new System.Drawing.Point(24, 118);
            this.sound_panel.Name = "sound_panel";
            this.sound_panel.Size = new System.Drawing.Size(349, 162);
            this.sound_panel.TabIndex = 3;
            // 
            // comboHZSound
            // 
            this.comboHZSound.FormattingEnabled = true;
            this.comboHZSound.Items.AddRange(new object[] {
            "Auto",
            "4000",
            "6000",
            "8000",
            "16000",
            "22000",
            "22050",
            "24000",
            "32000",
            "40000",
            "44100",
            "48000"});
            this.comboHZSound.Location = new System.Drawing.Point(112, 71);
            this.comboHZSound.Name = "comboHZSound";
            this.comboHZSound.Size = new System.Drawing.Size(220, 22);
            this.comboHZSound.TabIndex = 10;
            this.comboHZSound.KeyUp += new System.Windows.Forms.KeyEventHandler(this.comboHZSound_KeyUp);
            // 
            // comboSoundType
            // 
            this.comboSoundType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSoundType.FormattingEnabled = true;
            this.comboSoundType.Items.AddRange(new object[] {
            "Auto",
            "Mono",
            "Stereo"});
            this.comboSoundType.Location = new System.Drawing.Point(112, 43);
            this.comboSoundType.Name = "comboSoundType";
            this.comboSoundType.Size = new System.Drawing.Size(220, 22);
            this.comboSoundType.TabIndex = 9;
            // 
            // comboBitrateSound
            // 
            this.comboBitrateSound.FormattingEnabled = true;
            this.comboBitrateSound.Items.AddRange(new object[] {
            "Auto",
            "32",
            "64",
            "96",
            "112",
            "128",
            "256",
            "384",
            "512",
            "768"});
            this.comboBitrateSound.Location = new System.Drawing.Point(112, 15);
            this.comboBitrateSound.Name = "comboBitrateSound";
            this.comboBitrateSound.Size = new System.Drawing.Size(220, 22);
            this.comboBitrateSound.TabIndex = 8;
            this.comboBitrateSound.KeyUp += new System.Windows.Forms.KeyEventHandler(this.comboBitrateSound_KeyUp);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 14);
            this.label4.TabIndex = 7;
            this.label4.Text = "อัตราสุ่ม (HZ) :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 14);
            this.label3.TabIndex = 6;
            this.label3.Text = "ระบบเสียง :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 14);
            this.label2.TabIndex = 5;
            this.label2.Text = "อัตราบิต (KB/s) :";
            // 
            // comboFormatType
            // 
            this.comboFormatType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboFormatType.FormattingEnabled = true;
            this.comboFormatType.Items.AddRange(new object[] {
            "MPEG audio layer 2 (*.mp2)",
            "MPEG audio layer 3 (*.mp3)",
            "Windows Media Audio (*.wma)",
            "WAV Format (*.wav)",
            "raw FLAC (*.flac)",
            "raw ADTS AAC (*.aac)",
            "QuickTime (*.m4a)",
            "Ogg (*.ogg)",
            "MP4 Format (*.mp4)",
            "AVI Format (*.avi)",
            "Windows Media Video (*.wmv)",
            "Matroska Multimedia Container (*.mkv)",
            "MPEG-1/MPEG-2 (*.mpg) ",
            "MPEG-2 PS Format (*.vob)",
            "MOV Format (*.mov)",
            "FLV Format (*.flv)",
            "Flash Player (*.swf)"});
            this.comboFormatType.Location = new System.Drawing.Point(107, 84);
            this.comboFormatType.Name = "comboFormatType";
            this.comboFormatType.Size = new System.Drawing.Size(249, 22);
            this.comboFormatType.TabIndex = 2;
            this.comboFormatType.SelectedIndexChanged += new System.EventHandler(this.comboFormatType_SelectedIndexChanged);
            // 
            // radioVdoCustom
            // 
            this.radioVdoCustom.AutoSize = true;
            this.radioVdoCustom.Location = new System.Drawing.Point(24, 84);
            this.radioVdoCustom.Name = "radioVdoCustom";
            this.radioVdoCustom.Size = new System.Drawing.Size(77, 18);
            this.radioVdoCustom.TabIndex = 1;
            this.radioVdoCustom.Text = "กำหนดเอง";
            this.radioVdoCustom.UseVisualStyleBackColor = true;
            this.radioVdoCustom.CheckedChanged += new System.EventHandler(this.radioVdoCustom_CheckedChanged);
            // 
            // radioVdoDefault
            // 
            this.radioVdoDefault.AutoSize = true;
            this.radioVdoDefault.Checked = true;
            this.radioVdoDefault.Location = new System.Drawing.Point(24, 46);
            this.radioVdoDefault.Name = "radioVdoDefault";
            this.radioVdoDefault.Size = new System.Drawing.Size(73, 18);
            this.radioVdoDefault.TabIndex = 0;
            this.radioVdoDefault.TabStop = true;
            this.radioVdoDefault.Text = "ใช้ค่าคงที่";
            this.radioVdoDefault.UseVisualStyleBackColor = true;
            this.radioVdoDefault.CheckedChanged += new System.EventHandler(this.radioVdoDefault_CheckedChanged);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(250, 354);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "ตกลง";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(331, 354);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "ยกเลิก";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmAddVdo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 389);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtUrl);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddVdo";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "เพิ่มวีดีโอ";
            this.Load += new System.EventHandler(this.frmAddVdo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.vdo_panel.ResumeLayout(false);
            this.vdo_panel.PerformLayout();
            this.sound_panel.ResumeLayout(false);
            this.sound_panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.RadioButton radioVdoCustom;
        private System.Windows.Forms.RadioButton radioVdoDefault;
        private System.Windows.Forms.Panel sound_panel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel vdo_panel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtUrl;
        public System.Windows.Forms.ComboBox comboFormatType;
        public System.Windows.Forms.ComboBox comboResolution;
        public System.Windows.Forms.ComboBox comboFrameRate;
        public System.Windows.Forms.ComboBox comboVdoBitrate;
        public System.Windows.Forms.ComboBox comboDelsound;
        public System.Windows.Forms.ComboBox comboAspectRatio;
        public System.Windows.Forms.ComboBox comboHZSound;
        public System.Windows.Forms.ComboBox comboSoundType;
        public System.Windows.Forms.ComboBox comboBitrateSound;
    }
}