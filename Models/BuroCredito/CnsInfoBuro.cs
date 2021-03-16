using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Originacion.Models.Catalogos.BuroCredito
{

    public class CnsInfoBuro
    {
        public List<CnsBcNombre> CnsBcNombre { get; set; }
        public List<CnsBcCuenta> CnsBcCuenta { get; set; }
        public List<CnsBcScoreBc> CnsBcScoreBc { get; set; }
        public List<CnsBcResumenReporte> CnsBcResumenReporte { get; set; }
        public List<LineaFondeo> ListaLineasFondeo { get; set; }
    }



}
