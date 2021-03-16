using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api_Capa_de_Servicios.Models.InputData.Solicitud
{
    public class DatosPersonalesPersona
    {
        public int Id_Persona { get; set; }
        public string Cod_Tipo_Persona { get; set; }
        public string Primer_Nombre { get; set; }
        public string Segundo_Nombre { get; set; }
        public string Primer_Paterno { get; set; }
        public string Segundo_Apellido { get; set; }
        public DateTime? Fecha_Nacimiento { get; set; }
        public string Lugar_Nacimiento { get; set; }
        public int cod_Pais_Origen { get; set; }
        public int Cod_Pais_Nacimiento { get; set; }
        public string Cod_Nivel_Estudios { get; set; }
        public string Curp { get; set; }
        public string Rfc { get; set; }
        public string Cod_Genero { get; set; }
        public string Cod_Edo_Civil { get; set; }
        public string Cod_Edo_Ocupacion { get; set; }
        public string Cod_Sit_Economica { get; set; }
        public int Dep_Economicos { get; set; }
        public DateTime? Fecha_Defuncion { get; set; }
        public int Id_Suc_Reqistro { get; set; }
        public DateTime? Fecha_Alta { get; set; }
        public DateTime? Fecha_Modificacion { get; set; }
        public DateTime? Fecha_Residencia { get; set; }
        public string Cod_Situacion_Domicilio { get; set; }
        public string Alias { get; set; }
        public string Cod_Tipo_Ident_Pref { get; set; }
        public string Folio_Identificacion { get; set; }
        public string Cod_ECV_Persona { get; set; }
        public int IdNacionalidad { get; set; }
    }
}
