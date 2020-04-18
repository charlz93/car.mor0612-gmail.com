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
    public class Categoria : ent.Interfaces.ICRUD<ent.Objects.Categoria>
    {
        public void Delete(ent.Objects.Categoria t)
        {
            var _ent = Mapper.Map<ent.Objects.Categoria, data.Categoria>(t);
            new dal.Categoria().Delete(_ent);
        }

        public IEnumerable<ent.Objects.Categoria> GetAll()
        {
            var DetailsQuery = new dal.Categoria().GetAll();
            var res = Mapper.Map<IEnumerable<data.Categoria>, IEnumerable<ent.Objects.Categoria>>(DetailsQuery);
            return res;
        }

        public ent.Objects.Categoria GetOneById(int id)
        {
            var DetailsQuery = new dal.Categoria().GetOneById(id);
            var res = Mapper.Map<data.Categoria, ent.Objects.Categoria>(DetailsQuery);
            return res;
        }

        public void Insert(ent.Objects.Categoria t)
        {
            var _ent = Mapper.Map<ent.Objects.Categoria, data.Categoria>(t);
            new dal.Categoria().Insert(_ent);
        }

        public void Updated(ent.Objects.Categoria t)
        {
            var _ent = Mapper.Map<ent.Objects.Categoria, data.Categoria>(t);
            new dal.Categoria().Updated(_ent);
        }
    }
}
