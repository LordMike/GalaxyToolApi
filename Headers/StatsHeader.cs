using System;
using System.Xml.Serialization;
using GalaxyToolApi.Enums;

namespace GalaxyToolApi.Headers
{
    [Serializable]
    public class StatsHeader
    {
        [XmlAttribute("type")]
        public StatsType Type { get; set; }
    }
}