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
    
    public partial class Ventas_log
    {
        public int ID { get; set; }
        public int DetalleVentaID { get; set; }
        public int ClienteID { get; set; }
        public int EmpleadoID { get; set; }
        public System.DateTime fecha { get; set; }
        public System.DateTime fecha_modificacion { get; set; }
    
        public virtual Cliente Cliente { get; set; }
        public virtual Empleado Empleado { get; set; }
    }
}
