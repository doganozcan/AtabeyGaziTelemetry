using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.Control;

namespace telemetry.classes
{
    public class CustomAlerts
    {
        private ControlCollection c;
        private int counter= 0, counterLimit = 0;

        private TextBox tb_alert;
        private string text;
        private Panel p_alert;
        private Timer tm_alert;

        public CustomAlerts()
        {

        }

        public CustomAlerts(ControlCollection c, int x= 15, int y = 15, int w= 471, int h = 55)
        {
            this.c = c;
            p_alert = new Panel();
            p_alert.Name = "p_alert";
            p_alert.Location = new Point(x, y);
            p_alert.Size = new Size(w, h);
            p_alert.BackgroundImageLayout = ImageLayout.Stretch;
            p_alert.Text = text;
            p_alert.TabStop = true;
            p_alert.TabIndex = 99;
            p_alert.Visible = false;
          
            p_alert.BringToFront();

            tb_alert = new TextBox();
            tb_alert.Name = "tb_alert";
            //tb_alert.Visible = false;
            tb_alert.ReadOnly = tb_alert.Multiline = true;
            tb_alert.BorderStyle = BorderStyle.None;
            tb_alert.Font = new Font(tb_alert.Font.FontFamily, (int)(h/3));
            tb_alert.BackColor = Color.FromArgb(21, 36, 54);
            tb_alert.ForeColor = Color.FromArgb(222, 222, 222);
            tb_alert.Location = new Point(50, 16);
            tb_alert.Size = new Size(w-60, h - 19);

            p_alert.Controls.Add(tb_alert);
            c.Add(p_alert);

            tm_alert = new Timer();
            tm_alert.Interval = 1000;
            tm_alert.Tick += new EventHandler(tm_alert_Tick);
            //tm_alert.Start();
        }

        private void tm_alert_Tick(object sender, EventArgs e)
        {
            counter++;
            if (counter >= counterLimit)
            {
                counter = 0;
                p_alert.Visible = tm_alert.Enabled = false;
            }
        }

        public void Show(string text, string state = "info", int time = 3)
        {
            counterLimit = time;
            p_alert.BackgroundImage = Image.FromFile(Main.getImage("alert-" + state));
            
            tb_alert.Text = text;
            p_alert.Visible = tm_alert.Enabled = true;
        }

    }
}
