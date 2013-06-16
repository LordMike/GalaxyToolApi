using System;
using System.Xml.Serialization;

namespace GalaxyToolApi.ComplexTypes
{
    [Serializable]
    public class AmountEntry
    {
        [XmlAttribute("name")]
        public string Name { get; set; }

        [XmlAttribute("amount")]
        public int Amount { get; set; }

        public AmountEntry()
        {
            
        }

        public AmountEntry(string name, int amount)
        {
            if (amount < 0)
                throw new ArgumentOutOfRangeException("amount");

            Name = name;
            Amount = amount;
        }
    }
}