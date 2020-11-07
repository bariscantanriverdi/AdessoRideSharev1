using AdessoRideShare.WebApi.Models;
using MediatR;
using System;

namespace AdessoRideShare.WebApi.Application.Command
{
    public class AddUserTravelPlanCommand : IRequest<TravelPlanUserModel>
    {
        public TravelPlanModel model { get; set; }

    }
}
