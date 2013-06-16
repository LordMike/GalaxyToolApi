using System.Xml.Serialization;

namespace GalaxyToolApi.Enums
{
    public enum MessageSeverity
    {
        [XmlEnum("E")]
        Error,
        [XmlEnum("W")]
        Warning,
        [XmlEnum("I")]
        Information
    }
}