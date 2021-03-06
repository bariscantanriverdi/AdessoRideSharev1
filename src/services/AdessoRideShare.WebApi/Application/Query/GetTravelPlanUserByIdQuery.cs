﻿using AdessoRideShare.WebApi.Models;
using MediatR;

namespace AdessoRideShare.WebApi.Application.Query
{
    public class GetTravelPlanUserByIdQuery:IRequest<TravelPlanUserModel>
    {
        public int Id { get; set; }
    }
}
