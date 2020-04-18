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
    public class Estado : ent.Interfaces.ICRUD<ent.Objects.Estado>
    {
        public void Delete(ent.Objects.Estado t)
        {
            var _ent = Mapper.Map<ent.Objects.Estado, data.Estado>(t);
            new dal.Estado().Delete(_ent);
        }

        public IEnumerable<ent.Objects.Estado> GetAll()
        {
            var DetailsQuery = new dal.Estado().GetAll();
            var res = Mapper.Map<IEnumerable<data.Estado>, IEnumerable<ent.Objects.Estado>>(DetailsQuery);
            return res;
        }

        public ent.Objects.Estado GetOneById(int id)
        {
            var DetailsQuery = new dal.Estado().GetOneById(id);
            var res = Mapper.Map<data.Estado, ent.Objects.Estado>(DetailsQuery);
            return res;
        }

        public void Insert(ent.Objects.Estado t)
        {
            var _ent = Mapper.Map<ent.Objects.Estado, data.Estado>(t);
            new dal.Estado().Insert(_ent);
        }

        public void Updated(ent.Objects.Estado t)
        {
            var _ent = Mapper.Map<ent.Objects.Estado, data.Estado>(t);
            new dal.Estado().Updated(_ent);
        }
    }
}
