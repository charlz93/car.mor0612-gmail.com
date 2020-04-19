using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using data = TiendaOnline.DAL.EF;
using ent = TiendaOnline.DO;
using dal = TiendaOnline.DAL;
using TiendaOnline.DO.Objects;

namespace TiendaOnline.BS
{
    public class Factura_cab : ent.Interfaces.ICRUD<ent.Objects.Factura_cab>
    {
        public void Delete(ent.Objects.Factura_cab t)
        {
            var _ent = Mapper.Map<ent.Objects.Factura_cab, data.Factura_cab>(t);
            new dal.Factura_cab().Delete(_ent);
        }

        public IEnumerable<ent.Objects.Factura_cab> GetAll()
        {
            var DetailsQuery = new dal.Factura_cab().GetAll();
            var res = Mapper.Map<IEnumerable<data.Factura_cab>, IEnumerable<ent.Objects.Factura_cab>>(DetailsQuery);
            return res;
        }

        public ent.Objects.Factura_cab GetOneById(int id)
        {
            var DetailsQuery = new dal.Factura_cab().GetOneById(id);
            var res = Mapper.Map<data.Factura_cab, ent.Objects.Factura_cab>(DetailsQuery);
            return res;
        }

        public void Insert(ent.Objects.Factura_cab t)
        {
            var _ent = Mapper.Map<ent.Objects.Factura_cab, data.Factura_cab>(t);
            new dal.Factura_cab().Insert(_ent);
        }

        public void Updated(ent.Objects.Factura_cab t)
        {
            var _ent = Mapper.Map<ent.Objects.Factura_cab, data.Factura_cab>(t);
            new dal.Factura_cab().Updated(_ent);
        }
    }
}
