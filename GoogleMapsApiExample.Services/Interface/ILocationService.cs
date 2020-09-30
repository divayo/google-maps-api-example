using GoogleMapsApiExample.Common.Dto;
using System.Collections.Generic;

namespace GoogleMapsApiExample.Services
{
    public interface ILocationService
    {
        /// <summary>
        ///     Get all locations
        /// </summary>
        /// <returns></returns>
        IEnumerable<LocationDto> GetLocations();
    }
}