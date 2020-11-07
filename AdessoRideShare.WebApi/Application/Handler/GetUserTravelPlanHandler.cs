using AdessoRideShare.Repository.DataAccess.Abstract;
using AdessoRideShare.Repository.EntityModel.Concerete;
using AdessoRideShare.WebApi.Application.Query;
using AdessoRideShare.WebApi.Models;
using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace AdessoRideShare.WebApi.Application.Handler
{
    public class GetUserTravelPlanHandler : IRequestHandler<GetUserTravelPlanQuery, List<TravelPlanModel>>
    {
        private readonly ITravelPlanUserRepository _travelPlanUserRepository;
        private readonly IMapper _mapper;
        public GetUserTravelPlanHandler(IMapper mapper, ITravelPlanUserRepository travelPlanUserRepository)
        {
            _travelPlanUserRepository = travelPlanUserRepository;
            _mapper = mapper;
        }
        public async Task<List<TravelPlanModel>> Handle(GetUserTravelPlanQuery request, CancellationToken cancellationToken)
        {
            List<TravelPlan> resp = new List<TravelPlan>();
            if(request.FromId==null || request.ToId==null)
                resp = await _travelPlanUserRepository.GetUserTravelPlans(request.UserId);
            else
                resp = await _travelPlanUserRepository.GetUserTravelPlansByFromIdToId(request.UserId,request.FromId.Value,request.ToId.Value);
            
            resp = await _travelPlanUserRepository.GetTravelTotalUsers(resp);
            return _mapper.Map<List<TravelPlanModel>>(resp);
        }
    }
}
