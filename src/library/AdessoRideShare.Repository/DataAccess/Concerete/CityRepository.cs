using AdessoRideShare.Repository.Context.Concerete;
using AdessoRideShare.Repository.DataAccess.Abstract;
using AdessoRideShare.Repository.EntityModel.Concerete;

namespace AdessoRideShare.Repository.DataAccess.Concerete
{
    public class CityRepository : RepositoryBase<City>,ICityRepository
    {
        private readonly RideShareDbContext _context;
        public CityRepository(RideShareDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
