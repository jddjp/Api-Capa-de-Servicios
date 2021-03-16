using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Originacion.Models.Cotizacion
{
    public class ExtraeOfertas
    {
		public int IdCotizacion { get; set; }
		public string IdProductoComercial { get; set; }

		public string IdTarifa { get; set; }
		public double Importe { get; set; }
		public int Num_Cuotas { get; set; }
		public string Cod_UDM { get; set; }
		public double Tasa_Int_Mes { get; set; }
		public double Factor_Iva { get; set; }
		public DateTime Fecha_Inicio { get; set; }
		public DateTime Fecha_Prim_Liq { get; set; }
		public double Capacidad_Pago { get; set; }
		public double Capacidad_Descuento { get; set; }
		public int Ind_Oferta_Plazo { get; set; }
		public int Ind_Oferta_Monto { get; set; }
		public double Importe_Max { get; set; }
		public DateTime Fecha_Limite { get; set; }
		public int Num_Cuotas_Max { get; set; }
	}
}
