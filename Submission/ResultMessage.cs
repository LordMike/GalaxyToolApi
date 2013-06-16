using System.Xml.Serialization;
using GalaxyToolApi.Enums;

namespace GalaxyToolApi.Submission
{
    public class ResultMessage
    {
        [XmlAttribute("severity")]
        public MessageSeverity Severity { get; set; }

        [XmlAttribute("depth")]
        public int Depth { get; set; }

        [XmlText]
        public string Message { get; set; }
    }
}