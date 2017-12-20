using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusStation.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BusStation.Controllers
{
    [Produces("application/json")]
    [Route("api/CitiesAPI")]
    public class CitiesAPIController : Controller
    {
        // GET: api/GetAllCities  
        [HttpGet]
        public IEnumerable<Cities> GetAllCities()
        {
            List<Cities> cities = new List<Cities>
           {
                new Cities
                     {
                         DepartureCity = "Resen",
                         DestinationCity = "Ohrid",
                         DepartureTime = DateTime.Parse ("01.01.2018 08:00:00"),
                         ArrivalTime = DateTime.Parse ("01.01.2018 08:45:00"),
                         BusCompany = "Galeb",
                         Price = 150
                     },
                     new Cities
                     {
                         DepartureCity = "Resen",
                         DestinationCity = "Ohrid",
                         DepartureTime = DateTime.Parse("01.01.2018 09:30:00"),
                         ArrivalTime = DateTime.Parse("01.01.2018 10:15:00"),
                         BusCompany = "Transkop",
                         Price = 140
                     },
                     new Cities
                     {
                         DepartureCity = "Ohrid",
                         DestinationCity = "Resen",
                         DepartureTime = DateTime.Parse("01.01.2018 13:00:00"),
                         ArrivalTime = DateTime.Parse("01.01.2018 13:45:00"),
                         BusCompany = "Galeb",
                         Price = 150
                     },
                     new Cities
                     {
                         DepartureCity = "Ohrid",
                         DestinationCity = "Resen",
                         DepartureTime = DateTime.Parse("01.01.2018 15:00:00"),
                         ArrivalTime = DateTime.Parse("01.01.2018 15:45:00"),
                         BusCompany = "Transkop",
                         Price = 140
                     },
                     new Cities
                     {
                         DepartureCity = "Resen",
                         DestinationCity = "Bitola",
                         DepartureTime = DateTime.Parse("01.01.2018 08:00:00"),
                         ArrivalTime = DateTime.Parse("01.01.2018 08:30:00"),
                         BusCompany = "Transkop",
                         Price = 90
                     },
                     new Cities
                     {
                         DepartureCity = "Resen",
                         DestinationCity = "Bitola",
                         DepartureTime = DateTime.Parse("01.01.2018 10:00:00"),
                         ArrivalTime = DateTime.Parse("01.01.2018 10:30:00"),
                         BusCompany = "Galeb",
                         Price = 100
                     },
                     new Cities
                     {
                         DepartureCity = "Bitola",
                         DestinationCity = "Resen",
                         DepartureTime = DateTime.Parse("01.01.2018 16:00:00"),
                         ArrivalTime = DateTime.Parse("01.01.2018 16:30:00"),
                         BusCompany = "Transkop",
                         Price = 90
                     },
                     new Cities
                     {
                         DepartureCity = "Bitola",
                         DestinationCity = "Resen",
                         DepartureTime = DateTime.Parse("01.01.2018 18:00:00"),
                         ArrivalTime = DateTime.Parse("01.01.2018 18:45:00"),
                         BusCompany = "Galeb",
                         Price = 100
                     },
                     new Cities
                     {
                         DepartureCity = "Resen",
                         DestinationCity = "Skopje",
                         DepartureTime = DateTime.Parse("01.01.2018 06:45:00"),
                         ArrivalTime = DateTime.Parse("01.01.2018 10:15:00"),
                         BusCompany = "Galeb",
                         Price = 550
                     },
                     new Cities
                     {
                         DepartureCity = "Resen",
                         DestinationCity = "Skopje",
                         DepartureTime = DateTime.Parse("01.01.2018 08:00:00"),
                         ArrivalTime = DateTime.Parse("01.01.2018 12:00:00"),
                         BusCompany = "Transkop",
                         Price = 520
                     },
                     new Cities
                     {
                         DepartureCity = "Skopje",
                         DestinationCity = "Resen",
                         DepartureTime = DateTime.Parse("01.01.2018 16:00:00"),
                         ArrivalTime = DateTime.Parse("01.01.2018 19:30:00"),
                         BusCompany = "Galeb",
                         Price = 550
                     },
                     new Cities
                     {
                         DepartureCity = "Skopje",
                         DestinationCity = "Resen",
                         DepartureTime = DateTime.Parse("01.01.2018 17:30:00"),
                         ArrivalTime = DateTime.Parse("01.01.2018 21:30:00"),
                         BusCompany = "Transkop",
                         Price = 520
                     }
           };
            return cities;
        }
    }
}