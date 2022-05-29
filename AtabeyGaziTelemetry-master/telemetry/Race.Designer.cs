namespace telemetry
{
    partial class Race
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Race));
            this.bt_startStop = new System.Windows.Forms.Button();
            this.tb_time = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_distance = new System.Windows.Forms.TextBox();
            this.lb_timeLeft = new System.Windows.Forms.Label();
            this.lb_laps = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bt_addLap = new System.Windows.Forms.Button();
            this.lb_timePassed = new System.Windows.Forms.Label();
            this.lb_watt = new System.Windows.Forms.Label();
            this.tm_sl = new System.Windows.Forms.Timer(this.components);
            this.tm_sn = new System.Windows.Forms.Timer(this.components);
            this.tm_min = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.bt_pause = new System.Windows.Forms.Button();
            this.bt_minimize = new System.Windows.Forms.PictureBox();
            this.bt_close = new System.Windows.Forms.PictureBox();
            this.pLayout1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lb_lapTime = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_raceName = new System.Windows.Forms.TextBox();
            this.lb_distance = new System.Windows.Forms.Label();
            this.cb_autoCount = new System.Windows.Forms.CheckBox();
            this.lb_totalDist = new System.Windows.Forms.Label();
            this.lb_lapsAuto = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lb_lapTimeAuto = new System.Windows.Forms.Label();
            this.bt_saveLogs = new telemetry.CircularButton();
            this.bt_showLogs = new telemetry.CircularButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bt_watt = new System.Windows.Forms.Button();
            this.tb_watt = new System.Windows.Forms.TextBox();
            this.bt_resetWatt = new System.Windows.Forms.Button();
            this.lb_watAv = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bt_minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bt_close)).BeginInit();
            this.pLayout1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_startStop
            // 
            this.bt_startStop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(36)))), ((int)(((byte)(54)))));
            this.bt_startStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bt_startStop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_startStop.Location = new System.Drawing.Point(14, 297);
            this.bt_startStop.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.bt_startStop.Name = "bt_startStop";
            this.bt_startStop.Size = new System.Drawing.Size(109, 74);
            this.bt_startStop.TabIndex = 0;
            this.bt_startStop.Text = "Başlat";
            this.bt_startStop.UseVisualStyleBackColor = false;
            this.bt_startStop.Click += new System.EventHandler(this.bt_startStop_Click);
            // 
            // tb_time
            // 
            this.tb_time.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(36)))), ((int)(((byte)(54)))));
            this.tb_time.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_time.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.tb_time.Location = new System.Drawing.Point(182, 163);
            this.tb_time.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tb_time.Multiline = true;
            this.tb_time.Name = "tb_time";
            this.tb_time.Size = new System.Drawing.Size(125, 47);
            this.tb_time.TabIndex = 1;
            this.tb_time.Text = "60";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(14, 163);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Yarış Süresi (dk):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(14, 186);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Pist Uzunluğu (m):";
            // 
            // tb_distance
            // 
            this.tb_distance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(36)))), ((int)(((byte)(54)))));
            this.tb_distance.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_distance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.tb_distance.Location = new System.Drawing.Point(325, 163);
            this.tb_distance.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tb_distance.Multiline = true;
            this.tb_distance.Name = "tb_distance";
            this.tb_distance.Size = new System.Drawing.Size(125, 47);
            this.tb_distance.TabIndex = 3;
            this.tb_distance.Text = "10";
            // 
            // lb_timeLeft
            // 
            this.lb_timeLeft.AutoSize = true;
            this.lb_timeLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb_timeLeft.Location = new System.Drawing.Point(476, 147);
            this.lb_timeLeft.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lb_timeLeft.Name = "lb_timeLeft";
            this.lb_timeLeft.Size = new System.Drawing.Size(227, 42);
            this.lb_timeLeft.TabIndex = 5;
            this.lb_timeLeft.Text = "00:00:00:00";
            // 
            // lb_laps
            // 
            this.lb_laps.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(36)))), ((int)(((byte)(54)))));
            this.lb_laps.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lb_laps.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb_laps.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.lb_laps.FormattingEnabled = true;
            this.lb_laps.ItemHeight = 25;
            this.lb_laps.Location = new System.Drawing.Point(1100, 186);
            this.lb_laps.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.lb_laps.Name = "lb_laps";
            this.lb_laps.Size = new System.Drawing.Size(350, 550);
            this.lb_laps.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(1095, 125);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Elle Eklenen";
            // 
            // bt_addLap
            // 
            this.bt_addLap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(36)))), ((int)(((byte)(54)))));
            this.bt_addLap.FlatAppearance.BorderSize = 0;
            this.bt_addLap.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_addLap.Location = new System.Drawing.Point(1305, 104);
            this.bt_addLap.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.bt_addLap.Name = "bt_addLap";
            this.bt_addLap.Size = new System.Drawing.Size(145, 70);
            this.bt_addLap.TabIndex = 8;
            this.bt_addLap.Text = "Tur Ekle";
            this.bt_addLap.UseVisualStyleBackColor = false;
            this.bt_addLap.Click += new System.EventHandler(this.bt_addLap_Click);
            // 
            // lb_timePassed
            // 
            this.lb_timePassed.AutoSize = true;
            this.lb_timePassed.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb_timePassed.Location = new System.Drawing.Point(496, 186);
            this.lb_timePassed.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lb_timePassed.Name = "lb_timePassed";
            this.lb_timePassed.Size = new System.Drawing.Size(188, 37);
            this.lb_timePassed.TabIndex = 9;
            this.lb_timePassed.Text = "00:00:00:00";
            // 
            // lb_watt
            // 
            this.lb_watt.AutoSize = true;
            this.lb_watt.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb_watt.Location = new System.Drawing.Point(8, 25);
            this.lb_watt.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lb_watt.Name = "lb_watt";
            this.lb_watt.Size = new System.Drawing.Size(268, 31);
            this.lb_watt.TabIndex = 10;
            this.lb_watt.Text = "Enerji Tüketimi (w/s):";
            // 
            // tm_sl
            // 
            this.tm_sl.Interval = 10;
            this.tm_sl.Tick += new System.EventHandler(this.tm_sl_Tick);
            // 
            // tm_sn
            // 
            this.tm_sn.Interval = 1000;
            this.tm_sn.Tick += new System.EventHandler(this.tm_sn_Tick);
            // 
            // tm_min
            // 
            this.tm_min.Interval = 60000;
            this.tm_min.Tick += new System.EventHandler(this.tm_min_Tick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(486, 125);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(211, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "s   :   dk   :   sn   :   sl";
            // 
            // bt_pause
            // 
            this.bt_pause.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(36)))), ((int)(((byte)(54)))));
            this.bt_pause.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_pause.Location = new System.Drawing.Point(134, 297);
            this.bt_pause.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.bt_pause.Name = "bt_pause";
            this.bt_pause.Size = new System.Drawing.Size(109, 74);
            this.bt_pause.TabIndex = 12;
            this.bt_pause.Text = "| |";
            this.bt_pause.UseVisualStyleBackColor = false;
            this.bt_pause.Click += new System.EventHandler(this.bt_pause_Click);
            // 
            // bt_minimize
            // 
            this.bt_minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_minimize.Image = ((System.Drawing.Image)(resources.GetObject("bt_minimize.Image")));
            this.bt_minimize.Location = new System.Drawing.Point(1314, 15);
            this.bt_minimize.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.bt_minimize.Name = "bt_minimize";
            this.bt_minimize.Size = new System.Drawing.Size(63, 53);
            this.bt_minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.bt_minimize.TabIndex = 15;
            this.bt_minimize.TabStop = false;
            this.bt_minimize.Click += new System.EventHandler(this.bt_minimize_Click);
            // 
            // bt_close
            // 
            this.bt_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_close.Image = ((System.Drawing.Image)(resources.GetObject("bt_close.Image")));
            this.bt_close.Location = new System.Drawing.Point(1387, 15);
            this.bt_close.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.bt_close.Name = "bt_close";
            this.bt_close.Size = new System.Drawing.Size(57, 53);
            this.bt_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bt_close.TabIndex = 17;
            this.bt_close.TabStop = false;
            this.bt_close.Click += new System.EventHandler(this.bt_close_Click);
            // 
            // pLayout1
            // 
            this.pLayout1.Controls.Add(this.label8);
            this.pLayout1.Controls.Add(this.label5);
            this.pLayout1.Controls.Add(this.bt_minimize);
            this.pLayout1.Controls.Add(this.pictureBox1);
            this.pLayout1.Controls.Add(this.bt_close);
            this.pLayout1.Location = new System.Drawing.Point(0, 0);
            this.pLayout1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.pLayout1.Name = "pLayout1";
            this.pLayout1.Size = new System.Drawing.Size(1460, 92);
            this.pLayout1.TabIndex = 18;
            this.pLayout1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pLayout1_MouseDown);
            this.pLayout1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pLayout1_MouseMove);
            this.pLayout1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pLayout1_MouseUp);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(130, 48);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(202, 20);
            this.label8.TabIndex = 20;
            this.label8.Text = "© Şerife Bacının Torunları ©";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(106, 15);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(260, 33);
            this.label5.TabIndex = 19;
            this.label5.Text = "SBT Race Logger";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(14, 6);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(82, 77);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lb_lapTime
            // 
            this.lb_lapTime.AutoSize = true;
            this.lb_lapTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb_lapTime.Location = new System.Drawing.Point(1113, 155);
            this.lb_lapTime.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lb_lapTime.Name = "lb_lapTime";
            this.lb_lapTime.Size = new System.Drawing.Size(117, 25);
            this.lb_lapTime.TabIndex = 19;
            this.lb_lapTime.Text = "Tur Süresi:";
            this.lb_lapTime.Click += new System.EventHandler(this.lb_lapTime_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(14, 116);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 24);
            this.label6.TabIndex = 23;
            this.label6.Text = "Yarış Adı:";
            // 
            // tb_raceName
            // 
            this.tb_raceName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(36)))), ((int)(((byte)(54)))));
            this.tb_raceName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_raceName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.tb_raceName.Location = new System.Drawing.Point(182, 104);
            this.tb_raceName.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tb_raceName.Multiline = true;
            this.tb_raceName.Name = "tb_raceName";
            this.tb_raceName.Size = new System.Drawing.Size(268, 47);
            this.tb_raceName.TabIndex = 22;
            this.tb_raceName.Text = "Efficiency Challenge 2022";
            // 
            // lb_distance
            // 
            this.lb_distance.AutoSize = true;
            this.lb_distance.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb_distance.Location = new System.Drawing.Point(8, 72);
            this.lb_distance.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lb_distance.Name = "lb_distance";
            this.lb_distance.Size = new System.Drawing.Size(190, 31);
            this.lb_distance.TabIndex = 24;
            this.lb_distance.Text = "Alınan Yol (m):";
            // 
            // cb_autoCount
            // 
            this.cb_autoCount.AutoSize = true;
            this.cb_autoCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cb_autoCount.Location = new System.Drawing.Point(14, 240);
            this.cb_autoCount.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.cb_autoCount.Name = "cb_autoCount";
            this.cb_autoCount.Size = new System.Drawing.Size(189, 28);
            this.cb_autoCount.TabIndex = 25;
            this.cb_autoCount.Text = "Turları otomatik say";
            this.cb_autoCount.UseVisualStyleBackColor = true;
            // 
            // lb_totalDist
            // 
            this.lb_totalDist.AutoSize = true;
            this.lb_totalDist.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb_totalDist.Location = new System.Drawing.Point(8, 120);
            this.lb_totalDist.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lb_totalDist.Name = "lb_totalDist";
            this.lb_totalDist.Size = new System.Drawing.Size(143, 31);
            this.lb_totalDist.TabIndex = 26;
            this.lb_totalDist.Text = "Tur Sayısı:";
            // 
            // lb_lapsAuto
            // 
            this.lb_lapsAuto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(36)))), ((int)(((byte)(54)))));
            this.lb_lapsAuto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lb_lapsAuto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb_lapsAuto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.lb_lapsAuto.FormattingEnabled = true;
            this.lb_lapsAuto.ItemHeight = 25;
            this.lb_lapsAuto.Location = new System.Drawing.Point(740, 186);
            this.lb_lapsAuto.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.lb_lapsAuto.Name = "lb_lapsAuto";
            this.lb_lapsAuto.Size = new System.Drawing.Size(350, 550);
            this.lb_lapsAuto.TabIndex = 27;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(735, 125);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(181, 25);
            this.label7.TabIndex = 28;
            this.label7.Text = "Otomatik Eklenen";
            // 
            // lb_lapTimeAuto
            // 
            this.lb_lapTimeAuto.AutoSize = true;
            this.lb_lapTimeAuto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb_lapTimeAuto.Location = new System.Drawing.Point(755, 155);
            this.lb_lapTimeAuto.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lb_lapTimeAuto.Name = "lb_lapTimeAuto";
            this.lb_lapTimeAuto.Size = new System.Drawing.Size(117, 25);
            this.lb_lapTimeAuto.TabIndex = 29;
            this.lb_lapTimeAuto.Text = "Tur Süresi:";
            // 
            // bt_saveLogs
            // 
            this.bt_saveLogs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(36)))), ((int)(((byte)(54)))));
            this.bt_saveLogs.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_saveLogs.BackgroundImage")));
            this.bt_saveLogs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_saveLogs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_saveLogs.FlatAppearance.BorderSize = 0;
            this.bt_saveLogs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_saveLogs.Location = new System.Drawing.Point(323, 222);
            this.bt_saveLogs.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.bt_saveLogs.Name = "bt_saveLogs";
            this.bt_saveLogs.Size = new System.Drawing.Size(57, 62);
            this.bt_saveLogs.TabIndex = 20;
            this.bt_saveLogs.UseVisualStyleBackColor = false;
            this.bt_saveLogs.Click += new System.EventHandler(this.bt_saveLogs_Click);
            // 
            // bt_showLogs
            // 
            this.bt_showLogs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(36)))), ((int)(((byte)(54)))));
            this.bt_showLogs.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_showLogs.BackgroundImage")));
            this.bt_showLogs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_showLogs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_showLogs.FlatAppearance.BorderSize = 0;
            this.bt_showLogs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_showLogs.Location = new System.Drawing.Point(393, 222);
            this.bt_showLogs.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.bt_showLogs.Name = "bt_showLogs";
            this.bt_showLogs.Size = new System.Drawing.Size(57, 62);
            this.bt_showLogs.TabIndex = 21;
            this.bt_showLogs.UseVisualStyleBackColor = false;
            this.bt_showLogs.Click += new System.EventHandler(this.bt_showLogs_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bt_resetWatt);
            this.groupBox1.Controls.Add(this.lb_watt);
            this.groupBox1.Controls.Add(this.lb_distance);
            this.groupBox1.Controls.Add(this.lb_totalDist);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 380);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(720, 165);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Otomatik Yarış İzleme (Telemetri bağlantısı gereklidir.)";
            // 
            // bt_watt
            // 
            this.bt_watt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(36)))), ((int)(((byte)(54)))));
            this.bt_watt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_watt.Location = new System.Drawing.Point(344, 310);
            this.bt_watt.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.bt_watt.Name = "bt_watt";
            this.bt_watt.Size = new System.Drawing.Size(72, 35);
            this.bt_watt.TabIndex = 31;
            this.bt_watt.Text = "EKLE";
            this.bt_watt.UseVisualStyleBackColor = false;
            this.bt_watt.Click += new System.EventHandler(this.bt_watt_Click);
            // 
            // tb_watt
            // 
            this.tb_watt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(36)))), ((int)(((byte)(54)))));
            this.tb_watt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_watt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.tb_watt.Location = new System.Drawing.Point(253, 310);
            this.tb_watt.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tb_watt.Multiline = true;
            this.tb_watt.Name = "tb_watt";
            this.tb_watt.Size = new System.Drawing.Size(81, 35);
            this.tb_watt.TabIndex = 32;
            this.tb_watt.Text = "10";
            // 
            // bt_resetWatt
            // 
            this.bt_resetWatt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(36)))), ((int)(((byte)(54)))));
            this.bt_resetWatt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_resetWatt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bt_resetWatt.Location = new System.Drawing.Point(381, 31);
            this.bt_resetWatt.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.bt_resetWatt.Name = "bt_resetWatt";
            this.bt_resetWatt.Size = new System.Drawing.Size(71, 25);
            this.bt_resetWatt.TabIndex = 33;
            this.bt_resetWatt.Text = "Sıfırla";
            this.bt_resetWatt.UseVisualStyleBackColor = false;
            this.bt_resetWatt.Click += new System.EventHandler(this.bt_resetWatt_Click);
            // 
            // lb_watAv
            // 
            this.lb_watAv.AutoSize = true;
            this.lb_watAv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb_watAv.Location = new System.Drawing.Point(249, 351);
            this.lb_watAv.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lb_watAv.Name = "lb_watAv";
            this.lb_watAv.Size = new System.Drawing.Size(14, 20);
            this.lb_watAv.TabIndex = 33;
            this.lb_watAv.Text = "-";
            // 
            // Race
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(17)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(1458, 752);
            this.Controls.Add(this.lb_watAv);
            this.Controls.Add(this.tb_watt);
            this.Controls.Add(this.bt_watt);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lb_lapTimeAuto);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lb_lapsAuto);
            this.Controls.Add(this.cb_autoCount);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_raceName);
            this.Controls.Add(this.bt_saveLogs);
            this.Controls.Add(this.bt_showLogs);
            this.Controls.Add(this.lb_lapTime);
            this.Controls.Add(this.pLayout1);
            this.Controls.Add(this.bt_pause);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lb_timePassed);
            this.Controls.Add(this.bt_addLap);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lb_laps);
            this.Controls.Add(this.lb_timeLeft);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_distance);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_time);
            this.Controls.Add(this.bt_startStop);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Race";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Race";
            this.Load += new System.EventHandler(this.Race_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bt_minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bt_close)).EndInit();
            this.pLayout1.ResumeLayout(false);
            this.pLayout1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bt_startStop;
        private System.Windows.Forms.TextBox tb_time;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_distance;
        private System.Windows.Forms.Label lb_timeLeft;
        private System.Windows.Forms.ListBox lb_laps;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bt_addLap;
        private System.Windows.Forms.Label lb_timePassed;
        private System.Windows.Forms.Label lb_watt;
        private System.Windows.Forms.Timer tm_sl;
        private System.Windows.Forms.Timer tm_sn;
        private System.Windows.Forms.Timer tm_min;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bt_pause;
        private System.Windows.Forms.PictureBox bt_minimize;
        private System.Windows.Forms.PictureBox bt_close;
        private System.Windows.Forms.Panel pLayout1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lb_lapTime;
        private CircularButton bt_saveLogs;
        private CircularButton bt_showLogs;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_raceName;
        private System.Windows.Forms.Label lb_distance;
        private System.Windows.Forms.CheckBox cb_autoCount;
        private System.Windows.Forms.Label lb_totalDist;
        private System.Windows.Forms.ListBox lb_lapsAuto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lb_lapTimeAuto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bt_watt;
        private System.Windows.Forms.TextBox tb_watt;
        private System.Windows.Forms.Button bt_resetWatt;
        private System.Windows.Forms.Label lb_watAv;
    }
}