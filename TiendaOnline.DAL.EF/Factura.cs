//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TiendaOnline.DAL.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class Factura
    {
        public int Id_factura { get; set; }
        public Nullable<int> Id_producto { get; set; }
        public Nullable<decimal> Precio { get; set; }
        public Nullable<int> Cantidad { get; set; }
        public Nullable<decimal> Total { get; set; }
        public Nullable<int> Id_estado { get; set; }
        public Nullable<int> Id_usuario { get; set; }
        public Nullable<int> Procesado { get; set; }
    
        public virtual Estado Estado { get; set; }
        public virtual Producto Producto { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}
