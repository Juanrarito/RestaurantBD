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
    
    public partial class Venta
    {
        public int ID { get; set; }
        public int PedidoID { get; set; }
        public int Total { get; set; }
        public System.DateTime Fecha { get; set; }
        public int EmpleadoID { get; set; }
    
        public virtual Empleado Empleado { get; set; }
        public virtual Pedido Pedido { get; set; }
    }
}