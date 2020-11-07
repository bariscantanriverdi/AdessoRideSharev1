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
    public class UserTravelPlansController : ControllerBase
    {
        private readonly IMediator _mediatr;
        public UserTravelPlansController(IMediator mediatr)
        {
            _mediatr = mediatr;
        }

        /// <summary>
        /// Get Users Travel Plans
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>

        [HttpGet]
        public async Task<IActionResult> Get([FromQuery]GetUserTravelPlanQuery query)
        {
            var resp = await _mediatr.Send(query);
            if (resp == null)
                return NotFound();

            return Ok(resp);
        }

        [HttpGet("{Id}")]
        public async Task<IActionResult> Get([FromRoute]GetTravelPlanUserByIdQuery query)
        {
            var resp = await _mediatr.Send(query);
            if (resp == null)
                return NotFound();

            return Ok(resp);
        }


        /// <summary>
        /// Add User Travel Plan
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody]AddUserTravelPlanCommand request)
        {
            var resp = await _mediatr.Send(request);
            return StatusCode(201, resp);
        }

        /// <summary>
        /// Update User Travel Plan
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>

        [HttpPut]
        public async Task<IActionResult> Put([FromBody]UpdateUserTravelPlanCommand request)
        {
            return Ok(await _mediatr.Send(request));
        }
    }
}