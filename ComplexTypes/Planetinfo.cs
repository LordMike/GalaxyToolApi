using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using GalaxyToolApi.Interfaces;

namespace GalaxyToolApi.ComplexTypes
{
    [Serializable]
    public class PlanetInfo : ICoordinateContainer
    {
        [XmlElement("planetname")]
        public string PlanetName { get; set; }

        [XmlAttribute("galaxy")]
        public int Galaxy { get; set; }

        [XmlAttribute("system")]
        public int System { get; set; }

        [XmlAttribute("planet")]
        public int Planet { get; set; }

        [XmlAttribute("moon")]
        public bool Moon { get; set; }

        [XmlElement("entry")]
        public List<AmountEntry> Entries { get; set; }

        public PlanetInfo()
        {
            Entries = new List<AmountEntry>();
        }
    }
}