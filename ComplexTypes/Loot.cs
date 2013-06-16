using System;
using System.Xml.Serialization;

namespace GalaxyToolApi.ComplexTypes
{
    [Serializable]
    public class Loot
    {
        [XmlAttribute("metal")]
        public int Metal { get; set; }

        [XmlAttribute("crystal")]
        public int Crystal { get; set; }

        [XmlAttribute("deuterium")]
        public int Deuterium { get; set; }
    }
}