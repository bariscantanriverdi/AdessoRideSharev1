using AdessoRideShare.Repository.EntityModel.Concerete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdessoRideShare.WebApi.Models
{
    public class TravelPlanUserModel
    {
        public int Id { get; set; }
        public int Status { get; set; }
        public int ChairCount { get; set; }
        public string Description { get; set; }


    }
}
