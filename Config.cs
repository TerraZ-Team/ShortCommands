﻿using Newtonsoft.Json;
using TShockAPI;

namespace ShortCommands
{
    static class Config
    {
        class ConfigStruct
        {
            public Dictionary<string, string> shortcommands = new ();

            public string website = "";
        }

        public static Dictionary<string, string> shortcommands = new() {
            { "h", "history" },
            { "rb", "rollback" },
            { "rd", "region define" },
            { "r1", "region set 1" },
            { "r2", "region set 2" },
            { "rn", "region name" },
            { "ci", "clear item 30000" },
            { "cp", "clear projectile 30000" },
            { "p1", "/point1" },
            { "p2", "/point2" } };

        public static string website = "https://tshock.co/";

        private static readonly string configPath = Path.Combine(TShock.SavePath, "ShortCommands.json");

        static Config()
        {
            Load();
        }

        private static void Save()
        {
            File.WriteAllText(configPath, JsonConvert.SerializeObject(
                new ConfigStruct() { shortcommands = shortcommands, website = website }, Formatting.Indented));
        }

        public static void Load()
        {
            if (!File.Exists(configPath))
            {
                Save();
                return;
            }

            var config = JsonConvert.DeserializeObject<ConfigStruct>(File.ReadAllText(configPath));
            if (config == null)
                Save();
            else
            {
                shortcommands = config.shortcommands;
                website = config.website;
            }

        }
    }
}