using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ent = TiendaOnline.DO.Objects;

namespace TiendaOnline.API.Controllers
{
    [Route("api/Factura_lin")]
    public class Factura_linController : ApiController
    {
        [Route("api/Factura_lin/GetAll/")]
        [HttpGet]
        public IEnumerable<ent.Factura_lin> GetAll()
        {
            return new TiendaOnline.BS.Factura_lin().GetAll();
        }

        [Route("api/Factura_lin/GetOneById/5")]
        [HttpGet]
        public ent.Factura_lin GetOneById(int id)
        {
            return new TiendaOnline.BS.Factura_lin().GetOneById(id);
        }

        [Route("api/Factura_lin/Delete")]
        [HttpPost]
        public void Delete(ent.Factura_lin t)
        {
            new TiendaOnline.BS.Factura_lin().Delete(t);
        }

        [Route("api/Factura_lin/Updated")]
        [HttpPost]
        public void Updated(ent.Factura_lin t)
        {
            new TiendaOnline.BS.Factura_lin().Updated(t);
        }

        [Route("api/Factura_lin/Insert")]
        [HttpPost]
        public void Insert(ent.Factura_lin t)
        {
            new TiendaOnline.BS.Factura_lin().Insert(t);
        }
    }
}
