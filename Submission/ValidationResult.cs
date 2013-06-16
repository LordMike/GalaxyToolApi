using System.Collections.Generic;
using System.Xml.Serialization;

namespace GalaxyToolApi.Submission
{
    [XmlRoot("galaxytool")]
    public class ValidationResult : GalaxyToolResult
    {
        [XmlElement("permission")]
        public List<GalaxyToolPermission> Permissions { get; set; }
    }
}
