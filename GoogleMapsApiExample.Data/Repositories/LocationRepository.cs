using GoogleMapsApiExample.Common;
using GoogleMapsApiExample.Data.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using System.Xml.Serialization;

namespace GoogleMapsApiExample.Data.Repositories
{
    public class LocationRepository : ILocationRepository
    {
        private readonly AppSettings _appSettings;

        private List<Location> _locationList;

        public LocationRepository(AppSettings appSettings)
        {
            _appSettings = appSettings;
            LoadLocations();
        }

        /// <summary>
        ///     Get all locations
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Location> GetAllLocations()
        {
            return _locationList;
        }

        private void LoadLocations()
        {
            _locationList = new List<Location>();

            using (var fileStream = File.Open(_appSettings.LocationFileName, FileMode.Open))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Locations));
                var locations = (Locations)serializer.Deserialize(fileStream);

                foreach (var item in locations.LocationList)
                {
                    _locationList.Add(item);
                }
            }
        }
    }
}
