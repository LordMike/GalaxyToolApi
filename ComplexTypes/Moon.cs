using System;
using System.Xml.Serialization;

namespace GalaxyToolApi.ComplexTypes
{
    [Serializable]
    public class Moon
    {
        [XmlAttribute("size")]
        public int Size { get; set; }
    }
}