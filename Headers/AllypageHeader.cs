using System;
using System.Xml.Serialization;

namespace GalaxyToolApi.Headers
{
    [Serializable]
    public class AllypageHeader
    {
        [XmlAttribute("name")]
        public string Name { get; set; }

        [XmlAttribute("allyid")]
        public int AllyId { get; set; }
    }
}