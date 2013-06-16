using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using GalaxyToolApi.ComplexTypes;
using GalaxyToolApi.Enums;

namespace GalaxyToolApi.Roots
{
    [Serializable]
    [XmlRoot("espionage_actions", Namespace = "", IsNullable = false)]
    public class EspionageActions : GalaxyToolRoot
    {
        [XmlElement("espionage")]
        public List<Espionage> EspionageEntries { get; set; }

        public EspionageActions()
        {
            EspionageEntries = new List<Espionage>();

            Header.ContentType = ContentType.Espionage;
        }
    }
}