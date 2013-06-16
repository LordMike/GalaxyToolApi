using System;
using System.Xml.Serialization;

namespace GalaxyToolApi.Enums
{
    [Serializable]
    public enum StatsType
    {
        [XmlEnum("score")]
        Score,
        [XmlEnum("points")]
        Points,
        [XmlEnum("economy")]
        Economy,
        [XmlEnum("research")]
        Research,
        [XmlEnum("fleet")]
        Fleet,
        [XmlEnum("fleet_lost")]
        FleetLost,
        [XmlEnum("fleet_built")]
        FleetBuilt,
        [XmlEnum("fleet_destroyed")]
        FleetDestroyed,
        [XmlEnum("honor_points")]
        HonorPoints,
    }
}