using AdessoRideShare.WebApi.Models;
using MediatR;
using System.Collections.Generic;

namespace AdessoRideShare.WebApi.Application.Query
{
    public class GetTravelPlanQuery : IRequest<List<TravelPlanModel>>
    {
        public int FromId { get; set; }
        public int ToId { get; set; }

    }
}
