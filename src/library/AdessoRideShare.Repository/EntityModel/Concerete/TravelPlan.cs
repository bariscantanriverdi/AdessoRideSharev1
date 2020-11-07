using System;
using System.Collections.Generic;

namespace AdessoRideShare.Repository.EntityModel.Concerete
{
    public class TravelPlan : BaseEntityModel
    {
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public int MaxChair { get; set; }
        public int FromId { get; set; }
        public int ToId { get; set; }
        public int TotalUsers { get; set; }
        public int AvailableChair { get { return MaxChair - TotalUsers; } }
        public int Status { get; set; }
        public virtual City From { get; set; }
        public virtual City To { get; set; }

    }
}
