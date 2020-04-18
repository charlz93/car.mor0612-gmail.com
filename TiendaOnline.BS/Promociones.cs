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
    public class Promociones : ent.Interfaces.ICRUD<ent.Objects.Promociones>
    {
        public void Delete(ent.Objects.Promociones t)
        {
            var _ent = Mapper.Map<ent.Objects.Promociones, data.Promocione>(t);
            new dal.Promociones().Delete(_ent);
        }

        public IEnumerable<ent.Objects.Promociones> GetAll()
        {
            var DetailsQuery = new dal.Promociones().GetAll();
            var res = Mapper.Map<IEnumerable<data.Promocione>, IEnumerable<ent.Objects.Promociones>>(DetailsQuery);
            return res;
        }

        public ent.Objects.Promociones GetOneById(int id)
        {
            var DetailsQuery = new dal.Promociones().GetOneById(id);
            var res = Mapper.Map<data.Promocione, ent.Objects.Promociones>(DetailsQuery);
            return res;
        }

        public void Insert(ent.Objects.Promociones t)
        {
            var _ent = Mapper.Map<ent.Objects.Promociones, data.Promocione>(t);
            new dal.Promociones().Insert(_ent);
        }

        public void Updated(ent.Objects.Promociones t)
        {
            var _ent = Mapper.Map<ent.Objects.Promociones, data.Promocione>(t);
            new dal.Promociones().Updated(_ent);
        }
    }
}
