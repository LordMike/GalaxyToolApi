using System;
using System.Xml.Serialization;

namespace GalaxyToolApi.Enums
{
    [Serializable]
    public enum CombatWinner
    {
        [XmlEnum("attacker")]
        Attacker,
        [XmlEnum("defender")]
        Defender,
        [XmlEnum("nobody")]
        Nobody
    }
}