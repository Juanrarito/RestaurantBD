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
    
    public partial class Propina
    {
        public int ID { get; set; }
        public int MesaID { get; set; }
        public System.DateTime Fecha { get; set; }
        public decimal Cantidad { get; set; }
    
        public virtual Mesa Mesa { get; set; }
    }
}