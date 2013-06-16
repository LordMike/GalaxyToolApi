using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Xml.Serialization;
using GalaxyToolApi.Enums;

namespace GalaxyToolApi.ComplexTypes
{
    [Serializable]
    public class Fleet
    {
        [XmlElement("origin")]
        public PlanetInfo Origin { get; set; }

        [XmlElement("destination")]
        public PlanetInfo Destination { get; set; }

        [XmlElement("entry")]
        public List<AmountEntry> Entries { get; set; }

        [XmlAttribute("fleet_id")]
        public int FleetId { get; set; }

        [XmlAttribute("sub_fleet_id")]
        [DefaultValue(0)]
        public int SubFleetId { get; set; }

        [XmlAttribute("mission")]
        public Mission Mission { get; set; }

        [XmlAttribute("returning")]
        public bool Returning { get; set; }

        [XmlAttribute("scantime")]
        public string ScanTimeString
        {
            // 2013.06.07 13:55:59
            get { return ScanTime.ToString("yyyy.MM.dd HH:mm:ss"); }
            set { ScanTime = DateTime.ParseExact(value, "yyyy.MM.dd HH:mm:ss", CultureInfo.CurrentCulture); }
        }

        [XmlIgnore]
        public DateTime ScanTime { get; set; }

        [XmlAttribute("arrival_time")]
        public string ArrivalTimeString
        {
            // 2013.06.07 13:55:59
            get { return ArrivalTime.ToString("yyyy.MM.dd HH:mm:ss"); }
            set { ArrivalTime = DateTime.ParseExact(value, "yyyy.MM.dd HH:mm:ss", CultureInfo.CurrentCulture); }
        }

        [XmlIgnore]
        public DateTime ArrivalTime { get; set; }

        public Fleet()
        {
            Entries = new List<AmountEntry>();
            Origin = new PlanetInfo();
            Destination = new PlanetInfo();
        }
    }
}