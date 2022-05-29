using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace telemetry.classes
{
    class CustomLabel
    {
        private UserControl c;
        private Label label1;
        private string name;
        public CustomLabel()
        {

        }

        //kontrol, yazı, x, y, genişlik, yükseklik, font adı, font stili, font boyutu

        public CustomLabel(UserControl c, string name, string text, int x, int y, int w, int h, string fontName = "Microsoft Sans Serif", FontStyle style = FontStyle.Regular, int fontSize = 36)
        {
            this.c = c;
            this.name = name;
            label1 = new Label();
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(x, y);
            label1.Name = name;
            label1.Size = new System.Drawing.Size(w, h);
            label1.TabIndex = 0;
            label1.Text = text;
            label1.Font = new Font(fontName, fontSize, style);
            c.Controls.Add(label1);
        }

        public string getName()
        {
            return this.name;
        }

        public void Text(string text, string prefix = "", bool color= false)
        {
            try
            {     
                //Control ctn = this.c.Controls[this.name];
                double temp = double.Parse(text);
                if(color)
                    label1.ForeColor = getColorByTemp(temp);
                label1.Text = prefix + text + "°C";
            }
            catch (Exception e)
            {
                MessageBox.Show("CUSTOMLABEL: " + e.Message);
            }
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

       

    }
}
