using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using telemetry.Properties;
using telemetry.classes;
using Newtonsoft.Json;
using System.Globalization;
using System.Diagnostics;

namespace telemetry
{
    public partial class Main : Form
    {
        /// <summary>
        /// Developed by Mehmet SÜMER, Mehmet YILDIZ
        /// Github: mehmetsumer, mehmetcanyildiz
        /// </summary>
        public Main()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        private DateTime StartDate;
        private bool FirstDataReceived = false;
        private const int cellCount = 26;
        public static int distance = 0, watt = 0, dataCount = 0, AverageWatt = 0, TotalWatt = 0;
        int speed = 0;
        double current = 0.0, battery = 0.0, temp1 = 0.0, temp2 = 0.0,
        temp3 = 0.0, temp4 = 0.0, tempAv = 0.0, totalVoltage = 0.0,
            minVoltage = 0.0, maxVoltage = 0.0, engineTemp = 0.0;

        public static CustomAlerts alert;

        private SettingsControl settingsControl = new SettingsControl();
        private TempControl tempControl = new TempControl();
        //private CurrentControl currentControl = new CurrentControl();
        private BatteryControl batteryControl = new BatteryControl();
        private string[] ports;
        
        private bool IsBigger = false;
		// ÖZEL NESNELER
        CustomLabel lb_temp1, lb_temp2, lb_temp3, lb_temp4;
        CustomLabel lb_totalVoltage, lb_minVoltage, lb_maxVoltage;
        List<CustomProgress> batteryCells;

        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        /*private Color colorHover = System.Drawing.ColorTranslator.FromHtml("#152436");
        private Color colorDefault = System.Drawing.ColorTranslator.FromHtml("#0E111F");
        private Color colorPanels = System.Drawing.ColorTranslator.FromHtml("#152436");
        private Color colorGreen = System.Drawing.ColorTranslator.FromHtml("#4DB23A");
        private Color colorRed = System.Drawing.ColorTranslator.FromHtml("#FF2929");
        private Color colorRefresh = System.Drawing.ColorTranslator.FromHtml("#00B9FF");*/

        public static string getImage(string fName) {
            return Directory.GetCurrentDirectory() + @"\images\" + fName + ".png";
        }
		


        void resizeForm() {			
            int height = Screen.PrimaryScreen.Bounds.Height;
            if (this.Height >= height) // Form ekrana sığmadıysa yapılacak işlemler.
            {
                this.Size = new Size(this.Width, (height-35));
                pLayout2.Height = 5; // 86 - 81
                pLayout3.Height = 2; // 11 - 9
                pLayout4.Height = 5; // 25 - 20
                pLayout5.Height = 1; // 20
                int fark = (p_logs.Height + p_logs.Location.Y) - this.Size.Height;
                tb_logs.Height -= (fark + 55);
                int btnLoc = tb_logs.Location.Y + tb_logs.Height - 18;
                bt_saveLogs.Location = new Point(583, btnLoc);
                bt_clearLogs.Location = new Point(631, btnLoc);
                bt_showLogs.Location = new Point(679, btnLoc);
                IsBigger = true;
            }
        }
		
