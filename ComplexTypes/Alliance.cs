using System;
using System.Xml.Serialization;

namespace GalaxyToolApi.ComplexTypes
{
    [Serializable]
    public class Alliance
    {
        [XmlAttribute("allyname")]
        public string Allyname { get; set; }

        [XmlAttribute("allyid")]
        public string Allyid { get; set; }

        [XmlAttribute("rank")]
        public string Rank { get; set; }

        [XmlAttribute("member")]
        public string Member { get; set; }
    }
}