using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using telemetry.classes;

namespace telemetry
{
    public partial class Race : Form
    {
        /// <summary>
        /// Developed by Mehmet SÜMER
        /// Github: mehmetsumer
        /// </summary>

        private int lapCount = 1;
        private string raceName = "";
        private CustomAlerts alert;
        private string logs= "";
        private DateTime? raceStart = null;
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        private Main _mainInstance;

        int time = 0;
        int distance = 0;
        double wattSaat = 0;

        int totalSn = 1;
        int sl = 0, sn = 0, min = 0, h = 0;
        int sl2 = 100, sn2 = 59, min2 = 59, h2 = 1;
        int lapH = 0, lapMin = 0, lapSn = 0, lapSl = 0;
        int lapHA = 0, lapMinA = 0, lapSnA = 0, lapSlA = 0;

        private void bt_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void bt_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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
        private void pLayout1_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void bt_showLogs_Click(object sender, EventArgs e)
        {
            Logger.ShowLogs("raceLogs");
        }

        private void bt_saveLogs_Click(object sender, EventArgs e)
        {
            saveLogs();    
        }

        private void lb_lapTime_Click(object sender, EventArgs e)
        {

        }

        private void bt_watt_Click(object sender, EventArgs e)
        {
            int watt = Convert.ToInt32(tb_watt.Text);
            Main.dataCount++;
            Main.TotalWatt += watt;
            Main.AverageWatt = (int)Math.Round(((double)Main.TotalWatt / Main.dataCount));
            lb_watAv.Text = "Toplam: " + Main.TotalWatt + ", Sayı: " + Main.dataCount + ", Ort: " + Main.AverageWatt;
            lb_watt.Text = "Enerji Tüketimi (w/s): " + Main.AverageWatt;
        }

        private void bt_resetWatt_Click(object sender, EventArgs e)
        {
            Main.dataCount=0;
            Main.TotalWatt = 0;
            Main.AverageWatt = 0;
            lb_watt.Text = "Enerji Tüketimi (w/s): " + Main.AverageWatt;
        }

        private void tm_min_Tick(object sender, EventArgs e)
        {
            if (min == 60)
            {
                h++;
                min = 0;
            }
            min++;

            if (lapMin == 60)
            {
                lapH++;
                lapMin = 0;
            }
            lapMin++;
            if (lapMinA == 60)
            {
                lapHA++;
                lapMinA = 0;
            }
            lapMinA++;

            if (min2 == 0)
            {
                h2--;
                min2 = 59;
            }
            min2--;
        }
        private void tm_sn_Tick(object sender, EventArgs e)
        {

            if (sn == 60) sn = 0;
            sn++;
            totalSn++;

            if (lapSn == 60) lapSn = 0;
            lapSn++;
            if (lapSnA == 60) lapSnA = 0;
            lapSnA++;

            if (sn2 == 0) sn2 = 59;
            sn2--;

        }
        private void tm_sl_Tick(object sender, EventArgs e)
        {
            if (sl == 100) sl = 0;
            lb_timePassed.Text = formatt(h, min, sn, sl);
            sl++;

            if (lapSl == 100) lapSl = 0;
            lapSl++;
            lb_lapTime.Text = formatt(lapH, lapMin, lapSn, lapSl);
            if (lapSlA == 100) lapSlA = 0;
            lapSlA++;
            lb_lapTimeAuto.Text = formatt(lapHA, lapMinA, lapSnA, lapSlA);

            if (sl2 == 0) sl2 = 100;
            lb_timeLeft.Text = formatt(h2, min2, sn2, sl2);     
            
            sl2--;

            if (sl2 <= 0 && sn2 == 0 && min2 == 0 && h2 <= 0)
            {
                bt_startStop.Text = "Başlat";
                tm_sl.Stop(); tm_sn.Stop(); tm_min.Stop();
                bt_pause.Text = "| |";
                bt_pause.Visible = bt_addLap.Enabled = false;
                saveLogs();
                raceStart = null;
                alert.Show("Yarış süresi bitti.");
            }
            calculateLaps();          
        }

