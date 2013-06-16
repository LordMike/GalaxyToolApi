using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using GalaxyToolApi.ComplexTypes;
using GalaxyToolApi.Enums;

namespace GalaxyToolApi.Roots
{
    [Serializable]
    [XmlRoot("messages", Namespace = "", IsNullable = false)]
    public class Messages : GalaxyToolRoot
    {
        [XmlElement("message")]
        public List<Message> MessageEntries { get; set; }

        public Messages()
        {
            MessageEntries = new List<Message>();

            Header.ContentType = ContentType.Message;
        }
    }
}