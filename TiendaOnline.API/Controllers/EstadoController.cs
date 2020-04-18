using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ent = TiendaOnline.DO.Objects;

namespace TiendaOnline.API.Controllers
{
    [Route("api/Estado")]
    public class EstadoController : ApiController
    {
        [Route("api/Estado/GetAll/")]
        [HttpGet]
        public IEnumerable<ent.Estado> GetAll()
        {
            return new TiendaOnline.BS.Estado().GetAll();
        }

        [Route("api/Estado/GetOneById/5")]
        [HttpGet]
        public ent.Estado GetOneById(int id)
        {
            return new TiendaOnline.BS.Estado().GetOneById(id);
        }

        [Route("api/Estado/Delete")]
        [HttpPost]
        public void Delete(ent.Estado t)
        {
            new TiendaOnline.BS.Estado().Delete(t);
        }

        [Route("api/Estado/Updated")]
        [HttpPost]
        public void Updated(ent.Estado t)
        {
            new TiendaOnline.BS.Estado().Updated(t);
        }

        [Route("api/Estado/Insert")]
        [HttpPost]
        public void Insert(ent.Estado t)
        {
            new TiendaOnline.BS.Estado().Insert(t);
        }
    }
}
