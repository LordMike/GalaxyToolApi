using System.Text;
using System.Xml.Serialization;

namespace GalaxyToolApi
{
    internal static class Serializer
    {
        public static string Serialize<T>(T obj)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            StringBuilder sb = new StringBuilder();
            using (StringWriterUtf8 writer = new StringWriterUtf8(sb))
                serializer.Serialize(writer, obj);

            return sb.ToString();
        }
    }
}