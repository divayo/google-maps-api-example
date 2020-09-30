using GoogleMapsApiExample.Common.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoogleMapsApiExample.Models
{
    public class HomeModel
    {
        public HomeModel()
        {
            Locations = new List<LocationDto>();
        }

        public IEnumerable<LocationDto> Locations { get; set; }
    }
}