        private void bt_pause_Click(object sender, EventArgs e)
        {
            if (bt_pause.Text == "| |")
            {
                tm_sl.Stop(); tm_sn.Stop(); tm_min.Stop();
                bt_pause.Text = "\\>";
                bt_addLap.Enabled = false;
            }
            else
            {
                tm_sl.Start(); tm_sn.Start(); tm_min.Start();
                bt_pause.Text = "| |";
                bt_addLap.Enabled = true;
            }
                
        }
        private void bt_addLap_Click(object sender, EventArgs e)
        {
            addLap();
        }

        void calculateLaps()
        {
            try
            {
                // TODO: BU HESAP DUZELTILECEK.
                //  Main.AverageWatt * 3600 / Main.dataCount
                lb_watt.Text = "Enerji Tüketimi (w/s): " + Main.AverageWatt;
                //alert.Show(Main.AverageWatt.ToString() + " " + Main.dataCount);
                int totalDistByLap = (distance * lapCount); // toplam alınması gereken mesafe, 1 tur 50 m ise 2.turda toplamda 100m almamız gerek.
                int distByLap = distance - totalDistByLap + Main.distance; // o anki turdaki alınan mesafe.
                //if (distByLap < 0) distByLap = 0;
                lb_distance.Text = "Alınan Yol (m): " + distByLap + "/" + distance + " m" + "     " + Main.distance + "/" + totalDistByLap + " m";
                lb_totalDist.Text = "Tur: " + (lapCount - 1) + ". tur bitti, " + lapCount+ ". turun içindeyiz";
                if (distByLap >= distance)
                {
                    lapCount++;
                    if(cb_autoCount.Checked) addLap(true);
                }

            }
            catch (Exception)
            {
                lb_watt.Text = "Enerji Tüketimi(w/ s): Telemetri bağlantısı kurulamadı.";
                lb_distance.Text = "Alınan Yol (m): Telemetri bağlantısı kurulamadı.";
                lb_totalDist.Text = "Tur: Telemetri bağlantısı kurulamadı.";
            }
        }

        void addLap(bool auto= false)
        {
            if (auto)
            {
                int lap = lb_lapsAuto.Items.Count + 1;
                lb_lapsAuto.Items.Add(lap.ToString() + ".    " + (lap < 10 ? "  " : "") + formatt(h, min, sn, sl) + (lap == 1 ? "" : "    " + formatt(lapHA, lapMinA, lapSnA, lapSlA)));
                lapHA = 0; lapMinA = 0; lapSnA = 0; lapSlA = 0;
                lb_lapsAuto.TopIndex = lb_lapsAuto.Items.Count - 1;
            }
            else
            {
                int lap = lb_laps.Items.Count + 1;
                lb_laps.Items.Add(lap.ToString() + ".    " + (lap < 10 ? "  " : "") + formatt(h, min, sn, sl) + (lap == 1 ? "" : "    " + formatt(lapH, lapMin, lapSn, lapSl)));
                lapH = 0; lapMin = 0; lapSn = 0; lapSl = 0;
                lb_laps.TopIndex = lb_laps.Items.Count - 1;
            }
        }

