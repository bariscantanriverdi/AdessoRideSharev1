using AdessoRideShare.Repository.EntityModel.Concerete;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AdessoRideShare.Repository.DataAccess.Abstract
{
    public interface ITravelPlanRepository :IRepositoryBase<TravelPlan>
    {
        Task<List<TravelPlan>> GetTravelPlanByFromIdToId(int fromId, int toId);
    }
}
