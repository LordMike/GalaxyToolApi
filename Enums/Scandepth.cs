using System;
using System.Xml.Serialization;

namespace GalaxyToolApi.Enums
{
    [Serializable]
    public enum Scandepth
    {
        [XmlEnum("resources")]
        Resources,
        [XmlEnum("fleet")]
        Fleet,
        [XmlEnum("defence")]
        Defense,
        [XmlEnum("buildings")]
        Buildings,
        [XmlEnum("research")]
        Research
    }
}