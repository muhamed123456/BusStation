using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace BusStation.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new BusStationContext(
                serviceProvider.GetRequiredService<DbContextOptions<BusStationContext>>()))
            {
                if (context.Cities.Any())
                {
                    return;
                }
                context.Cities.AddRange(
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
                );
                context.SaveChanges();
            }
        }
    }
}
