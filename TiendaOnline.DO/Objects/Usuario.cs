﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaOnline.DO.Objects
{
    public class Usuario
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Usuario()
        {
            this.Factura_cab = new HashSet<Factura_cab>();
        }

        public int Id_usuario { get; set; }
        public string codigo { get; set; }
        public string clave { get; set; }
        public Nullable<int> Id_registro { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Factura_cab> Factura_cab { get; set; }
        //public virtual Registro Registro { get; set; }
    }
}
