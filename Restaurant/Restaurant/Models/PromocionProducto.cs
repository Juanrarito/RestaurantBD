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
    
    public partial class PromocionProducto
    {
        public int ID { get; set; }
        public int ProductoID { get; set; }
        public int PromocionID { get; set; }
        public bool estado { get; set; }
    
        public virtual Producto Producto { get; set; }
        public virtual Promociones Promociones { get; set; }
    }
}
