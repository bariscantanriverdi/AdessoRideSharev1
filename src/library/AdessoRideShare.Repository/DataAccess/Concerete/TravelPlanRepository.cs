using AdessoRideShare.Repository.Context.Concerete;
using AdessoRideShare.Repository.DataAccess.Abstract;
using AdessoRideShare.Repository.EntityModel.Concerete;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdessoRideShare.Repository.DataAccess.Concerete
{
    public class TravelPlanRepository : RepositoryBase<TravelPlan>, ITravelPlanRepository
    {
        private readonly RideShareDbContext _context;
        public TravelPlanRepository(RideShareDbContext context) : base(context)
        {
            _context = context;
        }

        public Task<List<TravelPlan>> GetTravelPlanByFromIdToId(int fromId, int toId)
        {
            return _context.TravelPlans.Include(x => x.From)
                                       .Include(x => x.To).Where(x => x.FromId == fromId && x.ToId == toId && x.Status==1).ToListAsync();
        }

    }
}
