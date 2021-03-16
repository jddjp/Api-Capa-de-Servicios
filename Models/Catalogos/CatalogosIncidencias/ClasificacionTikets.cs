using System;
using System.Collections.Generic;

namespace Originacion.Models.Catalogos.CatalogosIncidencias
{
    public partial class ClasificacionTikets
    {
        public int CodClasificacionTicket { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string MensajeAtencion { get; set; }
    }
}
