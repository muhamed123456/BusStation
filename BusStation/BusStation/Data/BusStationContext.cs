using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BusStation.Models
{
    public class BusStationContext : DbContext
    {
        public BusStationContext (DbContextOptions<BusStationContext> options)
            : base(options)
        {
        }

        public DbSet<BusStation.Models.Cities> Cities { get; set; }
    }
}
