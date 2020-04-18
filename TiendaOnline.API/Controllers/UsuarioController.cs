using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ent = TiendaOnline.DO.Objects;

namespace TiendaOnline.API.Controllers
{
    [Route("api/Usuario")]
    public class UsuarioController : ApiController
    {
        [Route("api/Usuario/GetAll/")]
        [HttpGet]
        public IEnumerable<ent.Categoria> GetAll()
        {
            return new TiendaOnline.BS.Categoria().GetAll();
        }

        [Route("api/Usuario/GetOneById/5")]
        [HttpGet]
        public ent.Categoria GetOneById(int id)
        {
            return new TiendaOnline.BS.Categoria().GetOneById(id);
        }

        [Route("api/Usuario/Delete")]
        [HttpPost]
        public void Delete(ent.Categoria t)
        {
            new TiendaOnline.BS.Categoria().Delete(t);
        }

        [Route("api/Usuario/Updated")]
        [HttpPost]
        public void Updated(ent.Categoria t)
        {
            new TiendaOnline.BS.Categoria().Updated(t);
        }

        [Route("api/Usuario/Insert")]
        [HttpPost]
        public void Insert(ent.Categoria t)
        {
            new TiendaOnline.BS.Categoria().Insert(t);
        }
    }
}
