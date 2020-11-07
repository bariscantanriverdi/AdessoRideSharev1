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

        /// <summary>
        /// Get User By Id
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpGet("{Id}")]
        public async Task<IActionResult> Get([FromRoute]GetUserByIdQuery request)
        {
            var resp = await _mediatr.Send(request);
            if (resp == null)
                return NotFound();

            return Ok(resp);
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
            return StatusCode(201, resp);
        }
    }
}