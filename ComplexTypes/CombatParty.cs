using System;
using System.Xml.Serialization;
using GalaxyToolApi.Enums;
using GalaxyToolApi.Interfaces;

namespace GalaxyToolApi.ComplexTypes
{
    [Serializable]
    public class CombatParty : ICoordinateContainer
    {
        [XmlElement("activity")]
        public Activity Activity { get; set; }

        [XmlAttribute("type")]
        public CombatType Type { get; set; }

        [XmlAttribute("galaxy")]
        public int Galaxy { get; set; }

        [XmlAttribute("system")]
        public int System { get; set; }

        [XmlAttribute("planet")]
        public int Planet { get; set; }

        [XmlAttribute("weapon")]
        public int Weapon { get; set; }

        [XmlAttribute("shield")]
        public int Shield { get; set; }

        [XmlAttribute("armor")]
        public int Armor { get; set; }

        [XmlAttribute("lost_units")]
        public int LostUnits { get; set; }
    }
}