using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace GoogleMapsApiExample.Data.Entities
{
    public class Location
    {
        [XmlAttribute]
        public string Name { get; set; }

        [XmlAttribute]
        public double Latitude { get; set; }

        [XmlAttribute]
        public double Longitude { get; set; }
    }

    [XmlRoot("Locations")]
    public class Locations
    {
        [XmlElement("Location")]
        public List<Location> LocationList { get; set; }
    }
}
