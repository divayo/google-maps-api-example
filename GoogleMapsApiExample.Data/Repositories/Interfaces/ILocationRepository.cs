using GoogleMapsApiExample.Data.Entities;
using System.Collections.Generic;

namespace GoogleMapsApiExample.Data.Repositories
{
    public interface ILocationRepository
    {
        /// <summary>
        ///     Get all locations
        /// </summary>
        /// <returns></returns>
        IEnumerable<Location> GetAllLocations();
    }
}