using AdessoRideShare.Repository.DataAccess.Abstract;
using AdessoRideShare.Repository.EntityModel.Concerete;
using AdessoRideShare.WebApi.Application.Command;
using AdessoRideShare.WebApi.Models;
using AutoMapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace AdessoRideShare.WebApi.Application.Handler
{
    public class AddUserHandler : IRequestHandler<AddUserCommand, UserModel>
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;
        public AddUserHandler(IMapper mapper, IUserRepository userRepository)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }
        public async Task<UserModel> Handle(AddUserCommand request, CancellationToken cancellationToken)
        {
            var user=_mapper.Map<User>(request);
            var resp=await _userRepository.AddAsync(user);
            return _mapper.Map<UserModel>(resp);
        }
    }
}
