using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using GalaxyToolApi.ComplexTypes;
using GalaxyToolApi.Enums;

namespace GalaxyToolApi.Roots
{
    [Serializable]
    [XmlRoot("planetinfos", Namespace = "", IsNullable = false)]
    public class Planetinfos : GalaxyToolRoot
    {
        [XmlElement("planetinfo")]
        public List<PlanetInfo> PlanetinfoEntries { get; set; }

        public Planetinfos()
        {
            PlanetinfoEntries = new List<PlanetInfo>();

            Header.ContentType = ContentType.Planetinfo;
        }
    }
}