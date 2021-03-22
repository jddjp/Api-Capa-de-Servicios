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
    [Route("WSDispersion/[controller]")]
    [ApiController]
    public class DispersionController : ControllerBase
    {

       

    }
}
