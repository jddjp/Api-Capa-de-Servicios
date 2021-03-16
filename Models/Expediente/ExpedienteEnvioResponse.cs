using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Originacion.Models.Expediente
{
    public class ExpedienteEnvioResponse
    {
        public string? id { get; set; }
        public string? clave_Origen { get; set; }
        public string fecha_Emision { get; set; }
        public string fecha_Vigencia { get; set; }
        public string tipo_Documento { get; set; }
        public string tipo_Expediente { get; set; }
        public string clave_Expediente { get; set; }
        public string fecha_Registro { get; set; }
        public string url { get; set; }
        public string documento_data { get; set; }

    }
}
