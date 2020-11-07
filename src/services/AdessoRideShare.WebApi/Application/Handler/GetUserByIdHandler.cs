﻿using AdessoRideShare.Repository.DataAccess.Abstract;
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
    public class GetUserByIdHandler : IRequestHandler<GetUserByIdQuery, UserModel>
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;
        public GetUserByIdHandler(IMapper mapper, IUserRepository userRepository)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }
        public async Task<UserModel> Handle(GetUserByIdQuery request, CancellationToken cancellationToken)
        {
            var user=await _userRepository.GetAsync(x => x.Id == request.Id);
            return _mapper.Map<UserModel>(user);
        }
    }
}
