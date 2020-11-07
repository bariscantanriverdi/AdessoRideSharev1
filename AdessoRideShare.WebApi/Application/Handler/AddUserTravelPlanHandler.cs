using AdessoRideShare.Repository.DataAccess.Abstract;
using AdessoRideShare.Repository.EntityModel.Concerete;
using AdessoRideShare.WebApi.Application.Command;
using AdessoRideShare.WebApi.Enums;
using AdessoRideShare.WebApi.Models;
using AutoMapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace AdessoRideShare.WebApi.Application.Handler
{
    public class AddUserTravelPlanHandler : IRequestHandler<AddUserTravelPlanCommand, TravelPlanUserModel>
    {
        private readonly ITravelPlanUserRepository _travelPlanUserRepository;
        private readonly IMapper _mapper;
        public AddUserTravelPlanHandler(IMapper mapper, ITravelPlanUserRepository travelPlanUserRepository)
        {
            _travelPlanUserRepository = travelPlanUserRepository;
            _mapper = mapper;
        }
        public async Task<TravelPlanUserModel> Handle(AddUserTravelPlanCommand request, CancellationToken cancellationToken)
        {
            var travelPlanUser=_mapper.Map<TravelPlanUsers>(request);
            travelPlanUser.Status = (int)Status.Active;
            var resp =await _travelPlanUserRepository.AddAsync(travelPlanUser);

            return _mapper.Map<TravelPlanUserModel>(resp);
        }
    }
}
