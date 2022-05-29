using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace telemetry.classes
{
    class Logger
    {

        public Logger()
        {

        }

        public static void CreateLogFolder(string subFolder = "")
        {
            if (!Directory.Exists(GetLogs("", subFolder))) Directory.CreateDirectory(GetLogs("", subFolder));
        }

        public static void SaveLogs(string log, string fName = "log_autosaved_", DateTime? date= null)
        {
            if (date == null) date = DateTime.Now;
            if (!Setting.GetSettings("saveLogsSingle") || fName == "log_custom_") File.WriteAllText(GetLogs(fName + date?.ToString("dd-MM-yyyy-HH-mm-ss")), log);
            if (fName == "log_custom_") Main.alert.Show("Loglar başarıyla kaydedildi.", "success");
            else File.AppendAllText(GetLogs("logs_all"), log);
        }

        public static void SaveTubitakLogs(string log, string fName = "log_autosaved_", DateTime? date = null)
        {
            if (date == null) date = DateTime.Now;
            File.AppendAllText(GetLogs(fName + date?.ToString("dd-MM-yyyy-HH-mm-ss"), "Tubitak"), log);
        }

        public static string GetLogs(string fName = "", string subFolder = "")
        {
            string path = Directory.GetCurrentDirectory() + @"\logs\" + subFolder + @"\";
            if (!string.IsNullOrEmpty(fName)) path +=  fName + ".txt";
            return path;
        }

        public static void ShowLogs(string subFolder="")
        {
            try { System.Diagnostics.Process.Start(GetLogs("", subFolder)); }
            catch (Exception) { 
                CreateLogFolder();
                CreateLogFolder("Tubitak");
            }
        }

        



    }
}
