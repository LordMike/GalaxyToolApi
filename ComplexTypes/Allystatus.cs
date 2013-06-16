using System;
using System.Xml.Serialization;

namespace GalaxyToolApi.ComplexTypes
{
    [Serializable]
    public class Allystatus
    {
        [XmlAttribute("rank")]
        public string Rank { get; set; }

        [XmlAttribute("allyname")]
        public string Allyname { get; set; }

        [XmlAttribute("allyid")]
        public string Allyid { get; set; }

        [XmlAttribute("member")]
        public string Member { get; set; }

        [XmlAttribute("score")]
        public string Score { get; set; }
    }
}