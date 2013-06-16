using System;
using System.Xml.Serialization;
using GalaxyToolApi.Enums;

namespace GalaxyToolApi.Headers
{
    [Serializable]
    public class HeaderData
    {
        [XmlAttribute("version")]
        public string Version { get; set; }

        [XmlAttribute("universe")]
        public string Universe { get; set; }

        [XmlAttribute("debug")]
        public bool Debug { get; set; }

        [XmlAttribute("language")]
        public Language Language { get; set; }

        [XmlAttribute("token")]
        public string Token { get; set; }

        [XmlAttribute("content_type")]
        public ContentType ContentType { get; set; }
    }
}