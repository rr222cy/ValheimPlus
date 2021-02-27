﻿using System.Xml.Serialization;

namespace ValheimPlusManagerWPF.Models
{
    [XmlRoot("Settings")]
    public class Settings
    {
        public string ClientInstallationPath { get; set; }
        public string ServerInstallationPath { get; set; }
        public string ClientPath { get; set; }
        public string ServerPath { get; set; }
        public string ValheimPlusGameClientVersion { get; set; }
        public string ValheimPlusServerClientVersion { get; set; }
    }
}
