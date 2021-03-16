using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api_Capa_de_Servicios.Models.InputData.Solicitud
{
    public class CargaDocumento
    {
        public DateTime Fecha_Emision { get; set; }
        public DateTime Fecha_Vigencia { get; set; }
        //TipoExpediente
        //public int TipoExpediente { get; set; }
        //ClaveExpediente 
        //public int TipocSubExpediente { get; set; }
        //IdentificadorExpediente
        public string IdExpediente { get; set; }
        //Pedir Credenciales Cliente
        public string CredencialesCliente { get; set; }

        //DocumentoFisico
        public string DocumentoBase64 { get; set; }
        //public int Tipo_Documento { get; set; }
        //Agregamos el tipo de SubSub expediente si
        //es un documento que viene de la Api de Generacion de Documentos
        //public int TipocSubSubExpediente { get; set; }
    }
}
