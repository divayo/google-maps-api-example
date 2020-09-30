using GoogleMapsApiExample.Common.Dto;
using GoogleMapsApiExample.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GoogleMapsApiExample.Services
{
    public class LocationService : ILocationService
    {
        private readonly ILocationRepository _locationRepository;

        public LocationService(ILocationRepository locationRepository)
        {
            _locationRepository = locationRepository;
        }

        /// <summary>
        ///     Get all locations
        /// </summary>
        /// <returns></returns>
        public IEnumerable<LocationDto> GetLocations()
        {
            var results = _locationRepository.GetAllLocations();

            return results.Select(r => new LocationDto { Name = r.Name, Latitude = r.Latitude, Longitude = r.Longitude });
        }
    }
}
