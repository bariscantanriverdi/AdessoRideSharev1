using AdessoRideShare.Repository.DataAccess.Abstract;
using AdessoRideShare.WebApi.Application.Query;
using AdessoRideShare.WebApi.Models;
using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace AdessoRideShare.WebApi.Application.Handler
{
    public class GetTravelPlanHandler : IRequestHandler<GetTravelPlanQuery, List<TravelPlanModel>>
    {
        private readonly ITravelPlanRepository _travelPlanRepository;
        private readonly ITravelPlanUserRepository _travelPlanUserRepository;
        private readonly IMapper _mapper;
        public GetTravelPlanHandler(ITravelPlanRepository travelPlanRepository, IMapper mapper, ITravelPlanUserRepository travelPlanUserRepository)
        {
            _travelPlanRepository = travelPlanRepository;
            _travelPlanUserRepository = travelPlanUserRepository;
            _mapper = mapper;
        }
        public async Task<List<TravelPlanModel>> Handle(GetTravelPlanQuery request, CancellationToken cancellationToken)
        {
             var resp =await _travelPlanRepository.GetTravelPlanByFromIdToId(request.FromId,request.ToId);
              resp=await _travelPlanUserRepository.GetTravelTotalUsers(resp);
            return  _mapper.Map<List<TravelPlanModel>>(resp);
        }
    }
}
