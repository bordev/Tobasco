﻿using System.Xml.Serialization;

namespace Tobasco.Model
{
    public class Transaction
    {
        [XmlAttribute("useTransaction")]
         public bool UseTransaction { get; set; }
    }
}