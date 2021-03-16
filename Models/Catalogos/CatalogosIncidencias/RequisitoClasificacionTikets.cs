using System;
using System.Collections.Generic;

namespace Originacion.Models.Catalogos.CatalogosIncidencias
{
    public partial class RequisitoClasificacionTikets
    {
        public int IdRequisitoClasificTicket { get; set; }
        public string CodRequisito { get; set; }
        public int CodClasificacionTicket { get; set; }
        public bool IndActivo { get; set; }
    }
}
