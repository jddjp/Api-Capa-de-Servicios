using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api_Capa_de_Servicios.Controllers
{
    [Route("WSTickets/[controller]")]
    // [Route("api/[controller]")]
    [ApiController]
    public class TicketsController : ControllerBase
    {
        /// <summary>
        /// Obtiene una lista de Personas 
        /// </summary>
        /// <remarks>
        /// Buscar personas que cumplan con los parametros de entrada 
        /// </remarks>
        /// <response code="200">OK. Devuelve el objeto solicitado.</response>
        /// <response code="501">Error Verificar Informacion de Entrada</response>  
        [HttpPost("GetTickets")]
        public IActionResult Get()
        {
            return Ok();
        }

    }
}
