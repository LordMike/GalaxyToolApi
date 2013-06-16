using System;
using System.Xml.Serialization;

namespace GalaxyToolApi.ComplexTypes
{
    [Serializable]
    public class PlanetPosition
    {
        [XmlElement("planetname")]
        public string PlanetName { get; set; }

        [XmlElement("moon")]
        public Moon Moon { get; set; }

        [XmlElement("debris")]
        public Debris Debris { get; set; }

        [XmlElement("player")]
        public Player Player { get; set; }

        [XmlElement("alliance")]
        public Alliance Alliance { get; set; }

        [XmlElement("activity")]
        public Activity[] Activity { get; set; }

        [XmlAttribute("pos")]
        public int Position { get; set; }
    }
}