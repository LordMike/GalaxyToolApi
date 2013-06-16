using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using GalaxyToolApi.ComplexTypes;

namespace GalaxyToolApi.Roots
{
    [Serializable]
    [XmlRoot("plugins", Namespace = "", IsNullable = false)]
    public class PluginsInfo
    {
        [XmlElement("plugin")]
        public List<PluginInfo> Plugins { get; set; }

        public PluginsInfo()
        {
            Plugins = new List<PluginInfo>();
        }
    }
}
