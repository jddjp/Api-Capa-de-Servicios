using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Originacion.Models.Catalogos
{
    public partial class ProductoComercial
    {
        public string IdProductoComercial { get; set; }
        public string CodProductoC { get; set; }
        public string Nombre { get; set; }
        public string NomCorto { get; set; }
        public DateTime? FechaInicio { get; set; }
        public DateTime? FechaFinal { get; set; }
        public string CodEcvProducto { get; set; }
    }
}
