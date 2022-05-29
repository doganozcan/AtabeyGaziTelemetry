using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace telemetry
{
    public partial class welcome : Form
    {
        public welcome()
        {
            InitializeComponent();
        }

        private int counter = 0;
        private void welcome_Load(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = Main.getImage("welcome-1");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pictureBox1.ImageLocation == Main.getImage("welcome-1")) pictureBox1.ImageLocation = Main.getImage("welcome-2");
            else pictureBox1.ImageLocation = Main.getImage("welcome-1");
            counter++;
            if (counter == 4)
            {
                timer1.Enabled = false;
                Main m = new Main();
                this.Hide();
                m.ShowDialog();
                this.Close();
            }

        }
    }
}
