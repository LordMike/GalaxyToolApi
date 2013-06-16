using System;
using System.Globalization;
using System.Xml.Serialization;
using GalaxyToolApi.Enums;
using GalaxyToolApi.Interfaces;

namespace GalaxyToolApi.ComplexTypes
{
    [Serializable]
    public class CombatResult : ICoordinateContainer
    {
        [XmlElement("loot")]
        public Loot Loot { get; set; }

        [XmlElement("debris")]
        public Debris Debris { get; set; }

        [XmlAttribute("winner")]
        public CombatWinner Winner { get; set; }

        [XmlAttribute("datetime")]
        public string DatetimeString
        {
            // 2013.06.07 13:55:59
            get { return Datetime.ToString("yyyy.MM.dd HH:mm:ss"); }
            set { Datetime = DateTime.ParseExact(value, "yyyy.MM.dd HH:mm:ss", CultureInfo.CurrentCulture); }
        }

        [XmlAttribute("galaxy")]
        public int Galaxy { get; set; }

        [XmlAttribute("system")]
        public int System { get; set; }

        [XmlAttribute("planet")]
        public int Planet { get; set; }

        [XmlIgnore]
        public DateTime Datetime { get; set; }

        public CombatResult()
        {
            Loot = new Loot();
            Debris = new Debris();
        }
    }
}