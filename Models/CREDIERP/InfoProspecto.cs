using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Originacion.Models.CREDIERP
{
    public class InfoProspecto
    {
        public int nIdPersona { get; set; }
        public string sNombreCompleto { get; set; }
        public string sPrimerNombre { get; set; }
        public string sSegundoNombre { get; set; }
        public string sApellidoPaterno { get; set; }
        public string sApellidoMaterno { get; set; }
        public string sRFC { get; set; }
        public string sEmail { get; set; }
        public string sFechaNacimiento { get; set; }
        public string sProducto { get; set; }
        public int nIdDisposicion { get; set; }
        public string sClaveDisposicion { get; set; }
        public decimal nMonto { get; set; }
        public decimal nSaldoInsoluto { get; set; }
        public decimal nMontoDispersar { get; set; }
        public System.DateTime dFechaAlta { get; set; }
        public System.DateTime dFechaVencimiento { get; set; }
        public string sNoPagare { get; set; }
        public int nIdProspecto { get; set; }
    }
}
