using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace Originacion.Models.Cotizacion
{
    public class Ofertas
    {
		public int? IdCotizacion { get; set; }
		public int? IdOferta { get; set; }
		public string? IdProductoComercial { get; set; }
		public string? IdTarifa { get; set; }
		public double? Importe { get; set; }
		public int? Plazo { get; set; }
		public string? Cod_UDM_Plazo { get; set; }
		public double? TasaIntOrd { get; set; }
		public DateTime? Fecha_Inicio { get; set; }
		public DateTime? Fecha_Prim_Liq { get; set; }
		public double? Cuota_Periodo { get; set; }
		public double? Imp_Comision { get; set; }
		public double? Iva_Comision { get; set; }
		public double? Imp_Seguro { get; set; }
		public double? Iva_Seguro { get; set; }
		public double? Imp_Dev_Gracia { get; set; }
		public double? Iva_Int_Gracia { get; set; }
		public double? Cuota_Total { get; set; }
		public double? Capacidad_Pago { get; set; }
		public double? Capacidad_Descuento { get; set; }
		public int? Ind_Suficiencia { get; set; }
		public int? Ind_Cap_Descuento { get; set; }
		public int? Ind_Original { get; set; }
		public int? Ind_Seleccion { get; set; }
		public string? Cod_Tipo_Oferta { get; set; }
		public double? Cat { get; set; }
		public DateTime? Fecha_Vento { get; set; }
		public string? Fondeo { get; set; } 
		public string? Porc_Cap_Pago_Aplicada { get; set; }
		public string? NombrePlazo { get; set; }

	}
}
