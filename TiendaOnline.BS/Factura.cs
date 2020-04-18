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
    public class Factura : ent.Interfaces.ICRUD<ent.Objects.Factura>
    {
        public void Delete(ent.Objects.Factura t)
        {
            var _ent = Mapper.Map<ent.Objects.Factura, data.Factura>(t);
            new dal.Factura().Delete(_ent);
        }

        public IEnumerable<ent.Objects.Factura> GetAll()
        {
            var DetailsQuery = new dal.Factura().GetAll();
            var res = Mapper.Map<IEnumerable<data.Factura>, IEnumerable<ent.Objects.Factura>>(DetailsQuery);
            return res;
        }

        public ent.Objects.Factura GetOneById(int id)
        {
            var DetailsQuery = new dal.Factura().GetOneById(id);
            var res = Mapper.Map<data.Factura, ent.Objects.Factura>(DetailsQuery);
            return res;
        }

        public void Insert(ent.Objects.Factura t)
        {
            var _ent = Mapper.Map<ent.Objects.Factura, data.Factura>(t);
            new dal.Factura().Insert(_ent);
        }

        public void Updated(ent.Objects.Factura t)
        {
            var _ent = Mapper.Map<ent.Objects.Factura, data.Factura>(t);
            new dal.Factura().Updated(_ent);
        }
    }
}
