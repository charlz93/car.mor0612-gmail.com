using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaOnline.DO.Objects
{
    public class Factura
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
