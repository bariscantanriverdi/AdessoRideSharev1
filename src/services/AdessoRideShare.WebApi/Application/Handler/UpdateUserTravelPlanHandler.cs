using AdessoRideShare.Repository.DataAccess.Abstract;
using AdessoRideShare.Repository.EntityModel.Concerete;
using AdessoRideShare.WebApi.Application.Command;
using AdessoRideShare.WebApi.Models;
using AutoMapper;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace AdessoRideShare.WebApi.Application.Handler
{
    public class UpdateUserTravelPlanHandler : IRequestHandler<UpdateUserTravelPlanCommand, TravelPlanUserModel>
    {
        private readonly ITravelPlanUserRepository _travelPlanUserRepository;
        private readonly IMapper _mapper;
        public UpdateUserTravelPlanHandler(IMapper mapper, ITravelPlanUserRepository travelPlanUserRepository)
        {
            _travelPlanUserRepository = travelPlanUserRepository;
            _mapper = mapper;
        }
        public async Task<TravelPlanUserModel> Handle(UpdateUserTravelPlanCommand request, CancellationToken cancellationToken)
        {
            var entity=_mapper.Map<TravelPlanUsers>(request);
            var updatedEntity=await _travelPlanUserRepository.UpdateAsync(entity);
            return _mapper.Map<TravelPlanUserModel>(updatedEntity);
        }
    }
}
