using AdessoRideShare.WebApi.Application.Query;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace AdessoRideShare.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TravelPlansController : ControllerBase
    {
        private readonly IMediator _mediatr;
        public TravelPlansController(IMediator mediatr)
        {
            _mediatr = mediatr;
        }

        /// <summary>
        /// Get All Active Travel Plans
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> Get([FromQuery]GetTravelPlanQuery query)
        {
            var resp = await _mediatr.Send(query);
            if (resp == null)
                return NotFound();

            return Ok(resp);
        }
    }
}