using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using GalaxyToolApi.ComplexTypes;
using GalaxyToolApi.Enums;
using GalaxyToolApi.Headers;

namespace GalaxyToolApi.Roots
{
    [Serializable]
    [XmlRoot("stats", Namespace = "", IsNullable = false)]
    public class Stats : GalaxyToolRoot
    {
        [XmlElement("stats_header")]
        public StatsHeader StatsHeader { get; set; }

        [XmlElement("player")]
        public List<Playerstatus> Player { get; set; }

        [XmlElement("ally")]
        public List<Allystatus> Ally { get; set; }

        public Stats()
        {
            Player = new List<Playerstatus>();
            Ally = new List<Allystatus>();

            Header.ContentType = ContentType.PlayerStats;
        }
    }
}