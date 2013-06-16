using System;
using System.Collections.Generic;
using System.Globalization;
using System.Xml.Serialization;
using GalaxyToolApi.Enums;

namespace GalaxyToolApi.ComplexTypes
{
    [Serializable]
    public class Report
    {
        [XmlElement("entry")]
        public List<AmountEntry> Entries { get; set; }

        [XmlAttribute("playername")]
        public string Playername { get; set; }

        [XmlAttribute("planetname")]
        public string Planetname { get; set; }

        [XmlAttribute("moon")]
        public bool Moon { get; set; }

        [XmlAttribute("galaxy")]
        public int Galaxy { get; set; }

        [XmlAttribute("system")]
        public int System { get; set; }

        [XmlAttribute("planet")]
        public int Planet { get; set; }

        [XmlAttribute("datetime")]
        public string DatetimeString
        {
            // 2013.06.07 13:55:59
            get { return Datetime.ToString("yyyy.MM.dd HH:mm:ss"); }
            set { Datetime = DateTime.ParseExact(value, "yyyy.MM.dd HH:mm:ss", CultureInfo.CurrentCulture); }
        }

        [XmlAttribute("scandepth")]
        public Scandepth Scandepth { get; set; }

        [XmlAttribute("msg_id")]
        public int MsgId { get; set; }

        [XmlIgnore]
        public DateTime Datetime { get; set; }

        public Report()
        {
            Entries = new List<AmountEntry>();
        }
    }
}