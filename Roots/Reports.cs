using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using GalaxyToolApi.ComplexTypes;
using GalaxyToolApi.Enums;

namespace GalaxyToolApi.Roots
{
    [Serializable]
    [XmlRoot("reports", Namespace = "", IsNullable = false)]
    public class Reports : GalaxyToolRoot
    {
        [XmlElement("report")]
        public List<Report> Entries { get; set; }

        public Reports()
        {
            Entries = new List<Report>();

            Header.ContentType = ContentType.Reports;
        }
    }
}