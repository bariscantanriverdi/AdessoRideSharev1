using AdessoRideShare.Repository.DataAccess.Abstract;
using AdessoRideShare.WebApi.Application.Query;
using AdessoRideShare.WebApi.Models;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace AdessoRideShare.WebApi.Application.Handler
{
    public class GetTralPlanUserByIdHandler : IRequestHandler<GetTravelPlanUserByIdQuery, TravelPlanUserModel>
    {
        private readonly ITravelPlanUserRepository _travelPlanUserRepository;
        private readonly IMapper _mapper;
        public GetTralPlanUserByIdHandler(IMapper mapper, ITravelPlanUserRepository travelPlanUserRepository)
        {
            _travelPlanUserRepository = travelPlanUserRepository;
            _mapper = mapper;
        }
        public async Task<TravelPlanUserModel> Handle(GetTravelPlanUserByIdQuery request, CancellationToken cancellationToken)
        {
            var resp =await _travelPlanUserRepository.GetAsync(x => x.Id == request.Id);
            return _mapper.Map<TravelPlanUserModel>(resp);
        }
    }
}
