using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdessoRideShare.WebApi.Application.Command;
using AdessoRideShare.WebApi.Application.Query;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AdessoRideShare.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IMediator _mediatr;
        public UsersController(IMediator mediatr)
        {
            _mediatr = mediatr;
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> Get([FromRoute]GetUserByIdQuery request)
        {
            return Ok(await _mediatr.Send(request));
        }


        /// <summary>
        /// Add User 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>

        [HttpPost]
        public async Task<IActionResult> Post([FromBody]AddUserCommand request)
        {
            var resp = await _mediatr.Send(request);
            return Created(new Uri($"/users/{resp.Id}"), resp);
        }
    }
}