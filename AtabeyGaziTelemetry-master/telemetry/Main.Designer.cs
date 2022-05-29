namespace telemetry
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
            this.p_info = new System.Windows.Forms.Panel();
            this.lb_watt = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lb_battery = new System.Windows.Forms.Label();
            this.lb_voltage = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.p_speed = new System.Windows.Forms.Panel();
            this.lb_engine = new System.Windows.Forms.Label();
            this.p_current = new System.Windows.Forms.Panel();
            this.lb_current = new System.Windows.Forms.Label();
            this.p_temp = new System.Windows.Forms.Panel();
            this.lb_temp = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_ports = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cb_baudRate = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.p_logs = new System.Windows.Forms.Panel();
            this.lb_add = new System.Windows.Forms.Label();
            this.lb_sub = new System.Windows.Forms.Label();
            this.tb_logs = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pLayout1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bt_minimize = new System.Windows.Forms.PictureBox();
            this.bt_close = new System.Windows.Forms.PictureBox();
            this.bt_settings = new System.Windows.Forms.PictureBox();
            this.pLayout2 = new System.Windows.Forms.Panel();
            this.lb_speed = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pb_race = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.bt_refresh = new System.Windows.Forms.PictureBox();
            this.bt_connect = new System.Windows.Forms.PictureBox();
            this.pLayout3 = new System.Windows.Forms.Panel();
            this.pLayout4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pLayout5 = new System.Windows.Forms.Panel();
            this.tm_fakeData = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.bt_saveLogs = new telemetry.CircularButton();
            this.bt_showLogs = new telemetry.CircularButton();
            this.bt_clearLogs = new telemetry.CircularButton();
            this.p_info.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.p_speed.SuspendLayout();
            this.p_current.SuspendLayout();
            this.p_temp.SuspendLayout();
            this.p_logs.SuspendLayout();
            this.pLayout1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bt_minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bt_close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bt_settings)).BeginInit();
            this.pLayout2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_race)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bt_refresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bt_connect)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.SuspendLayout();
            // 
            // p_info
            // 
            this.p_info.Controls.Add(this.lb_watt);
            this.p_info.Controls.Add(this.pictureBox2);
            this.p_info.Controls.Add(this.lb_battery);
            this.p_info.Controls.Add(this.lb_voltage);
            this.p_info.Controls.Add(this.pictureBox3);
            this.p_info.Controls.Add(this.p_speed);
            this.p_info.Controls.Add(this.p_current);
            this.p_info.Controls.Add(this.p_temp);
            this.p_info.Dock = System.Windows.Forms.DockStyle.Top;
            this.p_info.Location = new System.Drawing.Point(0, 100);
            this.p_info.Name = "p_info";
            this.p_info.Size = new System.Drawing.Size(768, 108);
            this.p_info.TabIndex = 3;
            // 
            // lb_watt
            // 
            this.lb_watt.AutoSize = true;
            this.lb_watt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(36)))), ((int)(((byte)(54)))));
            this.lb_watt.Font = new System.Drawing.Font("Microsoft Sans Serif", 27F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb_watt.ForeColor = System.Drawing.Color.White;
            this.lb_watt.Location = new System.Drawing.Point(339, 47);
            this.lb_watt.Name = "lb_watt";
            this.lb_watt.Size = new System.Drawing.Size(97, 40);
            this.lb_watt.TabIndex = 6;
            this.lb_watt.Text = "0000";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::telemetry.Properties.Resources.watt;
            this.pictureBox2.Location = new System.Drawing.Point(322, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(125, 108);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // lb_battery
            // 
            this.lb_battery.AutoSize = true;
            this.lb_battery.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(36)))), ((int)(((byte)(54)))));
            this.lb_battery.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lb_battery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lb_battery.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb_battery.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(178)))), ((int)(((byte)(58)))));
            this.lb_battery.Location = new System.Drawing.Point(202, 81);
            this.lb_battery.Name = "lb_battery";
            this.lb_battery.Size = new System.Drawing.Size(63, 25);
            this.lb_battery.TabIndex = 1;
            this.lb_battery.Text = "100%";
            this.lb_battery.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_battery.Click += new System.EventHandler(this.p_battery_Click);
            // 
            // lb_voltage
            // 
            this.lb_voltage.AutoSize = true;
            this.lb_voltage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(36)))), ((int)(((byte)(54)))));
            this.lb_voltage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lb_voltage.Font = new System.Drawing.Font("Microsoft Sans Serif", 27F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb_voltage.ForeColor = System.Drawing.Color.White;
            this.lb_voltage.Location = new System.Drawing.Point(179, 44);
            this.lb_voltage.Name = "lb_voltage";
            this.lb_voltage.Size = new System.Drawing.Size(107, 40);
            this.lb_voltage.TabIndex = 4;
            this.lb_voltage.Text = "103.3";
            this.lb_voltage.Click += new System.EventHandler(this.p_battery_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = global::telemetry.Properties.Resources.gerilim;
            this.pictureBox3.Location = new System.Drawing.Point(167, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(125, 108);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.p_battery_Click);
            // 
            // p_speed
            // 
            this.p_speed.BackgroundImage = global::telemetry.Properties.Resources.Motor;
            this.p_speed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.p_speed.Controls.Add(this.lb_engine);
            this.p_speed.Cursor = System.Windows.Forms.Cursors.Default;
            this.p_speed.Location = new System.Drawing.Point(623, 3);
            this.p_speed.Name = "p_speed";
            this.p_speed.Size = new System.Drawing.Size(125, 108);
            this.p_speed.TabIndex = 2;
            this.p_speed.Click += new System.EventHandler(this.p_speed_Click);
            // 
            // lb_engine
            // 
            this.lb_engine.AutoSize = true;
            this.lb_engine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(36)))), ((int)(((byte)(54)))));
            this.lb_engine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lb_engine.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb_engine.ForeColor = System.Drawing.Color.Blue;
            this.lb_engine.Location = new System.Drawing.Point(22, 44);
            this.lb_engine.Name = "lb_engine";
            this.lb_engine.Size = new System.Drawing.Size(81, 42);
            this.lb_engine.TabIndex = 1;
            this.lb_engine.Text = "0°C";
            this.lb_engine.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // p_current
            // 
            this.p_current.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p_current.BackgroundImage")));
            this.p_current.Controls.Add(this.lb_current);
            this.p_current.Cursor = System.Windows.Forms.Cursors.Default;
            this.p_current.Location = new System.Drawing.Point(475, 0);
            this.p_current.Name = "p_current";
            this.p_current.Size = new System.Drawing.Size(125, 108);
            this.p_current.TabIndex = 2;
            this.p_current.Click += new System.EventHandler(this.p_current_Click);
            // 
            // lb_current
            // 
            this.lb_current.AutoSize = true;
            this.lb_current.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(36)))), ((int)(((byte)(54)))));
            this.lb_current.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lb_current.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb_current.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(195)))), ((int)(((byte)(255)))));
            this.lb_current.Location = new System.Drawing.Point(7, 46);
            this.lb_current.Name = "lb_current";
            this.lb_current.Size = new System.Drawing.Size(106, 39);
            this.lb_current.TabIndex = 1;
            this.lb_current.Text = "0.00A";
            this.lb_current.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_current.Click += new System.EventHandler(this.p_current_Click);
            // 
            // p_temp
            // 
            this.p_temp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p_temp.BackgroundImage")));
            this.p_temp.Controls.Add(this.lb_temp);
            this.p_temp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.p_temp.Location = new System.Drawing.Point(12, 0);
            this.p_temp.Name = "p_temp";
            this.p_temp.Size = new System.Drawing.Size(125, 108);
            this.p_temp.TabIndex = 2;
            this.p_temp.Click += new System.EventHandler(this.p_temp_Click);
            // 
            // lb_temp
            // 
            this.lb_temp.AutoSize = true;
            this.lb_temp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(36)))), ((int)(((byte)(54)))));
            this.lb_temp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lb_temp.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb_temp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(122)))), ((int)(((byte)(58)))));
            this.lb_temp.Location = new System.Drawing.Point(19, 44);
            this.lb_temp.Name = "lb_temp";
            this.lb_temp.Size = new System.Drawing.Size(81, 42);
            this.lb_temp.TabIndex = 1;
            this.lb_temp.Text = "0°C";
            this.lb_temp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_temp.Click += new System.EventHandler(this.p_temp_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.label5.Location = new System.Drawing.Point(207, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 33);
            this.label5.TabIndex = 4;
            this.label5.Text = "PORT";
            // 
            // cb_ports
            // 
            this.cb_ports.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(17)))), ((int)(((byte)(31)))));
            this.cb_ports.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_ports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_ports.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cb_ports.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.cb_ports.FormattingEnabled = true;
            this.cb_ports.IntegralHeight = false;
            this.cb_ports.ItemHeight = 33;
            this.cb_ports.Location = new System.Drawing.Point(167, 40);
            this.cb_ports.Name = "cb_ports";
            this.cb_ports.Size = new System.Drawing.Size(192, 41);
            this.cb_ports.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.label6.Location = new System.Drawing.Point(409, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 33);
            this.label6.TabIndex = 4;
            this.label6.Text = "BAUDRATE";
            // 
            // cb_baudRate
            // 
            this.cb_baudRate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(17)))), ((int)(((byte)(31)))));
            this.cb_baudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_baudRate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_baudRate.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cb_baudRate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.cb_baudRate.FormattingEnabled = true;
            this.cb_baudRate.IntegralHeight = false;
            this.cb_baudRate.ItemHeight = 33;
            this.cb_baudRate.Items.AddRange(new object[] {
            "300",
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.cb_baudRate.Location = new System.Drawing.Point(385, 40);
            this.cb_baudRate.Name = "cb_baudRate";
            this.cb_baudRate.Size = new System.Drawing.Size(192, 41);
            this.cb_baudRate.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Yi Baiti", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(188, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(380, 37);
            this.label7.TabIndex = 7;
            this.label7.Text = "ATABEYGAZI TELEMETRY";
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // p_logs
            // 
            this.p_logs.AutoSize = true;
            this.p_logs.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.p_logs.Controls.Add(this.lb_add);
            this.p_logs.Controls.Add(this.lb_sub);
            this.p_logs.Controls.Add(this.bt_saveLogs);
            this.p_logs.Controls.Add(this.bt_showLogs);
            this.p_logs.Controls.Add(this.bt_clearLogs);
            this.p_logs.Controls.Add(this.tb_logs);
            this.p_logs.Controls.Add(this.label8);
            this.p_logs.Dock = System.Windows.Forms.DockStyle.Top;
            this.p_logs.Location = new System.Drawing.Point(0, 476);
            this.p_logs.Name = "p_logs";
            this.p_logs.Size = new System.Drawing.Size(768, 427);
            this.p_logs.TabIndex = 12;
            // 
            // lb_add
            // 
            this.lb_add.AutoSize = true;
            this.lb_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lb_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lb_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb_add.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.lb_add.Location = new System.Drawing.Point(126, 1);
            this.lb_add.Margin = new System.Windows.Forms.Padding(0);
            this.lb_add.Name = "lb_add";
            this.lb_add.Size = new System.Drawing.Size(24, 25);
            this.lb_add.TabIndex = 15;
            this.lb_add.Text = "+";
            this.lb_add.Click += new System.EventHandler(this.lb_add_Click);
            // 
            // lb_sub
            // 
            this.lb_sub.AutoSize = true;
            this.lb_sub.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lb_sub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lb_sub.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb_sub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.lb_sub.Location = new System.Drawing.Point(109, -1);
            this.lb_sub.Margin = new System.Windows.Forms.Padding(0);
            this.lb_sub.Name = "lb_sub";
            this.lb_sub.Size = new System.Drawing.Size(19, 25);
            this.lb_sub.TabIndex = 14;
            this.lb_sub.Text = "-";
            this.lb_sub.Click += new System.EventHandler(this.lb_sub_Click);
            // 
            // tb_logs
            // 
            this.tb_logs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(36)))), ((int)(((byte)(54)))));
            this.tb_logs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_logs.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_logs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.tb_logs.Location = new System.Drawing.Point(20, 26);
            this.tb_logs.Multiline = true;
            this.tb_logs.Name = "tb_logs";
            this.tb_logs.ReadOnly = true;
            this.tb_logs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_logs.Size = new System.Drawing.Size(734, 378);
            this.tb_logs.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.label8.Location = new System.Drawing.Point(24, 0);
            this.label8.Margin = new System.Windows.Forms.Padding(0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 24);
            this.label8.TabIndex = 0;
            this.label8.Text = "LOGLAR";
            // 
            // toolTip1
            // 
            this.toolTip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(36)))), ((int)(((byte)(54)))));
            this.toolTip1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // pLayout1
            // 
            this.pLayout1.Controls.Add(this.pictureBox1);
            this.pLayout1.Controls.Add(this.bt_minimize);
            this.pLayout1.Controls.Add(this.bt_close);
            this.pLayout1.Controls.Add(this.bt_settings);
            this.pLayout1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pLayout1.Location = new System.Drawing.Point(0, 0);
            this.pLayout1.Name = "pLayout1";
            this.pLayout1.Size = new System.Drawing.Size(768, 100);
            this.pLayout1.TabIndex = 14;
            this.pLayout1.Click += new System.EventHandler(this.pLayout1_Click_1);
            this.pLayout1.Paint += new System.Windows.Forms.PaintEventHandler(this.pLayout1_Paint);
            this.pLayout1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pLayout1_MouseDown);
            this.pLayout1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pLayout1_MouseMove);
            this.pLayout1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pLayout1_MouseUp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(69, 66);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // bt_minimize
            // 
            this.bt_minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_minimize.Image = ((System.Drawing.Image)(resources.GetObject("bt_minimize.Image")));
            this.bt_minimize.Location = new System.Drawing.Point(654, 22);
            this.bt_minimize.Name = "bt_minimize";
            this.bt_minimize.Size = new System.Drawing.Size(43, 43);
            this.bt_minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.bt_minimize.TabIndex = 1;
            this.bt_minimize.TabStop = false;
            this.bt_minimize.Click += new System.EventHandler(this.bt_minimize_Click);
            // 
            // bt_close
            // 
            this.bt_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_close.Image = ((System.Drawing.Image)(resources.GetObject("bt_close.Image")));
            this.bt_close.Location = new System.Drawing.Point(713, 22);
            this.bt_close.Name = "bt_close";
            this.bt_close.Size = new System.Drawing.Size(43, 43);
            this.bt_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bt_close.TabIndex = 1;
            this.bt_close.TabStop = false;
            this.bt_close.Click += new System.EventHandler(this.bt_close_Click);
            // 
            // bt_settings
            // 
            this.bt_settings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_settings.Image = ((System.Drawing.Image)(resources.GetObject("bt_settings.Image")));
            this.bt_settings.Location = new System.Drawing.Point(595, 22);
            this.bt_settings.Name = "bt_settings";
            this.bt_settings.Size = new System.Drawing.Size(43, 43);
            this.bt_settings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bt_settings.TabIndex = 1;
            this.bt_settings.TabStop = false;
            this.bt_settings.Click += new System.EventHandler(this.bt_settings_Click);
            this.bt_settings.MouseHover += new System.EventHandler(this.bt_settings_MouseHover);
            // 
            // pLayout2
            // 
            this.pLayout2.Controls.Add(this.lb_speed);
            this.pLayout2.Controls.Add(this.pictureBox4);
            this.pLayout2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pLayout2.Location = new System.Drawing.Point(0, 208);
            this.pLayout2.Name = "pLayout2";
            this.pLayout2.Size = new System.Drawing.Size(768, 86);
            this.pLayout2.TabIndex = 15;
            this.pLayout2.Paint += new System.Windows.Forms.PaintEventHandler(this.pLayout2_Paint);
            // 
            // lb_speed
            // 
            this.lb_speed.AutoSize = true;
            this.lb_speed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(36)))), ((int)(((byte)(54)))));
            this.lb_speed.Font = new System.Drawing.Font("Microsoft Sans Serif", 27F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb_speed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.lb_speed.Location = new System.Drawing.Point(354, 30);
            this.lb_speed.Name = "lb_speed";
            this.lb_speed.Size = new System.Drawing.Size(57, 40);
            this.lb_speed.TabIndex = 7;
            this.lb_speed.Text = "00";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::telemetry.Properties.Resources.Hız;
            this.pictureBox4.Location = new System.Drawing.Point(322, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(125, 86);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 2;
            this.pictureBox4.TabStop = false;
            // 
            // pb_race
            // 
            this.pb_race.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_race.Image = ((System.Drawing.Image)(resources.GetObject("pb_race.Image")));
            this.pb_race.Location = new System.Drawing.Point(644, 40);
            this.pb_race.Name = "pb_race";
            this.pb_race.Size = new System.Drawing.Size(41, 41);
            this.pb_race.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_race.TabIndex = 7;
            this.pb_race.TabStop = false;
            this.pb_race.Click += new System.EventHandler(this.pb_race_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.pb_race);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.bt_refresh);
            this.panel3.Controls.Add(this.bt_connect);
            this.panel3.Controls.Add(this.cb_ports);
            this.panel3.Controls.Add(this.cb_baudRate);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 294);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(768, 91);
            this.panel3.TabIndex = 16;
            // 
            // bt_refresh
            // 
            this.bt_refresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_refresh.Image = ((System.Drawing.Image)(resources.GetObject("bt_refresh.Image")));
            this.bt_refresh.Location = new System.Drawing.Point(288, 11);
            this.bt_refresh.Name = "bt_refresh";
            this.bt_refresh.Size = new System.Drawing.Size(21, 24);
            this.bt_refresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bt_refresh.TabIndex = 5;
            this.bt_refresh.TabStop = false;
            this.bt_refresh.Click += new System.EventHandler(this.bt_refresh_Click);
            // 
            // bt_connect
            // 
            this.bt_connect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_connect.Image = ((System.Drawing.Image)(resources.GetObject("bt_connect.Image")));
            this.bt_connect.Location = new System.Drawing.Point(597, 40);
            this.bt_connect.Name = "bt_connect";
            this.bt_connect.Size = new System.Drawing.Size(41, 41);
            this.bt_connect.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bt_connect.TabIndex = 5;
            this.bt_connect.TabStop = false;
            this.bt_connect.Click += new System.EventHandler(this.bt_connect_Click);
            this.bt_connect.MouseHover += new System.EventHandler(this.bt_connect_MouseHover);
            // 
            // pLayout3
            // 
            this.pLayout3.Dock = System.Windows.Forms.DockStyle.Top;
            this.pLayout3.Location = new System.Drawing.Point(0, 385);
            this.pLayout3.Name = "pLayout3";
            this.pLayout3.Size = new System.Drawing.Size(768, 11);
            this.pLayout3.TabIndex = 17;
            // 
            // pLayout4
            // 
            this.pLayout4.Dock = System.Windows.Forms.DockStyle.Top;
            this.pLayout4.Location = new System.Drawing.Point(0, 451);
            this.pLayout4.Name = "pLayout4";
            this.pLayout4.Size = new System.Drawing.Size(768, 25);
            this.pLayout4.TabIndex = 18;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 396);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(768, 55);
            this.panel2.TabIndex = 19;
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 955);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(768, 51);
            this.panel1.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Yi Baiti", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(618, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 29);
            this.label1.TabIndex = 9;
            this.label1.Text = "12.12.2019";
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(30, 6);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(719, 1);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 8;
            this.pictureBox8.TabStop = false;
            // 
            // pLayout5
            // 
            this.pLayout5.Dock = System.Windows.Forms.DockStyle.Top;
            this.pLayout5.Location = new System.Drawing.Point(0, 903);
            this.pLayout5.Name = "pLayout5";
            this.pLayout5.Size = new System.Drawing.Size(768, 52);
            this.pLayout5.TabIndex = 21;
            // 
            // tm_fakeData
            // 
            this.tm_fakeData.Interval = 1000;
            this.tm_fakeData.Tick += new System.EventHandler(this.tm_fakeData_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(612, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "-";
            this.label2.Click += new System.EventHandler(this.label2_Click_2);
            // 
            // bt_saveLogs
            // 
            this.bt_saveLogs.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_saveLogs.BackgroundImage")));
            this.bt_saveLogs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_saveLogs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_saveLogs.Location = new System.Drawing.Point(583, 382);
            this.bt_saveLogs.Name = "bt_saveLogs";
            this.bt_saveLogs.Size = new System.Drawing.Size(42, 42);
            this.bt_saveLogs.TabIndex = 13;
            this.bt_saveLogs.UseVisualStyleBackColor = true;
            this.bt_saveLogs.Click += new System.EventHandler(this.bt_saveLogs_Click);
            this.bt_saveLogs.MouseHover += new System.EventHandler(this.bt_saveLogs_MouseHover);
            // 
            // bt_showLogs
            // 
            this.bt_showLogs.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_showLogs.BackgroundImage")));
            this.bt_showLogs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_showLogs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_showLogs.Location = new System.Drawing.Point(679, 382);
            this.bt_showLogs.Name = "bt_showLogs";
            this.bt_showLogs.Size = new System.Drawing.Size(42, 42);
            this.bt_showLogs.TabIndex = 13;
            this.bt_showLogs.UseVisualStyleBackColor = true;
            this.bt_showLogs.Click += new System.EventHandler(this.bt_showLogs_Click);
            this.bt_showLogs.MouseHover += new System.EventHandler(this.bt_showLogs_MouseHover);
            // 
            // bt_clearLogs
            // 
            this.bt_clearLogs.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_clearLogs.BackgroundImage")));
            this.bt_clearLogs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_clearLogs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_clearLogs.Location = new System.Drawing.Point(631, 382);
            this.bt_clearLogs.Name = "bt_clearLogs";
            this.bt_clearLogs.Size = new System.Drawing.Size(42, 42);
            this.bt_clearLogs.TabIndex = 13;
            this.bt_clearLogs.UseVisualStyleBackColor = true;
            this.bt_clearLogs.Click += new System.EventHandler(this.bt_clearLogs_Click);
            this.bt_clearLogs.MouseHover += new System.EventHandler(this.bt_clearLogs_MouseHover);
            // 
            // Main
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(17)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(768, 1024);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pLayout5);
            this.Controls.Add(this.p_logs);
            this.Controls.Add(this.pLayout4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pLayout3);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pLayout2);
            this.Controls.Add(this.p_info);
            this.Controls.Add(this.pLayout1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.Click += new System.EventHandler(this.Main_Click);
            this.p_info.ResumeLayout(false);
            this.p_info.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.p_speed.ResumeLayout(false);
            this.p_speed.PerformLayout();
            this.p_current.ResumeLayout(false);
            this.p_current.PerformLayout();
            this.p_temp.ResumeLayout(false);
            this.p_temp.PerformLayout();
            this.p_logs.ResumeLayout(false);
            this.p_logs.PerformLayout();
            this.pLayout1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bt_minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bt_close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bt_settings)).EndInit();
            this.pLayout2.ResumeLayout(false);
            this.pLayout2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_race)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bt_refresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bt_connect)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox bt_close;
        private System.Windows.Forms.PictureBox bt_settings;
        private System.Windows.Forms.Panel p_info;
        private System.Windows.Forms.Panel p_speed;
        private System.Windows.Forms.Panel p_current;
        private System.Windows.Forms.Panel p_temp;
        private System.Windows.Forms.Label lb_battery;
        private System.Windows.Forms.Label lb_temp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox bt_refresh;
        private System.Windows.Forms.ComboBox cb_ports;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cb_baudRate;
        private System.Windows.Forms.PictureBox bt_connect;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.PictureBox bt_minimize;
        private System.Windows.Forms.Panel p_logs;
        private System.Windows.Forms.TextBox tb_logs;
        private System.Windows.Forms.Label label8;
        private CircularButton bt_saveLogs;
        private CircularButton bt_clearLogs;
        private CircularButton bt_showLogs;
        private System.Windows.Forms.Label lb_current;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel pLayout1;
        private System.Windows.Forms.Panel pLayout2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel pLayout3;
        private System.Windows.Forms.Panel pLayout4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pLayout5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_engine;
        private System.Windows.Forms.Label lb_voltage;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lb_watt;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label lb_speed;
        private System.Windows.Forms.Timer tm_fakeData;
        private System.Windows.Forms.Label lb_add;
        private System.Windows.Forms.Label lb_sub;
        private System.Windows.Forms.PictureBox pb_race;
        private System.Windows.Forms.Label label2;
    }
}