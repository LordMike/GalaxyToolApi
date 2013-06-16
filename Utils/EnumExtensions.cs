using System;
using System.Reflection;
using System.Xml.Serialization;

namespace GalaxyToolApi.Utils
{
    public static class EnumExtensions
    {
        public static string GetXmlEnumString(this Enum value)
        {
            FieldInfo fi = value.GetType().GetField(value.ToString());
            XmlEnumAttribute[] attributes = (XmlEnumAttribute[])fi.GetCustomAttributes(typeof(XmlEnumAttribute), false);
            return attributes.Length > 0 ? attributes[0].Name : value.ToString();
        }
    }
}