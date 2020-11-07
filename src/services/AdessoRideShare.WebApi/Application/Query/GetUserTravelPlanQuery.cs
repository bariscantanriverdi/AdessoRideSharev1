using AdessoRideShare.WebApi.Models;
using MediatR;
using System.Collections.Generic;

namespace AdessoRideShare.WebApi.Application.Query
{
    public class GetUserTravelPlanQuery : IRequest<List<TravelPlanModel>>
    {
        public int UserId { get; set; }
        public int? FromId { get; set; }
        public int? ToId { get; set; }

    }
}
