using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ent = TiendaOnline.DO.Objects;

namespace TiendaOnline.API.Controllers
{
    [Route("api/Promociones")]
    public class PromocionesController : ApiController
    {
        [Route("api/Promociones/GetAll/")]
        [HttpGet]
        public IEnumerable<ent.Promociones> GetAll()
        {
            return new TiendaOnline.BS.Promociones().GetAll();
        }

        [Route("api/Promociones/GetOneById/5")]
        [HttpGet]
        public ent.Promociones GetOneById(int id)
        {
            return new TiendaOnline.BS.Promociones().GetOneById(id);
        }

        [Route("api/Promociones/Delete")]
        [HttpPost]
        public void Delete(ent.Promociones t)
        {
            new TiendaOnline.BS.Promociones().Delete(t);
        }

        [Route("api/Promociones/Updated")]
        [HttpPost]
        public void Updated(ent.Promociones t)
        {
            new TiendaOnline.BS.Promociones().Updated(t);
        }

        [Route("api/Promociones/Insert")]
        [HttpPost]
        public void Insert(ent.Promociones t)
        {
            new TiendaOnline.BS.Promociones().Insert(t);
        }
    }
}
