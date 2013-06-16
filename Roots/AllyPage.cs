using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using GalaxyToolApi.ComplexTypes;
using GalaxyToolApi.Enums;
using GalaxyToolApi.Headers;

namespace GalaxyToolApi.Roots
{
    [Serializable]
    [XmlRoot("allypage", Namespace = "", IsNullable = false)]
    public class AllyPage : GalaxyToolRoot
    {
        [XmlElement("allypage_header")]
        public AllypageHeader AllypageHeader { get; set; }

        [XmlElement("player")]
        public List<Player> PlayerEntries { get; set; }

        public AllyPage()
        {
            AllypageHeader = new AllypageHeader();
            PlayerEntries = new List<Player>();

            Header.ContentType = ContentType.PlayerStats;
        }
    }
}