        void addControls() {
            int width = 744, heigth = 706; // Kontrolün boyutları.
            int x = 12, y = 210; // Kontrolün pozisyonu.               
            if (IsBigger) { // Form ekrana sığmadıysa yapılacak işlemler.
                y = 240;
                int fark = (y + heigth) - this.Height; // taşan kısmın boyutu alınıyor.
                heigth -= (fark + 50); // kontrolün yüksekliğinden taşan kısım + marginler çıkarılıyor.
            }
            settingsControl.Size = new Size(width, heigth);
            settingsControl.Location = new Point(x, y);
            this.Controls.Add(settingsControl);
            settingsControl.BringToFront();
            settingsControl.Visible = false;

            tempControl.Size = new Size(width, heigth);
            tempControl.Location = new Point(x, y);      
            this.Controls.Add(tempControl);
            tempControl.BringToFront();
            tempControl.Visible = false;
            
            /*currentControl.Size = new Size(width, heigth);
            currentControl.Location = new Point(x, y);
            this.Controls.Add(currentControl);
            currentControl.BringToFront();
            currentControl.Visible = false;*/

            batteryControl.Size = new Size(width, heigth);
            batteryControl.Location = new Point(x, y);
            this.Controls.Add(batteryControl);
            batteryControl.BringToFront();
            batteryControl.Visible = false;

            /* lb_totalVoltage = new CustomLabel(batteryControl, "lb_totalVoltage", "Toplam Gerilim:", 170, 120, 55, 40);
             lb_minVoltage = new CustomLabel(batteryControl, "lb_minVoltage", "En Düşük:", 50, 220, 55, 40);
             lb_maxVoltage = new CustomLabel(batteryControl, "lb_maxVoltage", "En Yüksek:", 390, 220, 55, 40);*/
           
            lb_totalVoltage = new CustomLabel(batteryControl, "lb_totalVoltage", "Toplam Gerilim:", 50, 65, 55, 40, "Arial", FontStyle.Regular, 12);
            lb_minVoltage = new CustomLabel(batteryControl, "lb_minVoltage", "En Düşük:", 275, 65, 55, 40, "Arial", FontStyle.Regular, 12);
            lb_maxVoltage = new CustomLabel(batteryControl, "lb_maxVoltage", "En Yüksek:", 500, 65, 55, 40, "Arial", FontStyle.Regular, 12);
            // DİNAMİK LABEL ATAMA
            /*
             * lb_temp1 = new CustomLabel(tempControl, "lb_temp1", "-", 120, 118, 55, 40, "Arial", FontStyle.Regular, 36);
             *                              kontrol, yazı, x, y, genişlik, yükseklik, font adı, font stili, font boyutu
             *                                                                          bunları yazmak zorunlu değil, default şekilde ayarlanır.
            temp1.Text("SLM SLM SLM");*/
            // SICAKLIKLAR
            lb_temp1 = new CustomLabel(tempControl, "lb_temp1", "BT1:", 120, 120, 55, 40);
            lb_temp2 = new CustomLabel(tempControl, "lb_temp2", "BT2:", 450, 120, 55, 40);
            lb_temp3 = new CustomLabel(tempControl, "lb_temp3", "BT3:", 120, 220, 55, 40);
            lb_temp4 = new CustomLabel(tempControl, "lb_temp4", "BT4:", 450, 220, 55, 40);

            // 26 BATARYA HÜCRESİ
            batteryCells = new List<CustomProgress>();
            int yatay = 50, dikey = 120;
            for (int i = 0; i < 26; i++)
            {
                if (i % 3 == 0 && i != 0) { yatay = 50; dikey += 65; }
                batteryCells.Add(new CustomProgress(
                    batteryControl,
                    "pb_cell" + i.ToString(),
                    (i+1).ToString() + ".Hücre",
                    yatay,
                    dikey                  
                ));
                yatay += 225;
            }
            
            /*batteryCells[0].Value("3.7");
            batteryCells[1].Value("2.7");
            batteryCells[2].Value("1.7");
            batteryCells[3].Value("3");
            batteryCells[4].Value("4.2");*/
            // DİĞER PENCERELERİ DE EKLE.
        }
        
		void hideControls() {
            settingsControl.Hide();
            tempControl.Hide();
            //currentControl.Hide();
            batteryControl.Hide();
        }
		
        void setToopTip(Control btn, string title, string caption)
        {
            toolTip1.ToolTipTitle = title;
            toolTip1.SetToolTip(btn, caption);
        }
		
        void getPorts()
        {
            cb_ports.Items.Clear();
            ports = SerialPort.GetPortNames();
            foreach (var port in ports) { cb_ports.Items.Add(port); }
            if (cb_ports.Items.Count == 0) cb_ports.Items.Add("Bulunamadı");
            cb_ports.SelectedIndex = 0;
        }

		
        private void bt_close_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
		
