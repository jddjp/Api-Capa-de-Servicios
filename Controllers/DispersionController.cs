using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api_Capa_de_Servicios.Controllers
{
    [Route("WSDispersion/[controller]")]
    [ApiController]
    public class DispersionController : ControllerBase
    {

        /// <summary>
        /// Obtiene una lista de Personas 
        /// </summary>
        /// <remarks>
        /// Buscar personas que cumplan con los parametros de entrada 
        /// </remarks>
        /// <response code="200">OK. Devuelve el objeto solicitado.</response>
        /// <response code="501">Error Verificar Informacion de Entrada</response>  
        [HttpGet("GetTransferenciaBancaria")]
        public IActionResult Get()
        {
            return Ok();
        }

        [HttpPost("GetRererencia")]
        public IActionResult Get1()
        {
            return Ok();
        }

    }
}
