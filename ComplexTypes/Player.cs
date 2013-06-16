using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace GalaxyToolApi.ComplexTypes
{
    [Serializable]
    public class Player
    {
        [XmlElement("activity")]
        public Activity Activity { get; set; }

        [XmlAttribute("playername")]
        public string PlayerName { get; set; }

        [XmlAttribute("rank")]
        public int Rank { get; set; }

        [XmlAttribute("playerid")]
        public int PlayerId { get; set; }

        [XmlAttribute("galaxy")]
        [DefaultValue(0)]
        public int Galaxy { get; set; }

        [XmlAttribute("system")]
        [DefaultValue(0)]
        public int System { get; set; }

        [XmlAttribute("planet")]
        [DefaultValue(0)]
        public int Planet { get; set; }

        [XmlAttribute("score")]
        [DefaultValue(0)]
        public int Score { get; set; }

        [XmlAttribute("status")]
        public string Status { get; set; }
    }
}