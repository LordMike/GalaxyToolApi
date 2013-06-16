using System;
using System.Xml.Serialization;

namespace GalaxyToolApi.ComplexTypes
{
    [Serializable]
    public class PluginInfo
    {
        [XmlElement("path")]
        public string Path { get; set; }

        [XmlElement("installer")]
        public FileClass Installer { get; set; }

        [XmlElement("authorization")]
        public FileClass Authorization { get; set; }

        [XmlElement("navigation")]
        public FileClass Navigation { get; set; }

        [XmlAttribute("name")]
        public string Name { get; set; }
    }
}