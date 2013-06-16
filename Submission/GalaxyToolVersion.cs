using System;
using System.Xml.Serialization;

namespace GalaxyToolApi.Submission
{
    public class GalaxyToolVersion
    {
        [XmlAttribute("major")]
        public int Major { get; set; }

        [XmlAttribute("minor")]
        public int Minor { get; set; }

        [XmlAttribute("revision")]
        public int Revision { get; set; }

        [XmlIgnore]
        public Version Version
        {
            get { return new Version(Major, Minor, 0, Revision); }
            set
            {
                Major = value.Major;
                Minor = value.Minor;
                Revision = value.Revision;
            }
        }
    }
}