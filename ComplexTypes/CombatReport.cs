using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace GalaxyToolApi.ComplexTypes
{
    [Serializable]
    public class CombatReport
    {
        [XmlElement("combat_result")]
        public CombatResult CombatResult { get; set; }

        [XmlElement("combat_party")]
        public List<CombatParty> CombatParty { get; set; }

        [XmlAttribute("msg_id")]
        public int MsgId { get; set; }

        public CombatReport()
        {
            CombatResult = new CombatResult();
            CombatParty = new List<CombatParty>();
        }
    }
}