using System;
using System.Xml.Serialization;

namespace GalaxyToolApi.Submission
{
    [Serializable]
    public abstract class GalaxyToolResult
    {
        [XmlAttribute("universe")]
        public string Universe { get; set; }

        [XmlElement("version")]
        public GalaxyToolVersion Version { get; set; }
    }
}