using System;
using System.Xml.Serialization;

namespace GalaxyToolApi.ComplexTypes
{
    [Serializable]
    public class Playerstatus
    {
        [XmlAttribute("rank")]
        public int Rank { get; set; }

        [XmlAttribute("playername")]
        public string Playername { get; set; }

        [XmlAttribute("playerid")]
        public int Playerid { get; set; }

        [XmlAttribute("galaxy")]
        public int Galaxy { get; set; }

        [XmlAttribute("system")]
        public int System { get; set; }

        [XmlAttribute("planet")]
        public int Planet { get; set; }

        [XmlAttribute("allyname")]
        public string Allyname { get; set; }

        [XmlAttribute("allyid")]
        public int Allyid { get; set; }

        [XmlAttribute("score")]
        public int Score { get; set; }

        [XmlAttribute("ships")]
        public int Ships { get; set; }
    }
}