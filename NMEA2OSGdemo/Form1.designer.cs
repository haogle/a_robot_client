namespace NMEA2OSGdemo
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxLat = new System.Windows.Forms.TextBox();
            this.textBoxLon = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxSatInView = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxSatInUse = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxBearing = new System.Windows.Forms.TextBox();
            this.textBoxSpeed = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxFix = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxHDOP = new System.Windows.Forms.TextBox();
            this.gbPortSettings = new System.Windows.Forms.GroupBox();
            this.lblComPort = new System.Windows.Forms.Label();
            this.cmbPortName = new System.Windows.Forms.ComboBox();
            this.lblStopBits = new System.Windows.Forms.Label();
            this.cmbBaudRate = new System.Windows.Forms.ComboBox();
            this.cmbStopBits = new System.Windows.Forms.ComboBox();
            this.lblBaudRate = new System.Windows.Forms.Label();
            this.lblDataBits = new System.Windows.Forms.Label();
            this.cmbParity = new System.Windows.Forms.ComboBox();
            this.cmbDataBits = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNorthing = new System.Windows.Forms.TextBox();
            this.textBoxEasting = new System.Windows.Forms.TextBox();
            this.textBoxGridRef = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxEllipsoidHeight = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btn_show = new System.Windows.Forms.Button();
            this.wifi = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.btn_set = new System.Windows.Forms.Button();
            this.btnEngineStop = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.cmbPortName_1 = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.cmbBaudRate_1 = new System.Windows.Forms.ComboBox();
            this.cmbStopBits_1 = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.cmbParity_1 = new System.Windows.Forms.ComboBox();
            this.cmbDataBits_1 = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.button1_1 = new System.Windows.Forms.Button();
            this.label5_1 = new System.Windows.Forms.Label();
            this.label4_1 = new System.Windows.Forms.Label();
            this.label3_1 = new System.Windows.Forms.Label();
            this.openGLControl = new SharpGL.OpenGLControl();
            this.button4 = new System.Windows.Forms.Button();
            this.gbPortSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wifi)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.openGLControl)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 424);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 28);
            this.button1.TabIndex = 0;
            this.button1.Text = "打开串口";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxLat
            // 
            this.textBoxLat.Location = new System.Drawing.Point(24, 521);
            this.textBoxLat.Name = "textBoxLat";
            this.textBoxLat.Size = new System.Drawing.Size(153, 21);
            this.textBoxLat.TabIndex = 6;
            // 
            // textBoxLon
            // 
            this.textBoxLon.Location = new System.Drawing.Point(226, 521);
            this.textBoxLon.Name = "textBoxLon";
            this.textBoxLon.Size = new System.Drawing.Size(153, 21);
            this.textBoxLon.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(24, 457);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 28);
            this.button2.TabIndex = 8;
            this.button2.Text = "退出";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 498);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 9;
            this.label2.Text = "纬度";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(223, 498);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 10;
            this.label3.Text = "经度";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBoxSatInView
            // 
            this.textBoxSatInView.Location = new System.Drawing.Point(515, 548);
            this.textBoxSatInView.Name = "textBoxSatInView";
            this.textBoxSatInView.Size = new System.Drawing.Size(30, 21);
            this.textBoxSatInView.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(417, 551);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 12;
            this.label4.Text = "可见卫星";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(417, 576);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 14;
            this.label5.Text = "可用卫星";
            // 
            // textBoxSatInUse
            // 
            this.textBoxSatInUse.Location = new System.Drawing.Point(515, 574);
            this.textBoxSatInUse.Name = "textBoxSatInUse";
            this.textBoxSatInUse.Size = new System.Drawing.Size(30, 21);
            this.textBoxSatInUse.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(223, 574);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 18;
            this.label6.Text = "方位";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 571);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 17;
            this.label7.Text = "速度 (mph)";
            // 
            // textBoxBearing
            // 
            this.textBoxBearing.Location = new System.Drawing.Point(226, 586);
            this.textBoxBearing.Name = "textBoxBearing";
            this.textBoxBearing.Size = new System.Drawing.Size(153, 21);
            this.textBoxBearing.TabIndex = 16;
            // 
            // textBoxSpeed
            // 
            this.textBoxSpeed.Location = new System.Drawing.Point(24, 586);
            this.textBoxSpeed.Name = "textBoxSpeed";
            this.textBoxSpeed.Size = new System.Drawing.Size(153, 21);
            this.textBoxSpeed.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(417, 626);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 22;
            this.label8.Text = "修正模式";
            // 
            // textBoxFix
            // 
            this.textBoxFix.Location = new System.Drawing.Point(495, 623);
            this.textBoxFix.Name = "textBoxFix";
            this.textBoxFix.Size = new System.Drawing.Size(50, 21);
            this.textBoxFix.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(417, 600);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 12);
            this.label9.TabIndex = 20;
            this.label9.Text = "HDOP";
            // 
            // textBoxHDOP
            // 
            this.textBoxHDOP.Location = new System.Drawing.Point(515, 598);
            this.textBoxHDOP.Name = "textBoxHDOP";
            this.textBoxHDOP.Size = new System.Drawing.Size(30, 21);
            this.textBoxHDOP.TabIndex = 19;
            // 
            // gbPortSettings
            // 
            this.gbPortSettings.Controls.Add(this.lblComPort);
            this.gbPortSettings.Controls.Add(this.cmbPortName);
            this.gbPortSettings.Controls.Add(this.lblStopBits);
            this.gbPortSettings.Controls.Add(this.cmbBaudRate);
            this.gbPortSettings.Controls.Add(this.cmbStopBits);
            this.gbPortSettings.Controls.Add(this.lblBaudRate);
            this.gbPortSettings.Controls.Add(this.lblDataBits);
            this.gbPortSettings.Controls.Add(this.cmbParity);
            this.gbPortSettings.Controls.Add(this.cmbDataBits);
            this.gbPortSettings.Controls.Add(this.label1);
            this.gbPortSettings.Location = new System.Drawing.Point(159, 424);
            this.gbPortSettings.Name = "gbPortSettings";
            this.gbPortSettings.Size = new System.Drawing.Size(370, 64);
            this.gbPortSettings.TabIndex = 23;
            this.gbPortSettings.TabStop = false;
            this.gbPortSettings.Text = "串口设置";
            // 
            // lblComPort
            // 
            this.lblComPort.AutoSize = true;
            this.lblComPort.Location = new System.Drawing.Point(12, 18);
            this.lblComPort.Name = "lblComPort";
            this.lblComPort.Size = new System.Drawing.Size(53, 12);
            this.lblComPort.TabIndex = 0;
            this.lblComPort.Text = "端口号：";
            // 
            // cmbPortName
            // 
            this.cmbPortName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPortName.FormattingEnabled = true;
            this.cmbPortName.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6"});
            this.cmbPortName.Location = new System.Drawing.Point(13, 32);
            this.cmbPortName.Name = "cmbPortName";
            this.cmbPortName.Size = new System.Drawing.Size(67, 20);
            this.cmbPortName.TabIndex = 1;
            // 
            // lblStopBits
            // 
            this.lblStopBits.AutoSize = true;
            this.lblStopBits.Location = new System.Drawing.Point(295, 18);
            this.lblStopBits.Name = "lblStopBits";
            this.lblStopBits.Size = new System.Drawing.Size(53, 12);
            this.lblStopBits.TabIndex = 8;
            this.lblStopBits.Text = "停止位：";
            // 
            // cmbBaudRate
            // 
            this.cmbBaudRate.FormattingEnabled = true;
            this.cmbBaudRate.Items.AddRange(new object[] {
            "300",
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "28800",
            "36000",
            "115000"});
            this.cmbBaudRate.Location = new System.Drawing.Point(86, 32);
            this.cmbBaudRate.Name = "cmbBaudRate";
            this.cmbBaudRate.Size = new System.Drawing.Size(69, 20);
            this.cmbBaudRate.TabIndex = 3;
            // 
            // cmbStopBits
            // 
            this.cmbStopBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStopBits.FormattingEnabled = true;
            this.cmbStopBits.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cmbStopBits.Location = new System.Drawing.Point(293, 32);
            this.cmbStopBits.Name = "cmbStopBits";
            this.cmbStopBits.Size = new System.Drawing.Size(65, 20);
            this.cmbStopBits.TabIndex = 9;
            // 
            // lblBaudRate
            // 
            this.lblBaudRate.AutoSize = true;
            this.lblBaudRate.Location = new System.Drawing.Point(85, 18);
            this.lblBaudRate.Name = "lblBaudRate";
            this.lblBaudRate.Size = new System.Drawing.Size(53, 12);
            this.lblBaudRate.TabIndex = 2;
            this.lblBaudRate.Text = "波特率：";
            // 
            // lblDataBits
            // 
            this.lblDataBits.AutoSize = true;
            this.lblDataBits.Location = new System.Drawing.Point(229, 18);
            this.lblDataBits.Name = "lblDataBits";
            this.lblDataBits.Size = new System.Drawing.Size(53, 12);
            this.lblDataBits.TabIndex = 6;
            this.lblDataBits.Text = "流控制：";
            // 
            // cmbParity
            // 
            this.cmbParity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbParity.FormattingEnabled = true;
            this.cmbParity.Items.AddRange(new object[] {
            "None",
            "Even",
            "Odd"});
            this.cmbParity.Location = new System.Drawing.Point(161, 32);
            this.cmbParity.Name = "cmbParity";
            this.cmbParity.Size = new System.Drawing.Size(60, 20);
            this.cmbParity.TabIndex = 5;
            // 
            // cmbDataBits
            // 
            this.cmbDataBits.FormattingEnabled = true;
            this.cmbDataBits.Items.AddRange(new object[] {
            "7",
            "8",
            "9"});
            this.cmbDataBits.Location = new System.Drawing.Point(227, 32);
            this.cmbDataBits.Name = "cmbDataBits";
            this.cmbDataBits.Size = new System.Drawing.Size(60, 20);
            this.cmbDataBits.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(163, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "奇偶校验：";
            // 
            // textBoxNorthing
            // 
            this.textBoxNorthing.Location = new System.Drawing.Point(226, 627);
            this.textBoxNorthing.Name = "textBoxNorthing";
            this.textBoxNorthing.Size = new System.Drawing.Size(153, 21);
            this.textBoxNorthing.TabIndex = 26;
            // 
            // textBoxEasting
            // 
            this.textBoxEasting.Location = new System.Drawing.Point(24, 627);
            this.textBoxEasting.Name = "textBoxEasting";
            this.textBoxEasting.Size = new System.Drawing.Size(153, 21);
            this.textBoxEasting.TabIndex = 27;
            // 
            // textBoxGridRef
            // 
            this.textBoxGridRef.Location = new System.Drawing.Point(24, 665);
            this.textBoxGridRef.Name = "textBoxGridRef";
            this.textBoxGridRef.Size = new System.Drawing.Size(356, 21);
            this.textBoxGridRef.TabIndex = 29;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(24, 612);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 12);
            this.label12.TabIndex = 33;
            this.label12.Text = "偏东";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(223, 612);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(29, 12);
            this.label13.TabIndex = 32;
            this.label13.Text = "偏北";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(26, 650);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 12);
            this.label14.TabIndex = 34;
            this.label14.Text = "网格参考";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(24, 545);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(153, 21);
            this.textBox1.TabIndex = 35;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(225, 545);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(154, 21);
            this.textBox2.TabIndex = 36;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(392, 498);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 12);
            this.label10.TabIndex = 39;
            this.label10.Text = "海拔";
            // 
            // textBoxEllipsoidHeight
            // 
            this.textBoxEllipsoidHeight.Location = new System.Drawing.Point(395, 521);
            this.textBoxEllipsoidHeight.Name = "textBoxEllipsoidHeight";
            this.textBoxEllipsoidHeight.Size = new System.Drawing.Size(150, 21);
            this.textBoxEllipsoidHeight.TabIndex = 38;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(392, 645);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(153, 41);
            this.label11.TabIndex = 40;
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_show
            // 
            this.btn_show.Location = new System.Drawing.Point(385, 645);
            this.btn_show.Name = "btn_show";
            this.btn_show.Size = new System.Drawing.Size(75, 23);
            this.btn_show.TabIndex = 48;
            this.btn_show.Text = "视频";
            this.btn_show.UseVisualStyleBackColor = true;
            this.btn_show.Click += new System.EventHandler(this.btn_show_Click);
            // 
            // wifi
            // 
            this.wifi.Image = global::NMEA2OSGdemo.Properties.Resources.Morning_Lines__by_BrianAdelberg_at_December_6__2014_at_0415AM;
            this.wifi.Location = new System.Drawing.Point(12, 12);
            this.wifi.Name = "wifi";
            this.wifi.Size = new System.Drawing.Size(858, 400);
            this.wifi.TabIndex = 49;
            this.wifi.TabStop = false;
            this.wifi.Click += new System.EventHandler(this.wifi_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(385, 667);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 50;
            this.button3.Text = "新窗口";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // btn_set
            // 
            this.btn_set.Location = new System.Drawing.Point(466, 645);
            this.btn_set.Name = "btn_set";
            this.btn_set.Size = new System.Drawing.Size(75, 23);
            this.btn_set.TabIndex = 51;
            this.btn_set.Text = "设置";
            this.btn_set.UseVisualStyleBackColor = true;
            this.btn_set.Click += new System.EventHandler(this.btn_set_Click);
            // 
            // btnEngineStop
            // 
            this.btnEngineStop.Location = new System.Drawing.Point(470, 683);
            this.btnEngineStop.Name = "btnEngineStop";
            this.btnEngineStop.Size = new System.Drawing.Size(75, 23);
            this.btnEngineStop.TabIndex = 52;
            this.btnEngineStop.Text = "btnEngineStop";
            this.btnEngineStop.UseVisualStyleBackColor = true;
            this.btnEngineStop.Visible = false;
            this.btnEngineStop.Click += new System.EventHandler(this.btnEngineStop_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.cmbPortName_1);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.cmbBaudRate_1);
            this.groupBox1.Controls.Add(this.cmbStopBits_1);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.cmbParity_1);
            this.groupBox1.Controls.Add(this.cmbDataBits_1);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Location = new System.Drawing.Point(523, 421);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(370, 64);
            this.groupBox1.TabIndex = 53;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "串口设置";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(12, 18);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(41, 12);
            this.label15.TabIndex = 0;
            this.label15.Text = "端口号";
            // 
            // cmbPortName_1
            // 
            this.cmbPortName_1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPortName_1.FormattingEnabled = true;
            this.cmbPortName_1.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6"});
            this.cmbPortName_1.Location = new System.Drawing.Point(13, 32);
            this.cmbPortName_1.Name = "cmbPortName_1";
            this.cmbPortName_1.Size = new System.Drawing.Size(67, 20);
            this.cmbPortName_1.TabIndex = 1;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(295, 18);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(41, 12);
            this.label16.TabIndex = 8;
            this.label16.Text = "流控制";
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // cmbBaudRate_1
            // 
            this.cmbBaudRate_1.FormattingEnabled = true;
            this.cmbBaudRate_1.Items.AddRange(new object[] {
            "300",
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "28800",
            "57600",
            "115000"});
            this.cmbBaudRate_1.Location = new System.Drawing.Point(86, 32);
            this.cmbBaudRate_1.Name = "cmbBaudRate_1";
            this.cmbBaudRate_1.Size = new System.Drawing.Size(69, 20);
            this.cmbBaudRate_1.TabIndex = 3;
            // 
            // cmbStopBits_1
            // 
            this.cmbStopBits_1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStopBits_1.FormattingEnabled = true;
            this.cmbStopBits_1.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cmbStopBits_1.Location = new System.Drawing.Point(293, 32);
            this.cmbStopBits_1.Name = "cmbStopBits_1";
            this.cmbStopBits_1.Size = new System.Drawing.Size(65, 20);
            this.cmbStopBits_1.TabIndex = 9;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(85, 18);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(41, 12);
            this.label17.TabIndex = 2;
            this.label17.Text = "波特率";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(229, 18);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(41, 12);
            this.label18.TabIndex = 6;
            this.label18.Text = "流控制";
            // 
            // cmbParity_1
            // 
            this.cmbParity_1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbParity_1.FormattingEnabled = true;
            this.cmbParity_1.Items.AddRange(new object[] {
            "None",
            "Even",
            "Odd"});
            this.cmbParity_1.Location = new System.Drawing.Point(161, 32);
            this.cmbParity_1.Name = "cmbParity_1";
            this.cmbParity_1.Size = new System.Drawing.Size(60, 20);
            this.cmbParity_1.TabIndex = 5;
            // 
            // cmbDataBits_1
            // 
            this.cmbDataBits_1.FormattingEnabled = true;
            this.cmbDataBits_1.Items.AddRange(new object[] {
            "7",
            "8",
            "9"});
            this.cmbDataBits_1.Location = new System.Drawing.Point(227, 32);
            this.cmbDataBits_1.Name = "cmbDataBits_1";
            this.cmbDataBits_1.Size = new System.Drawing.Size(60, 20);
            this.cmbDataBits_1.TabIndex = 7;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(163, 18);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(53, 12);
            this.label19.TabIndex = 4;
            this.label19.Text = "奇偶校验";
            // 
            // button1_1
            // 
            this.button1_1.Location = new System.Drawing.Point(754, 482);
            this.button1_1.Name = "button1_1";
            this.button1_1.Size = new System.Drawing.Size(129, 28);
            this.button1_1.TabIndex = 54;
            this.button1_1.Text = "打开端口";
            this.button1_1.UseVisualStyleBackColor = true;
            this.button1_1.Click += new System.EventHandler(this.button1_1_Click);
            // 
            // label5_1
            // 
            this.label5_1.AutoSize = true;
            this.label5_1.Location = new System.Drawing.Point(703, 488);
            this.label5_1.Name = "label5_1";
            this.label5_1.Size = new System.Drawing.Size(23, 12);
            this.label5_1.TabIndex = 57;
            this.label5_1.Text = "yaw";
            // 
            // label4_1
            // 
            this.label4_1.AutoSize = true;
            this.label4_1.Location = new System.Drawing.Point(637, 488);
            this.label4_1.Name = "label4_1";
            this.label4_1.Size = new System.Drawing.Size(35, 12);
            this.label4_1.TabIndex = 56;
            this.label4_1.Text = "pitch";
            // 
            // label3_1
            // 
            this.label3_1.AutoSize = true;
            this.label3_1.Location = new System.Drawing.Point(561, 488);
            this.label3_1.Name = "label3_1";
            this.label3_1.Size = new System.Drawing.Size(29, 12);
            this.label3_1.TabIndex = 55;
            this.label3_1.Text = "roll";
            // 
            // openGLControl
            // 
            this.openGLControl.AllowDrop = true;
            this.openGLControl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.openGLControl.DrawFPS = true;
            this.openGLControl.Location = new System.Drawing.Point(563, 516);
            this.openGLControl.Name = "openGLControl";
            this.openGLControl.OpenGLVersion = SharpGL.Version.OpenGLVersion.OpenGL2_1;
            this.openGLControl.RenderContextType = SharpGL.RenderContextType.FBO;
            this.openGLControl.RenderTrigger = SharpGL.RenderTrigger.TimerBased;
            this.openGLControl.Size = new System.Drawing.Size(309, 190);
            this.openGLControl.TabIndex = 58;
            this.openGLControl.OpenGLInitialized += new System.EventHandler(this.openGLControl_OpenGLInitialized);
            this.openGLControl.OpenGLDraw += new SharpGL.RenderEventHandler(this.openGLControl_OpenGLDraw);
            this.openGLControl.Resized += new System.EventHandler(this.openGLControl_Resized);
            this.openGLControl.Load += new System.EventHandler(this.openGLControl_Load);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(466, 663);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 59;
            this.button4.Text = "控制口";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 702);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.openGLControl);
            this.Controls.Add(this.label5_1);
            this.Controls.Add(this.label4_1);
            this.Controls.Add(this.label3_1);
            this.Controls.Add(this.button1_1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnEngineStop);
            this.Controls.Add(this.btn_set);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.wifi);
            this.Controls.Add(this.btn_show);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBoxEllipsoidHeight);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.textBoxGridRef);
            this.Controls.Add(this.textBoxEasting);
            this.Controls.Add(this.textBoxNorthing);
            this.Controls.Add(this.gbPortSettings);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxFix);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxHDOP);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxBearing);
            this.Controls.Add(this.textBoxSpeed);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxSatInUse);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxSatInView);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBoxLon);
            this.Controls.Add(this.textBoxLat);
            this.Controls.Add(this.button1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "移动可攀爬式取像探测机器人";
            this.Deactivate += new System.EventHandler(this.Mainfrm_Deactivate);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Mainfrm_Load);
            this.gbPortSettings.ResumeLayout(false);
            this.gbPortSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wifi)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.openGLControl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxLat;
        private System.Windows.Forms.TextBox textBoxLon;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxSatInView;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxSatInUse;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxBearing;
        private System.Windows.Forms.TextBox textBoxSpeed;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxFix;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxHDOP;
        private System.Windows.Forms.GroupBox gbPortSettings;
        private System.Windows.Forms.Label lblComPort;
        private System.Windows.Forms.ComboBox cmbPortName;
        private System.Windows.Forms.Label lblStopBits;
        private System.Windows.Forms.ComboBox cmbBaudRate;
        private System.Windows.Forms.ComboBox cmbStopBits;
        private System.Windows.Forms.Label lblBaudRate;
        private System.Windows.Forms.Label lblDataBits;
        private System.Windows.Forms.ComboBox cmbParity;
        private System.Windows.Forms.ComboBox cmbDataBits;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNorthing;
        private System.Windows.Forms.TextBox textBoxEasting;
        private System.Windows.Forms.TextBox textBoxGridRef;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxEllipsoidHeight;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btn_show;
        private System.Windows.Forms.PictureBox wifi;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btn_set;
        private System.Windows.Forms.Button btnEngineStop;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cmbPortName_1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cmbBaudRate_1;
        private System.Windows.Forms.ComboBox cmbStopBits_1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox cmbParity_1;
        private System.Windows.Forms.ComboBox cmbDataBits_1;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button button1_1;
        private System.Windows.Forms.Label label5_1;
        private System.Windows.Forms.Label label4_1;
        private System.Windows.Forms.Label label3_1;
        private SharpGL.OpenGLControl openGLControl;
        private System.Windows.Forms.Button button4;
    }
}

