using System;
using System.Xml.Serialization;

namespace GalaxyToolApi.ComplexTypes
{
    [Serializable]
    public class Playerdata
    {
        [XmlAttribute("playername")]
        public string PlayerName { get; set; }

        [XmlAttribute("playerid")]
        public int PlayerId { get; set; }
    }
}