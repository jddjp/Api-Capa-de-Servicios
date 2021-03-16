using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace Originacion.Models.Expediente
{
    public class ExpedienteEnvioRequest
    {
        public string Fecha_Emision { get; set; }
        public string Fecha_Vigencia { get; set; }
        public int TipoExpediente { get; set; }
        public int TipocSubExpediente { get; set; }
        public string IdExpediente { get; set; }
        public string CredencialesCliente { get; set; }
        public IFormFile Documento { get; set; }
        public int Tipo_Documento { get; set; }

    }
}
