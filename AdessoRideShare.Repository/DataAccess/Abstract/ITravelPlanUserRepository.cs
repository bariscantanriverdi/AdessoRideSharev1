using AdessoRideShare.Repository.EntityModel.Concerete;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AdessoRideShare.Repository.DataAccess.Abstract
{
    public interface ITravelPlanUserRepository :IRepositoryBase<TravelPlanUsers>
    {
        Task<List<TravelPlan>> GetTravelTotalUsers(List<TravelPlan> travelPlan);
        Task<List<TravelPlan>> GetUserTravelPlans(int userId);
        Task<List<TravelPlan>> GetUserTravelPlansByFromIdToId(int userId, int fromId, int toId);
    }
}
