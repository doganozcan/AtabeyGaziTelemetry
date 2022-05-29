using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace telemetry.classes
{
    class CustomProgress
    {
        private UserControl c;
        private ProgressBar pb;
        private Label label1;
        private string name;
        private string text;
        public CustomProgress()
        {

        }

        //kontrol, isim, yazı, x, y, maks değer, genişlik, yükseklik

        public CustomProgress(UserControl c, string name, string text, int x, int y, int max=50, int w=180, int h=35)
        {
            this.text = text;
            this.c = c;
            this.name = name;
            label1 = new Label();
            label1.AutoSize = true;
            label1.Location = new Point(x, (y-25));
            label1.Name = "lb_" + name;
            label1.TabIndex = 0;
            label1.BackColor = Color.Transparent;
            label1.Text = text;
            label1.Font = new Font("Arial", 13, FontStyle.Regular);
            c.Controls.Add(label1);

            pb = new ProgressBar();
            pb.AutoSize = true;
            pb.Location = new Point(x, y);
            pb.Name = name;
            pb.Size = new Size(w, h);
            pb.TabIndex = 0;
            pb.Text = text;
            //pb.Maximum = max;           
            /*pb.Maximum = 21;
            pb.Minimum = 16;
            pb.Value = 16;*/
            c.Controls.Add(pb);
        }

        public string getName()
        {
            return this.name;
        }

        public void Value(double val)
        {
            try
            {
                int value = (int)val * 10; // 352       
                pb.Value = value;
                label1.Text = text + ": " + val + "V";
            }
            catch (Exception e)
            {
                MessageBox.Show("CUSTOMPROGRESS: " + e.Message);
            }
        }
    }
}
