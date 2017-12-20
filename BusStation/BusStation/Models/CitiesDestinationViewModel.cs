using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BusStation.Models
{
    public class CitiesDestinationViewModel
    {
        public List<Cities> cities;
        public  SelectList destination;
        public string CitiesDestination { get; set; }
    }
}
