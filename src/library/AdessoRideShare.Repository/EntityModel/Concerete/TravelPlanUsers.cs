using System;
using System.Collections.Generic;
using System.Text;

namespace AdessoRideShare.Repository.EntityModel.Concerete
{
    public class TravelPlanUsers : BaseEntityModel
    {
        public TravelPlan TravelPlan { get; set; }
        public int TravelPlanId { get; set; }
        public User User { get; set; }
        public int UserId { get; set; }
        public int Status { get; set; }
        public int ChairCount { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
    }
}
