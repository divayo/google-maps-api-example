using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using GoogleMapsApiExample.Models;
using GoogleMapsApiExample.Services;
using GoogleMapsApiExample.Common;

namespace GoogleMapsApiExample.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILocationService _locationService;
        private readonly ILogger<HomeController> _logger;
        private readonly AppSettings _appSettings;

        public HomeController(ILocationService locationService, ILogger<HomeController> logger, AppSettings appSettings)
        {
            _locationService = locationService;
            _logger = logger;
            _appSettings = appSettings;
        }

        public IActionResult Index()
        {
            var model = new HomeModel();

            model.Locations = _locationService.GetLocations();

            ViewData["ApiKey"] = _appSettings.ApiKey;
            return View(model);
        }       

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
