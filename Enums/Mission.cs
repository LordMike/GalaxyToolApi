using System;
using System.Xml.Serialization;

namespace GalaxyToolApi.Enums
{
    [Serializable]
    public enum Mission
    {
        [XmlEnum("expedition")]
        Expedition,
        [XmlEnum("colonization")]
        Colonization,
        [XmlEnum("recycle")]
        Recycle,
        [XmlEnum("transport")]
        Transport,
        [XmlEnum("deployment")]
        Deployment,
        [XmlEnum("espionage")]
        Espionage,
        [XmlEnum("acs_defend")]
        AcsDefend,
        [XmlEnum("attack")]
        Attack,
        [XmlEnum("acs_attack")]
        AcsAttack,
        [XmlEnum("moon_destruction")]
        MoonDestruction,
        [XmlEnum("missile_attack")]
        MissileAttack
    }
}