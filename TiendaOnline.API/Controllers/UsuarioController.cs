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
        public IEnumerable<ent.Usuario> GetAll()
        {
            return new TiendaOnline.BS.Usuario().GetAll();
        }

        [Route("api/Usuario/GetOneById/5")]
        [HttpGet]
        public ent.Usuario GetOneById(int id)
        {
            return new TiendaOnline.BS.Usuario().GetOneById(id);
        }

        [Route("api/Usuario/Delete")]
        [HttpPost]
        public void Delete(ent.Usuario t)
        {
            new TiendaOnline.BS.Usuario().Delete(t);
        }

        [Route("api/Usuario/Updated")]
        [HttpPost]
        public void Updated(ent.Usuario t)
        {
            new TiendaOnline.BS.Usuario().Updated(t);
        }

        [Route("api/Usuario/Insert")]
        [HttpPost]
        public void Insert(ent.Usuario t)
        {
            new TiendaOnline.BS.Usuario().Insert(t);
        }
    }
}
