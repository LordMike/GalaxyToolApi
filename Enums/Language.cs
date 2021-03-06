﻿using System;
using System.Xml.Serialization;

namespace GalaxyToolApi.Enums
{
    [Serializable]
    public enum Language
    {
        [XmlEnum("german")]
        German,
        [XmlEnum("english")]
        English,
        [XmlEnum("spanish")]
        Spanish,
        [XmlEnum("dutch")]
        Dutch,
        [XmlEnum("balkan")]
        Balkan,
        [XmlEnum("french")]
        French,
        [XmlEnum("portugues")]
        Portugues,
        [XmlEnum("polish")]
        Polish,
        [XmlEnum("italian")]
        Italian,
        [XmlEnum("turkish")]
        Turkish,
        [XmlEnum("danish")]
        Danish,
        [XmlEnum("brazilian")]
        Brazilian,
        [XmlEnum("russian")]
        Russian,
        [XmlEnum("swedish")]
        Swedish,
        [XmlEnum("greek")]
        Greek,
        [XmlEnum("romanian")]
        Romanian,
        [XmlEnum("hungarian")]
        Hungarian,
        [XmlEnum("czech")]
        Czech,
        [XmlEnum("korean")]
        Korean,
        [XmlEnum("norwegian")]
        Norwegian,
        [XmlEnum("taiwan")]
        Taiwan,
        [XmlEnum("japan")]
        Japan,
        [XmlEnum("chinese")]
        Chinese,
        [XmlEnum("bulgarian")]
        Bulgarian,
        [XmlEnum("lithuanian")]
        Lithuanian,
        [XmlEnum("latvian")]
        Latvian,
        [XmlEnum("finnish")]
        Finnish,
        [XmlEnum("slovak")]
        Slovak,
        [XmlEnum("croatian")]
        Croatian,
        [XmlEnum("serbian")]
        Serbian,
        [XmlEnum("slovenian")]
        Slovenian
    }
}