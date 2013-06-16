using System;
using System.Globalization;
using System.Xml.Serialization;

namespace GalaxyToolApi.ComplexTypes
{
    [Serializable]
    public class Message
    {
        [XmlElement("activity")]
        public Activity Activity { get; set; }

        [XmlElement("message_content")]
        public string MessageContent { get; set; }

        [XmlElement("from")]
        public Playerdata From { get; set; }

        [XmlElement("to")]
        public Playerdata To { get; set; }

        [XmlAttribute("msg_id")]
        public int MsgId { get; set; }

        [XmlAttribute("datetime")]
        public string DatetimeString
        {
            // 2013.06.07 13:55:59
            get { return Datetime.ToString("yyyy.MM.dd HH:mm:ss"); }
            set { Datetime = DateTime.ParseExact(value, "yyyy.MM.dd HH:mm:ss", CultureInfo.CurrentCulture); }
        }

        [XmlIgnore]
        public DateTime Datetime { get; set; }

        [XmlAttribute("subject")]
        public string Subject { get; set; }
    }
}