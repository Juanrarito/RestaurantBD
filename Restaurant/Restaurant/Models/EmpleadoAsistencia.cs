//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Restaurant.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class EmpleadoAsistencia
    {
        public int ID { get; set; }
        public int EmpleadoID { get; set; }
        public int AsistenciaID { get; set; }
        public bool estatus { get; set; }
        public System.DateTime fecha_creacion { get; set; }
    
        public virtual Asistencia Asistencia { get; set; }
        public virtual Empleado Empleado { get; set; }
    }
}
