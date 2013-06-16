using System;
using System.Xml.Serialization;

namespace GalaxyToolApi.Enums
{
    [Serializable]
    public enum ContentType
    {
        [XmlEnum("galaxyview")]
        Galaxyview,
        [XmlEnum("player_stats")]
        PlayerStats,
        [XmlEnum("ally_stats")]
        AllyStats,
        [XmlEnum("player_highscore")]
        PlayerHighscore,
        [XmlEnum("ally_highscore")]
        AllyHighscore,
        [XmlEnum("allypage")]
        Allypage,
        [XmlEnum("reports")]
        Reports,
        [XmlEnum("planetinfo")]
        Planetinfo,
        [XmlEnum("fleet_movement")]
        FleetMovement,
        [XmlEnum("combat_report")]
        CombatReport,
        [XmlEnum("espionage")]
        Espionage,
        [XmlEnum("message")]
        Message
    }
}