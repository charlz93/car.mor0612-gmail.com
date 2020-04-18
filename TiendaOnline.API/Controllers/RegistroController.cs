using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ent = TiendaOnline.DO.Objects;

namespace TiendaOnline.API.Controllers
{
    [Route("api/Registro")]
    public class RegistroController : ApiController
    {
        [Route("api/Registro/GetAll/")]
        [HttpGet]
        public IEnumerable<ent.Categoria> GetAll()
        {
            return new TiendaOnline.BS.Categoria().GetAll();
        }

        [Route("api/Registro/GetOneById/5")]
        [HttpGet]
        public ent.Categoria GetOneById(int id)
        {
            return new TiendaOnline.BS.Categoria().GetOneById(id);
        }

        [Route("api/Registro/Delete")]
        [HttpPost]
        public void Delete(ent.Categoria t)
        {
            new TiendaOnline.BS.Categoria().Delete(t);
        }

        [Route("api/Registro/Updated")]
        [HttpPost]
        public void Updated(ent.Categoria t)
        {
            new TiendaOnline.BS.Categoria().Updated(t);
        }

        [Route("api/Registro/Insert")]
        [HttpPost]
        public void Insert(ent.Categoria t)
        {
            new TiendaOnline.BS.Categoria().Insert(t);
        }
    }
}
