using System;
using System.Xml.Serialization;
using GalaxyToolApi.Headers;

namespace GalaxyToolApi.Roots
{
    [Serializable]
    [XmlInclude(typeof(AllyPage))]
    [XmlInclude(typeof(CombatReports))]
    [XmlInclude(typeof(EspionageActions))]
    [XmlInclude(typeof(FlagsAttribute))]
    [XmlInclude(typeof(GalaxyViews))]
    [XmlInclude(typeof(Messages))]
    [XmlInclude(typeof(Planetinfos))]
    [XmlInclude(typeof(Reports))]
    [XmlInclude(typeof(Stats))]
    public abstract class GalaxyToolRoot
    {
        [XmlElement("header")]
        public HeaderData Header { get; set; }

        protected GalaxyToolRoot()
        {
            Header = new HeaderData();
        }
    }
}