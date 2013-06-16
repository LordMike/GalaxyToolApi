using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using GalaxyToolApi.ComplexTypes;
using GalaxyToolApi.Enums;

namespace GalaxyToolApi.Roots
{
    [Serializable]
    [XmlRoot("fleets", Namespace = "", IsNullable = false)]
    public class Fleets : GalaxyToolRoot
    {
        [XmlElement("fleet")]
        public List<Fleet> Entries { get; set; }

        public Fleets()
        {
            Entries = new List<Fleet>();

            Header.ContentType = ContentType.FleetMovement;
        }
    }
}