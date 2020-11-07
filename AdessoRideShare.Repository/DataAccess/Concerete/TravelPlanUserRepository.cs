using AdessoRideShare.Repository.Context.Concerete;
using AdessoRideShare.Repository.DataAccess.Abstract;
using AdessoRideShare.Repository.EntityModel.Concerete;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdessoRideShare.Repository.DataAccess.Concerete
{
    public class TravelPlanUserRepository : RepositoryBase<TravelPlanUsers>, ITravelPlanUserRepository
    {
        private readonly RideShareDbContext _context;
        public TravelPlanUserRepository(RideShareDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<List<TravelPlan>> GetUserTravelPlans(int userId) => await _context.TravelPlanUsers.Include(x => x.TravelPlan).Include(x => x.User).Where(x => x.UserId == userId).Select(x => x.TravelPlan).ToListAsync();

        public async Task<List<TravelPlan>> GetUserTravelPlansByFromIdToId(int userId, int fromId, int toId) => await _context.TravelPlanUsers.Include(x => x.TravelPlan).Include(x => x.User).Where(x => x.TravelPlan.FromId == fromId && x.TravelPlan.ToId == toId && x.UserId == userId && x.Status == 1).Select(x => x.TravelPlan).ToListAsync();

        public async Task<List<TravelPlan>> GetTravelTotalUsers(List<TravelPlan> travelPlan)
        {
            foreach (var item in travelPlan)
            {
                item.TotalUsers = await _context.TravelPlanUsers.Where(x => x.TravelPlanId == item.Id).SumAsync(x=>x.ChairCount);
            }
            return travelPlan;
        }

    }
}
