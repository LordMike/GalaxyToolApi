using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace GalaxyToolApi.ComplexTypes
{
    [Serializable]
    public class GalaxyView
    {
        [XmlElement("position")]
        public List<PlanetPosition> Positions { get; set; }

        [XmlAttribute("galaxy")]
        public int Galaxy { get; set; }

        [XmlAttribute("system")]
        public int System { get; set; }

        public GalaxyView()
        {
            Positions = new List<PlanetPosition>();
        }
    }
}