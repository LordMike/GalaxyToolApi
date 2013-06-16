using System;
using System.Xml.Serialization;

namespace GalaxyToolApi.ComplexTypes
{
    [Serializable]
    public class Espionage
    {
        [XmlElement("activity")]
        public Activity Activity { get; set; }

        [XmlElement("source")]
        public Coordinates Source { get; set; }

        [XmlElement("target")]
        public Coordinates Target { get; set; }

        [XmlAttribute("msg_id")]
        public int MsgId { get; set; }
    }
}