        void saveLogs(bool first = false, string fName = "race_log_")
        {
            try
            {
                if(raceStart == null)
                {
                    alert.Show("Log metni boş.", "danger");
                    return;
                }
                if (first)
                {
                    logs = (string.IsNullOrEmpty(raceName) ? "" : "Yarış Adı: ***" + raceName + " ***\r\n") +
                        "Yarış Başlangıcı: " + raceStart +
                        "\r\nYarış Süresi: " + time + " dk" +
                        "\r\nPist Uzunluğu: " + distance + " m\r\n";
                    File.AppendAllText(Logger.GetLogs(fName + raceStart?.ToString("dd-MM-yyyy-HH-mm-ss"), "raceLogs"), logs);
                    return;
                }
                logs = "\r\nYarış Bitimine Kalan Süre: " + formatt(h2, min2, sn2, sl2) +
                       "\r\nOrtalama Güç Tüketimi: " + wattSaat + " kwH" +
                       "\r\nManuel Sayılan Tur Sayısı: " + lb_laps.Items.Count +
                       (lb_laps.Items.Count == 0 ? "" : "\r\nManuel Eklenen Turlar: ");                   
                for (int i = 0; i < lb_laps.Items.Count; i++)
                {
                    logs += "\r\n" + lb_laps.Items[i].ToString();
                }
                logs+= "\r\nOtomatik Sayılan Tur Sayısı: " + lb_lapsAuto.Items.Count +
                (lb_lapsAuto.Items.Count == 0 ? "\r\n" : "\r\nOtomatik Sayılan Turlar: ");
                for (int i = 0; i < lb_lapsAuto.Items.Count; i++)
                {
                    logs += "\r\n" + lb_lapsAuto.Items[i].ToString();
                }
                logs += "\r\n";
                // + raceName.Normalize() +"_"
                File.AppendAllText(Logger.GetLogs(fName + raceStart?.ToString("dd-MM-yyyy-HH-mm-ss"), "raceLogs"), logs);
                //File.WriteAllText(Main.getLogs(fName + raceStart?.ToString("dd-MM-yyyy-HH-mm-ss"), "raceLogs"), logs);
                alert.Show("Loglar başarıyla kaydedildi.", "success");
            }
            catch (Exception)
            {
                Logger.CreateLogFolder("raceLogs");
                saveLogs(first);
            }
            
        }
        private string formatt(int h, int min, int sn, int sl)
        {
            return (h != 0 ? (h < 10 ? "0" : "") + h + ":" : "   ") +
                    (min < 10 ? "0" : "") + min + ":" +
                    (sn < 10 ? "0" : "") + sn + "." +
                    (sl < 10 ? "0" : "") + sl;
        }
        private void bt_startStop_Click(object sender, EventArgs e)
        {
            try
            {
                if(bt_startStop.Text == "Başlat")
                {
                    _mainInstance.WriteLine("reset_distance");
                    Main.distance = 0;
                    Main.fakeDist = 0; 
                    lapCount = 1;
                    raceName = tb_raceName.Text;
                    time = Convert.ToInt32(tb_time.Text);   
                    distance = Convert.ToInt32(tb_distance.Text);
                    if (time <= 0 || distance <= 0)
                    {
                        alert.Show("Süre veya pist uzunluğu 1'den küçük olamaz.", "danger");
                        return;
                    }

                    int totalDistByLap = (distance * lapCount);
                    lb_distance.Text = "Alınan Yol (m): 0/" + distance + " m" + "     " + Main.distance + "/" + totalDistByLap + " m";
                    lb_totalDist.Text = "Tur: " + (lapCount - 1) + ". tur bitti, " + lapCount + ". turun içindeyiz";


                    wattSaat = 0;
                    sl = 0;  sn = 0; min = 0; h = 0;
                    lapSl = 0; lapSn = 0; lapMin = 0; lapH = 0;
                    lapSlA = 0; lapSnA = 0; lapMinA = 0; lapHA = 0;
                    sl2 = 100; sn2 = 59;
                    lb_laps.Items.Clear();
                    lb_lapsAuto.Items.Clear();

                    h2 = time / 60;
                    min2 = time % 60;
                    if (min2 == 0)
                    {
                        h2--;
                        min2 = 59;
                    }
                    else min2--;

                    raceStart = DateTime.Now;
                    saveLogs(true);

                    bt_startStop.Text = "Bitir";
                    tm_sl.Start(); tm_sn.Start(); tm_min.Start();
                    bt_pause.Visible = bt_addLap.Enabled = true;
                }
                else if (bt_startStop.Text == "Bitir")
                {
                    bt_startStop.Text = "Başlat";
                    tm_sl.Stop(); tm_sn.Stop(); tm_min.Stop();
                    bt_pause.Text = "| |";
                    bt_pause.Visible = bt_addLap.Enabled = false;
                    saveLogs();
                    raceStart = null;
                }         
            }
            catch (Exception ex)
            {
                alert.Show("Alanları kontrol ediniz.", "danger");
            }
        }

        public Race(Main mainInstance)
        {
            _mainInstance = mainInstance;
            InitializeComponent();
        }

        private void Race_Load(object sender, EventArgs e)
        {
            bt_pause.Visible = bt_addLap.Enabled = false;
            alert = new CustomAlerts(this.Controls, x:15, y:this.Height - 200, w:570, h:65);
        }
    }
}
