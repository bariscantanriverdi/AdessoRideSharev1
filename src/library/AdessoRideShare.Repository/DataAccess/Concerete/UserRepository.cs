using AdessoRideShare.Repository.Context.Concerete;
using AdessoRideShare.Repository.DataAccess.Abstract;
using AdessoRideShare.Repository.EntityModel.Concerete;

namespace AdessoRideShare.Repository.DataAccess.Concerete
{
    public class UserRepository : RepositoryBase<User>,IUserRepository
    {
        private readonly RideShareDbContext _context;
        public UserRepository(RideShareDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
