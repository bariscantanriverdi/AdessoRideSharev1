using AdessoRideShare.WebApi.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdessoRideShare.WebApi.Application.Query
{
    public class GetTravelPlanUserByIdQuery:IRequest<TravelPlanUserModel>
    {
        public int Id { get; set; }
    }
}
