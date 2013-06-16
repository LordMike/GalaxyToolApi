using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using GalaxyToolApi.ComplexTypes;
using GalaxyToolApi.Enums;

namespace GalaxyToolApi.Roots
{
    [Serializable]
    [XmlRoot("combat_reports", Namespace = "", IsNullable = false)]
    public class CombatReports : GalaxyToolRoot
    {
        [XmlElement("combat_report")]
        public List<CombatReport> Entries { get; set; }

        public CombatReports()
        {
            Entries = new List<CombatReport>();

            Header.ContentType = ContentType.CombatReport;
        }
    }
}