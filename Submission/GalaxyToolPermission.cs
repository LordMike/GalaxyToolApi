using System.Xml.Serialization;

namespace GalaxyToolApi.Submission
{
    public class GalaxyToolPermission
    {
        [XmlAttribute("name")]
        public string Name { get; set; }

        [XmlText]
        public bool Value { get; set; }
    }
}