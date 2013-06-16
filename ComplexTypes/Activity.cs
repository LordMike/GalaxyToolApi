using System;
using System.Xml.Serialization;

namespace GalaxyToolApi.ComplexTypes
{
    [Serializable]
    public class Activity
    {
        [XmlAttribute("year")]
        public int Year { get; set; }

        [XmlAttribute("month")]
        public int Month { get; set; }

        [XmlAttribute("day")]
        public int Day { get; set; }

        [XmlAttribute("hour")]
        public int Hour { get; set; }

        [XmlAttribute("minute")]
        public int Minute { get; set; }

        [XmlAttribute("weekday")]
        public int Weekday { get; set; }
    }
}