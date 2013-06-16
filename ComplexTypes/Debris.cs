using System;
using System.Xml.Serialization;

namespace GalaxyToolApi.ComplexTypes
{
    [Serializable]
    public class Debris
    {
        [XmlAttribute("metal")]
        public int Metal { get; set; }

        [XmlAttribute("crystal")]
        public int Crystal { get; set; }
    }
}