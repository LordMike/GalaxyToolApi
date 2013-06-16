using System;
using System.Xml.Serialization;

namespace GalaxyToolApi.ComplexTypes
{
    [Serializable]
    public class Coordinates
    {
        [XmlElement("galaxy")]
        public int Galaxy { get; set; }

        [XmlElement("system")]
        public int System { get; set; }

        [XmlElement("planet")]
        public int Planet { get; set; }
    }
}