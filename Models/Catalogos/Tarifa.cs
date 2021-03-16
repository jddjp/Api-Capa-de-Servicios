using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Originacion.Models.Catalogos
{
    public class Tarifa
    {
        public string IdTarifa { get; set; }
        public string Nombre { get; set; }
        public string CodEcvTarifa { get; set; }
        public DateTime? FechaAlta { get; set; }
        public int? PlazoMin { get; set; }
        public int? PlazoMax { get; set; }
        public int? PlazoPefer { get; set; }
        public int? DiasGracia { get; set; }
        public decimal? ImporteMin { get; set; }
        public decimal? ImporteMax { get; set; }
        public string IndAmorzPrimLiq { get; set; }
        public string CodBaseCalculo { get; set; }
        public string CodCompDias { get; set; }
        public decimal? TasaIntOrd { get; set; }
        public string CodBaseIntOrd { get; set; }
        public decimal? TasaIntMora { get; set; }
        public string CodBaseIntMora { get; set; }
        public int? DiasGraciaMora { get; set; }
        public decimal? PorcIva { get; set; }

    }
}