        private void Main_Load(object sender, EventArgs e) {          
            if (serialPort1.IsOpen) serialPort1.Close();
            label1.Text = DateTime.Today.ToShortDateString();
            cb_baudRate.SelectedIndex = 7; // 38400
            resizeForm();
            addControls();
            Logger.CreateLogFolder();
            Logger.CreateLogFolder("Tubitak");
            bt_connect.ImageLocation = getImage("connect");
            getPorts();
            alert = new CustomAlerts(this.Controls["panel2"].Controls, 167, 0);
        }

        public void WriteLine(string message)
        {
            if (serialPort1.IsOpen) serialPort1.WriteLine(message);
            alert.Show("KM SIFIRLANDI", "success");
        }
		
        private void bt_connect_Click(object sender, EventArgs e) {
            // FAKEDATA CONNECT
            //try
            //{
            //    if (bt_connect.ImageLocation == getImage("connect")) //BAĞLAN
            //    {
            //        if (!tm_fakeData.Enabled)
            //        {
            //            bt_connect.ImageLocation = getImage("disconnect");
            //            alert.Show("Bağlantı başarıyla kuruldu.", "success");
            //            fakeDist = 0;                      
            //            if (!FirstDataReceived)
            //            {             
            //                FirstDataReceived = true;
            //                StartDate = DateTime.Now;
            //            }
            //            tm_fakeData.Enabled = true;
            //            bt_refresh.Enabled = cb_ports.Enabled = cb_baudRate.Enabled = false;                 
            //        }
            //    }
            //    else //BAĞLANTIYI KES
            //    {
            //        bt_connect.ImageLocation = getImage("connect");
            //        alert.Show("Bağlantı kesildi.", "danger");
            //        if (tm_fakeData.Enabled) tm_fakeData.Enabled = false;
            //        bt_refresh.Enabled = cb_ports.Enabled = cb_baudRate.Enabled = true;
            //    }
            //}
            //catch (Exception x)
            //{
            //    bt_connect.ImageLocation = getImage("connect");
            //    alert.Show(x.Message, "danger");
            //    if (tm_fakeData.Enabled) tm_fakeData.Enabled = false;
            //    bt_refresh.Enabled = cb_ports.Enabled = cb_baudRate.Enabled = true;
            //}
            // FAKEDATA CONNECT END

            try
            {
                if (bt_connect.ImageLocation == getImage("connect")) //BAĞLAN
                {
                    if (!serialPort1.IsOpen)
                    {
                        serialPort1.PortName = cb_ports.Text;
                        serialPort1.BaudRate = Convert.ToInt32(cb_baudRate.Text);
                        serialPort1.Open();
                        bt_connect.ImageLocation = getImage("disconnect");
                        alert.Show("Bağlantı kuruldu.", "success");
                        bt_refresh.Enabled = cb_ports.Enabled = cb_baudRate.Enabled = false;
                    }
                }
                else //BAĞLANTIYI KES
                {
                    if (serialPort1.IsOpen) serialPort1.Close();
                    bt_connect.ImageLocation = getImage("connect");
                    alert.Show("Bağlantı kesildi.", "danger");
                    bt_refresh.Enabled = cb_ports.Enabled = cb_baudRate.Enabled = true;
                }
            }
            catch (Exception x)
            {
                //if (serialPort1.IsOpen) serialPort1.Close();
                bt_connect.ImageLocation = getImage("connect");
                alert.Show(x.Message, "danger");
                bt_refresh.Enabled = cb_ports.Enabled = cb_baudRate.Enabled = true;
            }
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e) {
            try
            {
                // TODO: DEĞERLER EKSİ GELDİĞİNDE GÖSTERMESİN.
                //Debug.WriteLine(serialPort1.ReadLine());
                var json = JsonConvert.DeserializeObject<Dictionary<string, dynamic>>(serialPort1.ReadLine());
                if (json.ContainsKey("current")) current = Convert.ToDouble(json["current"]);
                if (json.ContainsKey("battery")) battery = Convert.ToDouble(json["battery"]);
                if (json.ContainsKey("speed")) speed = Convert.ToInt32(json["speed"]);
                if (json.ContainsKey("temp1")) temp1 = Convert.ToDouble(json["temp1"]);
                if (json.ContainsKey("temp2")) temp2 = Convert.ToDouble(json["temp2"]);
                if (json.ContainsKey("temp3")) temp3 = Convert.ToDouble(json["temp3"]);
                if (json.ContainsKey("temp4")) temp4 = Convert.ToDouble(json["temp4"]);
                if (json.ContainsKey("tempAv")) tempAv = Convert.ToDouble(json["tempAv"]);
                if (json.ContainsKey("totalVoltage")) totalVoltage = Convert.ToDouble(json["totalVoltage"]);
                if (json.ContainsKey("minVoltage")) minVoltage = Convert.ToDouble(json["minVoltage"]);
                if (json.ContainsKey("maxVoltage")) maxVoltage = Convert.ToDouble(json["maxVoltage"]);
                if (json.ContainsKey("engineTemp")) engineTemp = (json["engineTemp"].ToString() == "nan" ? 0.0 : Convert.ToDouble(json["engineTemp"]));
                if (json.ContainsKey("watt")) watt = Convert.ToInt32(json["watt"]);
                if (json.ContainsKey("distance")) distance = Convert.ToInt32(json["distance"]);

                if (current < 0) { current = 0.0; }

                dataCount++;
                TotalWatt += watt;
                AverageWatt = (int)Math.Round((double)TotalWatt / dataCount);

                lb_current.Text = current + "A";
                lb_temp.Text = tempAv + "°C";
                setColorByTemp(tempAv, lb_temp);
                setColorByTemp(engineTemp, lb_engine);
                lb_engine.Text = engineTemp + "°C";
                lb_speed.Text = speed.ToString();
                lb_battery.Text = battery + "%";
                lb_totalVoltage.Text(totalVoltage.ToString(), "Toplam Gerilim: ");

                lb_minVoltage.Text(minVoltage.ToString(), "En Düşük: ");
                lb_maxVoltage.Text(maxVoltage.ToString(), "En Yüksek: ");
                lb_temp1.Text(temp1.ToString(), "BT1: ", color: true);
                lb_temp2.Text(temp2.ToString(), "BT2: ", color: true);
                lb_temp3.Text(temp3.ToString(), "BT3: ", color: true);
                lb_temp4.Text(temp4.ToString(), "BT4: ", color: true);

                lb_voltage.Text = totalVoltage.ToString();
                lb_watt.Text = watt.ToString();

                for (int i = 0; i < cellCount; i++)
                {                 
                    if (json.ContainsKey("voltages" + i)) batteryCells[i].Value(Convert.ToDouble(json["voltages" + i].Replace(".", ",")));
                }

                // LOG KAYITLARI
                int timePassed = (int)Math.Round((DateTime.Now - StartDate).TotalMilliseconds);
               
                string TubitakLog = timePassed + "," + speed + "," + (tempAv * 100) + "," + (totalVoltage * 100) + "," + watt + "\r\n";

                string log = "Akım: " + current + " A" +
                             "\r\nToplam Gerilim: " + totalVoltage + " V, En Düşük: " + minVoltage + " V, En Yüksek: " + maxVoltage + " V" +
                             "\r\nHücre Gerilimleri: ";
                for (int i = 0; i < 26; i++)
                {
                    if (i % 7 == 0) log += "\r\n";
                    if (json.ContainsKey("voltages" + i))
                    {
                        log += (i + 1).ToString() + ") " + json["voltages" + i] + " V";
                        if (i != 25) log += ", ";
                    }
                }
                log += "\r\nGüç: " + watt + " W" +
                       "\r\nMotor Sıcaklığı: " + engineTemp + " °C" +
                       "\r\n1.Sıcaklık: " + temp1 + " °C, 2.Sıcaklık: " + temp2 + " °C, 3.Sıcaklık: " + temp3 + " °C, 4.Sıcaklık: " + temp4 + " °C" +
                       "\r\nOrtalama Sıcaklık: " + tempAv + " °C" +
                       "\r\nHız: " + speed + " km/s" +
                       "\r\nBatarya Şarjı: " + battery + " %" +
                       "\r\nTarih: " + DateTime.Now + "\r\n\r\n";
                tb_logs.AppendText(log);
                //tb_logs.AppendText(TubitakLog);
                if (Setting.GetSettings("saveLogsAuto"))
                {
                    Logger.SaveTubitakLogs(log: TubitakLog, date: StartDate);
                    Logger.SaveLogs(log);
                }
            }
            catch (Exception x)
            {
                //Debug.WriteLine(x.StackTrace);
                alert.Show(x.Message, "danger");
            }
        }

