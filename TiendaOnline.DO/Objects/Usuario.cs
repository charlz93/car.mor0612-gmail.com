using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaOnline.DO.Objects
{
    public class Usuario
    {
        public int Id_usuario { get; set; }
        public string codigo { get; set; }
        public string clave { get; set; }
        public Nullable<int> Id_registro { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Factura> Facturas { get; set; }
        public virtual Registro Registro { get; set; }
    }
}
