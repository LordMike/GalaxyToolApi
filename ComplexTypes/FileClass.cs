using System;
using System.Xml.Serialization;

namespace GalaxyToolApi.ComplexTypes
{
    [Serializable]
    public class FileClass
    {
        [XmlAttribute("filename")]
        public string Filename { get; set; }

        [XmlAttribute("class")]
        public string Class { get; set; }
    }
}