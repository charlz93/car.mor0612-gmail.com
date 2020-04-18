using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaOnline.DO.Objects
{
    public class Estado
    {
        public int Id_estado { get; set; }
        public string Nombre_estado { get; set; }
        public virtual ICollection<Factura> Facturas { get; set; }
        public virtual ICollection<Producto> Productos { get; set; }
    }
}
