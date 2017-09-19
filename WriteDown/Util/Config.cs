using System.Text;
using System.IO;
using Newtonsoft.Json;

namespace WriteDown.Util {
    class Config {
        public static readonly string CONFIG_FILE = Path.Combine(Globals.APP_FOLDER, "config.cfg");
        public static readonly string BACKUP_CONFIG = Path.Combine(Globals.APP_FOLDER, "config.cfg.bak");
        public static Config CONFIG;
        public string theme { get; set; } = "flatly";
        public bool line_numbers { get; set; } = true;
        public bool word_wrap { get; set; } = false;
        public string text_encoding { get; set; } = Encoding.UTF8.WebName;
        public bool update_on_launch { get; set; } = true;
        public bool github_flavor { get; set; } = true;
        public bool convert_emoji { get; set; } = true;

        public Config() { }

        public void writeConfig() {
            var strOut = JsonConvert.SerializeObject(this, Formatting.Indented);
            if (string.IsNullOrWhiteSpace(strOut)) return;
            if (File.Exists(CONFIG_FILE)) File.Move(CONFIG_FILE, BACKUP_CONFIG);
            File.WriteAllText(CONFIG_FILE, strOut, Encoding.UTF8);
        }

        public static void loadConfig() {
            var strIn = "";
            if (File.Exists(CONFIG_FILE)) strIn = File.ReadAllText(CONFIG_FILE, Encoding.UTF8);
            if (string.IsNullOrWhiteSpace(strIn) && File.Exists(BACKUP_CONFIG)) strIn = File.ReadAllText(BACKUP_CONFIG, Encoding.UTF8);
            if (string.IsNullOrWhiteSpace(strIn)) {
                newConfigFile();
                return;
            }
            CONFIG = JsonConvert.DeserializeObject<Config>(strIn);
            if (CONFIG == null) newConfigFile();
        }

        private static void newConfigFile() {
            CONFIG = new Config();
            CONFIG.writeConfig();
        }
    }
}