        public static int fakeDist = 0;
        private void tm_fakeData_Tick(object sender, EventArgs e)
        {
            //try
            {
                // TODO: DEĞERLER EKSİ GELDİĞİNDE GÖSTERMESİN.
                var json = JsonConvert.DeserializeObject<Dictionary<string, dynamic>>(
                    "{ 'current': 0.0, 'battery': 98, 'speed': 10, " +
                    "'temp1': 20, 'temp2': 35,'temp3': 65, 'temp4': 24, 'tempAv': 22.25, " +
                    "'totalVoltage': 101.8, 'minVoltage': 3.4, 'maxVoltage': 4.7, 'engineTemp': 31, " +
                    "'watt': 1200, 'voltages0': 3.4, 'voltages1': 3.4, 'voltages2': 3.4, " +
                    "'voltages3': 3.4, 'voltages4': 3.4, 'voltages5': 3.4, 'voltages6': 3.4, " +
                    "'voltages7': 3.4, 'voltages8': 3.4, 'voltages9': 3.4, " +
                    "'voltages10': 3.4, 'voltages11': 3.4, 'voltages12': 3.4, 'voltages13': 3.4, " +
                    "'voltages14': 3.4, 'voltages15': 3.4, 'voltages16': 3.4, " +
                    "'voltages17': 3.4, 'voltages18': 3.4, 'voltages19': 3.4, 'voltages20': 3.4, " +
                    "'voltages21': 3.4, 'voltages22': 3.4, 'voltages23': 3.4, " +
                    "'voltages24': 3.4, 'voltages25': 3.4, 'distance': "+ fakeDist+"}"); 
                if (json.ContainsKey("current")) current = json["current"];
                if (json.ContainsKey("battery")) battery = json["battery"];
                if (json.ContainsKey("speed")) speed = (int)json["speed"];
                if (json.ContainsKey("temp1")) temp1 = json["temp1"];
                if (json.ContainsKey("temp2")) temp2 = json["temp2"];
                if (json.ContainsKey("temp3")) temp3 = json["temp3"];
                if (json.ContainsKey("temp4")) temp4 = json["temp4"];
                if (json.ContainsKey("tempAv")) tempAv = json["tempAv"];
                if (json.ContainsKey("totalVoltage")) totalVoltage = json["totalVoltage"];
                if (json.ContainsKey("minVoltage")) minVoltage = json["minVoltage"];
                if (json.ContainsKey("maxVoltage")) maxVoltage = json["maxVoltage"];
                if (json.ContainsKey("engineTemp")) engineTemp = json["engineTemp"];
                if (json.ContainsKey("watt")) watt = (int)json["watt"];
                if (json.ContainsKey("distance")) distance = (int)json["distance"];

                if (current < 0) { current = 0.0; }

                dataCount++;
                TotalWatt += watt;
                AverageWatt = (int)Math.Round((double)TotalWatt / dataCount);

                lb_current.Text = current + "A";
                lb_temp.Text = tempAv + "°C";
                setColorByTemp(tempAv, lb_temp);
                setColorByTemp(engineTemp, lb_engine);
                lb_engine.Text = engineTemp + "°C";
                lb_speed.Text = speed.ToString();
                lb_battery.Text = battery + "%";
                lb_totalVoltage.Text(totalVoltage.ToString(), "Toplam Gerilim: ");

                lb_minVoltage.Text(minVoltage.ToString(), "En Düşük: ");
                lb_maxVoltage.Text(maxVoltage.ToString(), "En Yüksek: ");
                lb_temp1.Text(temp1.ToString(), "BT1: ", color: true);
                lb_temp2.Text(temp2.ToString(), "BT2: ", color: true);
                lb_temp3.Text(temp3.ToString(), "BT3: ", color: true);
                lb_temp4.Text(temp4.ToString(), "BT4: ", color: true);

                lb_voltage.Text = totalVoltage.ToString();
                lb_watt.Text = watt.ToString();

                for (int i = 0; i < cellCount; i++)
                {
                    if (json.ContainsKey("voltages" + i)) batteryCells[i].Value(json["voltages" + i]);
                }
                int timePassed = (int)Math.Round((DateTime.Now - StartDate).TotalMilliseconds);
                // LOG KAYITLARI
                string TubitakLog = timePassed + "," + speed + "," + (tempAv * 100) + "," + (totalVoltage * 100) + "," + watt + "\r\n";

                string log = "Akım: " + current + " A" +
                             "\r\nToplam Gerilim: " + totalVoltage + " V, En Düşük: " + minVoltage + " V, En Yüksek: " + maxVoltage + " V" +
                             "\r\nHücre Gerilimleri: ";
                for (int i = 0; i < 26; i++)
                {
                    if (i % 7 == 0) log += "\r\n";
                    if (json.ContainsKey("voltages" + i))
                    {
                        log += (i + 1).ToString() + ") " + json["voltages" + i] + " V";
                        if (i != 25) log += ", ";
                    }
                }
                log += "\r\nGüç: " + watt + " W" +
                       "\r\nMotor Sıcaklığı: " + engineTemp + " °C" +
                       "\r\n1.Sıcaklık: " + temp1 + " °C, 2.Sıcaklık: " + temp2 + " °C, 3.Sıcaklık: " + temp3 + " °C, 4.Sıcaklık: " + temp4 + " °C" +
                       "\r\nOrtalama Sıcaklık: " + tempAv + " °C" +
                       "\r\nHız: " + speed + " km/s" +
                       "\r\nBatarya Şarjı: " + battery + " %" +
                       "\r\nTarih: " + DateTime.Now + "\r\n\r\n";
                tb_logs.AppendText(log);
                //tb_logs.AppendText(TubitakLog);
                if (Setting.GetSettings("saveLogsAuto"))
                {
                    Logger.SaveTubitakLogs(log: TubitakLog, date: StartDate);
                    Logger.SaveLogs(log);
                }
                fakeDist += 1;
            }
            /*catch (Exception x)
            {
                showAlert(x.Message, "danger");
            }*/
        }

