using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace telemetry
{
    public partial class TempControl : UserControl
    {
        /// <summary>
        /// Developed by Mehmet SÜMER
        /// Github: mehmetsumer
        /// </summary>
       
        public TempControl()
        {
            InitializeComponent();
        }

        public string getText(string control)
        {
            Control ctn = this.Controls[control];
            return ctn.Text;
        }
        private void TempControl_Load(object sender, EventArgs e)
        {

        }

        private void lb_temp1_Click(object sender, EventArgs e)
        {

        }
    }
}
