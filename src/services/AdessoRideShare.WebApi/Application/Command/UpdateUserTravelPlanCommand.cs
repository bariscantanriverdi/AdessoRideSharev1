using AdessoRideShare.WebApi.Models;
using MediatR;
using System;

namespace AdessoRideShare.WebApi.Application.Command
{
    public class UpdateUserTravelPlanCommand : IRequest<TravelPlanUserModel>
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int TravelPlanId { get; set; }
        public string Description { get; set; }
        public int ChairCount { get; set; }
        public DateTime Date { get; set; }
        public int Status { get; set; }
    }
}
