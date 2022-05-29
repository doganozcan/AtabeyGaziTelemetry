
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using telemetry.classes;

namespace telemetry
{
    public partial class SettingsControl : UserControl
    {
        /// <summary>
        /// Developed by Mehmet SÜMER
        /// Github: mehmetsumer
        /// </summary>
        public SettingsControl()
        {
            InitializeComponent();
        }
        void getSettings()
        {
            cb_logs.Checked = Setting.GetSettings("saveLogsAuto");
            cb_logType.Checked = Setting.GetSettings("saveLogsSingle");
        }
        void setSettings()
        {
            FileInfo fileInfo;
            Setting.SetSetting("saveLogsAuto", cb_logs.Checked);
            Setting.SetSetting("saveLogsSingle", cb_logType.Checked); 
            if (!File.Exists(Setting.Path()))
            {
                File.WriteAllText(Setting.Path(), JsonConvert.SerializeObject(Setting.GetSettings()));
                fileInfo = new FileInfo(Setting.Path());
                fileInfo.IsReadOnly = true;
            }
            else // AYAR DOSYASI VARSA.
            {
                fileInfo = new FileInfo(Setting.Path());
                fileInfo.IsReadOnly = false;
                string path = Setting.Path();
                Dictionary<string,bool> settings = Setting.GetSettings();
                File.WriteAllText(path, JsonConvert.SerializeObject(settings));
                fileInfo.IsReadOnly = true; 
            }
            this.Hide();
        }
        private void bt_saveSettings_Click(object sender, EventArgs e)
        {
            setSettings();
        }
        private void cb_logType_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_logType.Checked) cb_logType.Text = "Tek dosya halinde kaydediliyor";
            else cb_logType.Text = "Ayrı ayrı kaydediliyor";
        }
        private void cb_logs_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_logs.Checked) cb_logType.Visible = true;
            else cb_logType.Visible = false;
        }
        private void SettingsControl_Load(object sender, EventArgs e)
        {
            getSettings();
            //cb_logs_CheckedChanged(sender, e);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
