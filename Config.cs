﻿using System.Text.Json;
using TShockAPI;

namespace ShortCommands
{
    static class Config
    {
        class ConfigSettings
        {
            public Dictionary<string, string> shortcommands { get; set; } = new();

            public string website { get; set; } = "";
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

        private static readonly string _configFilePath = Path.Combine(TShock.SavePath, "ShortCommands.json");

        static Config()
        {
            Load();
        }

        private static void Save()
        {
            var jsonString = JsonSerializer.Serialize(new ConfigSettings() { shortcommands = shortcommands, website = website }
            , new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(_configFilePath, jsonString);
        }

        public static void Load()
        {
            if (!File.Exists(_configFilePath))
            {
                Save();
                return;
            }

            var jsonString = File.ReadAllText(_configFilePath);
            var settings = JsonSerializer.Deserialize<ConfigSettings>(jsonString);
            if (settings == null)
                Save();
            else
            {
                shortcommands = settings.shortcommands;
                website = settings.website;
            }

        }
    }
}