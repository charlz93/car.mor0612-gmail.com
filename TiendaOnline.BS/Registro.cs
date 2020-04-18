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
    public class Registro : ent.Interfaces.ICRUD<ent.Objects.Registro>
    {
        public void Delete(ent.Objects.Registro t)
        {
            var _ent = Mapper.Map<ent.Objects.Registro, data.Registro>(t);
            new dal.Registro().Delete(_ent);
        }

        public IEnumerable<ent.Objects.Registro> GetAll()
        {
            var DetailsQuery = new dal.Registro().GetAll();
            var res = Mapper.Map<IEnumerable<data.Registro>, IEnumerable<ent.Objects.Registro>>(DetailsQuery);
            return res;
        }

        public ent.Objects.Registro GetOneById(int id)
        {
            var DetailsQuery = new dal.Registro().GetOneById(id);
            var res = Mapper.Map<data.Registro, ent.Objects.Registro>(DetailsQuery);
            return res;
        }

        public void Insert(ent.Objects.Registro t)
        {
            var _ent = Mapper.Map<ent.Objects.Registro, data.Registro>(t);
            new dal.Registro().Insert(_ent);
        }

        public void Updated(ent.Objects.Registro t)
        {
            var _ent = Mapper.Map<ent.Objects.Registro, data.Registro>(t);
            new dal.Registro().Updated(_ent);
        }
    }
}
