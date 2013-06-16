using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using GalaxyToolApi.ComplexTypes;
using GalaxyToolApi.Enums;

namespace GalaxyToolApi.Roots
{
    [Serializable]
    [XmlRoot("galaxyviews", Namespace = "", IsNullable = false)]
    public class GalaxyViews : GalaxyToolRoot
    {
        [XmlElement("galaxyview")]
        public List<GalaxyView> Entries { get; set; }

        public GalaxyViews()
        {
            Entries = new List<GalaxyView>();

            Header.ContentType = ContentType.Galaxyview;
        }
    }
}