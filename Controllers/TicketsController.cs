using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api_Capa_de_Servicios.Controllers
{
    [Authorize]
    [Route("WSTickets/[controller]")]
    // [Route("api/[controller]")]
    [ApiController]
    public class TicketsController : ControllerBase
    {
        [HttpGet("GetEstatus")]
        public IActionResult Get3()
        {
            return Ok();
        }


        [HttpPost("PostEstatus")]
        public IActionResult Get4()
        {
            return Ok();
        }

    }
}
