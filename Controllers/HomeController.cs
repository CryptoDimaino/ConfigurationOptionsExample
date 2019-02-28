using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ConfigurationOptionsExample.Models;
using Microsoft.Extensions.Options;

namespace ConfigurationOptionsExample.Controllers
{
    public class HomeController : Controller
    {
        private readonly IOptions<MySettings> configMy;
        private readonly IOptions<MoreSettings> configMore;
        public HomeController(IOptions<MySettings> configMySettings, IOptions<MoreSettings> configMoreSettings)
        {
            configMy = configMySettings;
            configMore = configMoreSettings;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [HttpGet("SettingOne")]
        public string SettingOne()
        {
            return configMy.Value.SettingOne;
        }

        [HttpGet("SettingTwo")]
        public int SettingTwo()
        {
            return configMy.Value.SettingTwo;
        }

        [HttpGet("Name")]
        public string Name()
        {
            return configMore.Value.Name;
        }

        [HttpGet("TrueOrFalse")]
        public bool TrueOrFalse()
        {
            return configMore.Value.TrueOrFalse;
        }

        [HttpGet("Car")]
        public List<Car> Car()
        {
            return configMore.Value.Car;
        }

        [HttpGet("CarName")]
        public string CarName()
        {
            return configMore.Value.Car[0].Name + "\n" + configMore.Value.Car[1].Name + "\n" + configMore.Value.Car[2].Name;
        }

        [HttpGet("CarModel")]
        public string CarModel()
        {
            string toReturn = "";
            foreach(var car in configMore.Value.Car)
            {
                foreach(var model in car.models)
                {
                    toReturn += model + " ";
                }
                toReturn += "\n";
            }
            return toReturn;
        }
    }
}
