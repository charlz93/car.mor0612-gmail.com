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
        public IEnumerable<ent.Registro> GetAll()
        {
            return new TiendaOnline.BS.Registro().GetAll();
        }

        [Route("api/Registro/GetOneById/5")]
        [HttpGet]
        public ent.Registro GetOneById(int id)
        {
            return new TiendaOnline.BS.Registro().GetOneById(id);
        }

        [Route("api/Registro/Delete")]
        [HttpPost]
        public void Delete(ent.Registro t)
        {
            new TiendaOnline.BS.Registro().Delete(t);
        }

        [Route("api/Registro/Updated")]
        [HttpPost]
        public void Updated(ent.Registro t)
        {
            new TiendaOnline.BS.Registro().Updated(t);
        }

        [Route("api/Registro/Insert")]
        [HttpPost]
        public void Insert(ent.Registro t)
        {
            new TiendaOnline.BS.Registro().Insert(t);
        }
    }
}