        private Color getColorByTemp(double temp)
        {
            Color c = ColorTranslator.FromHtml("#6639B7");
            if (temp <= 10) c = ColorTranslator.FromHtml("#3E52B5");
            else if (temp <= 20) c = ColorTranslator.FromHtml("#5678FB");
            else if (temp <= 30) c = ColorTranslator.FromHtml("#04A8F4");
            else if (temp <= 40) c = ColorTranslator.FromHtml("#02BCD3");
            else if (temp <= 50) c = ColorTranslator.FromHtml("#009588");
            else if (temp <= 60) c = ColorTranslator.FromHtml("#269B24");
            else if (temp <= 70) c = ColorTranslator.FromHtml("#8AC14A");
            else if (temp <= 80) c = ColorTranslator.FromHtml("#FEC208");
            else if (temp <= 90) c = ColorTranslator.FromHtml("#FF9705");
            else if (temp > 90) c = ColorTranslator.FromHtml("#FD2A30");
            return c;
        }
        private void setColorByTemp(double temp, Control control)
        {
            Color c = ColorTranslator.FromHtml("#6639B7");
            if (temp <= 10) c = ColorTranslator.FromHtml("#3E52B5");
            else if (temp <= 20) c = ColorTranslator.FromHtml("#5678FB");
            else if (temp <= 30) c = ColorTranslator.FromHtml("#04A8F4");
            else if (temp <= 40) c = ColorTranslator.FromHtml("#02BCD3");
            else if (temp <= 50) c = ColorTranslator.FromHtml("#009588");
            else if (temp <= 60) c = ColorTranslator.FromHtml("#269B24");
            else if (temp <= 70) c = ColorTranslator.FromHtml("#8AC14A");
            else if (temp <= 80) c = ColorTranslator.FromHtml("#FEC208");
            else if (temp <= 90) c = ColorTranslator.FromHtml("#FF9705");
            else if (temp > 90) c = ColorTranslator.FromHtml("#FD2A30");
            control.ForeColor = c;
        }
		private void bt_refresh_Click(object sender, EventArgs e)
        {
            getPorts();
        }
        private void bt_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void p_speed_Click(object sender, EventArgs e)
        {
            /*if (!tempControl.Visible) { hideControls(); settingsControl.Show(); }
            else tempControl.Hide();*/
        }
        private void label2_Click_1(object sender, EventArgs e)
        {

        }
        private void lb_add_Click(object sender, EventArgs e)
        {
            tb_logs.Font = new Font(tb_logs.Font.FontFamily, (tb_logs.Font.Size + 2));
        }
        private void lb_sub_Click(object sender, EventArgs e)
        {
            tb_logs.Font = new Font(tb_logs.Font.FontFamily, (tb_logs.Font.Size - 2));
        }

