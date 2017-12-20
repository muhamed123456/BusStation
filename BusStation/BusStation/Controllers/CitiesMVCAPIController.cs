using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace BusStation.Controllers
{
    public class CitiesMVCAPIController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}