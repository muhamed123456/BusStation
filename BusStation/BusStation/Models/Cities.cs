using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BusStation.Models
{
    public class Cities
    {
        public int ID { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        [Display(Name = "Departure City")]
        public string DepartureCity { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        [Display(Name = "Destination City")]
        public string DestinationCity { get; set; }

        [Display(Name = "Departure")]
        public DateTime DepartureTime { get; set; }

        [Display(Name = "Arrival")]
        public DateTime ArrivalTime { get; set; }

        [Display(Name = "Bus Company")]
        [DataType(DataType.Currency)]
        public string BusCompany { get; set; }
        public decimal Price { get; set; }
    }
}
