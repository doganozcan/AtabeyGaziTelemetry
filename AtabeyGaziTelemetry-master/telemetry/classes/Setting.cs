using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace telemetry.classes
{
    public class Setting
    {
        private static string settingsPath = Directory.GetCurrentDirectory() + @"\settings.json";
        private static Dictionary<string, dynamic> settings = new Dictionary<string, dynamic>();

        public Setting()
        {

        }

        public static string Path()
        {
            return settingsPath;
        }

        public static dynamic GetSettings(string key="")
        {
            //FileInfo fileInfo;
            if (!File.Exists(settingsPath)) // AYAR DOSYASI YOKSA.
            {
                settings["saveLogsAuto"] = true;
                settings["saveLogsSingle"] = true;
                File.WriteAllText(settingsPath, JsonConvert.SerializeObject(settings));
                //fileInfo = new FileInfo(settingsPath);
                //fileInfo.IsReadOnly = true;
            }
            else
            {
                //fileInfo = new FileInfo(settingsPath);
                string json = File.ReadAllText(settingsPath);
                settings = JsonConvert.DeserializeObject<Dictionary<string, dynamic>>(json);
                //fileInfo.IsReadOnly = true;
            }
            if (string.IsNullOrEmpty(key)) return settings;

            return settings[key] ?? "NULL";
        }

        public static void SetSetting(string key, bool val)
        {
            settings[key] = val;
        }
    }
}
