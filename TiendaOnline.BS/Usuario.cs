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
    public class Usuario : ent.Interfaces.ICRUD<ent.Objects.Usuario>
    {
        public void Delete(ent.Objects.Usuario t)
        {
            var _ent = Mapper.Map<ent.Objects.Usuario, data.Usuario>(t);
            new dal.Usuario().Delete(_ent);
        }

        public IEnumerable<ent.Objects.Usuario> GetAll()
        {
            var DetailsQuery = new dal.Usuario().GetAll();
            var res = Mapper.Map<IEnumerable<data.Usuario>, IEnumerable<ent.Objects.Usuario>>(DetailsQuery);
            return res;
        }

        public ent.Objects.Usuario GetOneById(int id)
        {
            var DetailsQuery = new dal.Usuario().GetOneById(id);
            var res = Mapper.Map<data.Usuario, ent.Objects.Usuario>(DetailsQuery);
            return res;
        }

        public void Insert(ent.Objects.Usuario t)
        {
            var _ent = Mapper.Map<ent.Objects.Usuario, data.Usuario>(t);
            new dal.Usuario().Insert(_ent);
        }

        public void Updated(ent.Objects.Usuario t)
        {
            var _ent = Mapper.Map<ent.Objects.Usuario, data.Usuario>(t);
            new dal.Usuario().Updated(_ent);
        }
    }
}