        private void pLayout1_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }
        private void pLayout1_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }
        private void pLayout1_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
  
        private void pb_race_Click(object sender, EventArgs e)
        {
            Race r = new Race(this);
            r.Show();
            r.FormClosed += R_FormClosed;
            pb_race.Enabled = false;
        }

        private void R_FormClosed(object sender, FormClosedEventArgs e)
        {
            pb_race.Enabled = true;
            //throw new NotImplementedException();
        }

        private void label2_Click_2(object sender, EventArgs e)
        {
            StartDate = DateTime.Now;
        }

        private void tm_alert_Tick(object sender, EventArgs e)
        {

        }

        private void pLayout2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void p_current_Click(object sender, EventArgs e)
        {
            /*if (!currentControl.Visible) { hideControls(); currentControl.Show(); }
            else currentControl.Hide();*/
        }
        private void p_temp_Click(object sender, EventArgs e)
        {
            if (!tempControl.Visible) { hideControls(); tempControl.Show(); }
            else tempControl.Hide();
        }
        private void p_battery_Click(object sender, EventArgs e)
        {
            if (!batteryControl.Visible) { hideControls(); batteryControl.Show(); }
            else batteryControl.Hide();
        }
        private void bt_showLogs_Click(object sender, EventArgs e)
        {
            Logger.ShowLogs();

        }
        private void bt_clearLogs_Click(object sender, EventArgs e)
        {
            tb_logs.Text = "";
        }
        private void bt_saveLogs_Click(object sender, EventArgs e)
        {
            if (tb_logs.Text.Length > 5)
            {
                Logger.SaveLogs(tb_logs.Text, "log_custom_");
            } 
            else alert.Show("Log metni boş.","danger");
        }
        private void bt_saveLogs_MouseHover(object sender, EventArgs e)
        { 
            setToopTip(bt_saveLogs,"Logları Kaydet","Logları txt dosyasına kaydeder.");
        }
        private void bt_clearLogs_MouseHover(object sender, EventArgs e)
        {
            setToopTip(bt_clearLogs, "Logları Temizle", "Log kutucuğunu temizler.");
        }
        private void bt_showLogs_MouseHover(object sender, EventArgs e)
        {
            setToopTip(bt_showLogs, "Logları Göster", "Logların bulunduğu klasörü açar.");
        }
        private void bt_connect_MouseHover(object sender, EventArgs e)
        {
            if (bt_connect.ImageLocation == Main.getImage( "connect")) setToopTip(bt_connect, "Bağlan", " ");
            else setToopTip(bt_connect, "Bağlantıyı Kes", " ");
        }
        private void bt_settings_Click(object sender, EventArgs e)
        {
            if (!settingsControl.Visible) { hideControls(); settingsControl.Show(); }
            else settingsControl.Hide();

        }
        private void Main_Click(object sender, EventArgs e)
        {
            hideControls();
        }
        private void bt_settings_MouseHover(object sender, EventArgs e)
        {
            setToopTip(bt_settings,"Ayarlar","Program ile ilgili ayarların bulunduğu bölüm.");
        }
        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPort1.IsOpen) serialPort1.Close();
        }
        private void pLayout1_Click_1(object sender, EventArgs e)
        {
            hideControls();
        }
        private void pLayout1_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
