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
    public class Factura_lin : ent.Interfaces.ICRUD<ent.Objects.Factura_lin>
    {
        public void Delete(ent.Objects.Factura_lin t)
        {
            var _ent = Mapper.Map<ent.Objects.Factura_lin, data.Factura_lin>(t);
            new dal.Factura_lin().Delete(_ent);
        }

        public IEnumerable<ent.Objects.Factura_lin> GetAll()
        {
            var DetailsQuery = new dal.Factura_lin().GetAll();
            var res = Mapper.Map<IEnumerable<data.Factura_lin>, IEnumerable<ent.Objects.Factura_lin>>(DetailsQuery);
            return res;
        }

        public ent.Objects.Factura_lin GetOneById(int id)
        {
            var DetailsQuery = new dal.Factura_lin().GetOneById(id);
            var res = Mapper.Map<data.Factura_lin, ent.Objects.Factura_lin>(DetailsQuery);
            return res;
        }

        public void Insert(ent.Objects.Factura_lin t)
        {
            var _ent = Mapper.Map<ent.Objects.Factura_lin, data.Factura_lin>(t);
            new dal.Factura_lin().Insert(_ent);
        }

        public void Updated(ent.Objects.Factura_lin t)
        {
            var _ent = Mapper.Map<ent.Objects.Factura_lin, data.Factura_lin>(t);
            new dal.Factura_lin().Updated(_ent);
        }
    }
}
