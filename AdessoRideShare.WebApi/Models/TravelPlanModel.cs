using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdessoRideShare.WebApi.Models
{
    public class TravelPlanModel
    {
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public int MaxChair { get; set; }
        public CityModel From { get; set; }
        public CityModel To { get; set; }
        public int AvailableChair { get { return MaxChair - TotalUsers; } }
        public int TotalUsers { get; set; }
        public int Status { get; set; }



    }
}
