using System;
using System.Xml.Serialization;

namespace GalaxyToolApi.Enums
{
    [Serializable]
    public enum CombatType
    {
        [XmlEnum("attacker")]
        Attacker,
        [XmlEnum("defender")]
        Defender,
    }
}