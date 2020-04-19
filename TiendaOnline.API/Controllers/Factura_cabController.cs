using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ent = TiendaOnline.DO.Objects;

namespace TiendaOnline.API.Controllers
{
    [Route("api/Factura_cab")]
    public class Factura_cabController : ApiController
    {
        [Route("api/Factura_cab/GetAll/")]
        [HttpGet]
        public IEnumerable<ent.Factura_cab> GetAll()
        {
            return new TiendaOnline.BS.Factura_cab().GetAll();
        }

        [Route("api/Factura_cab/GetOneById/5")]
        [HttpGet]
        public ent.Factura_cab GetOneById(int id)
        {
            return new TiendaOnline.BS.Factura_cab().GetOneById(id);
        }

        [Route("api/Factura_cab/Delete")]
        [HttpPost]
        public void Delete(ent.Factura_cab t)
        {
            new TiendaOnline.BS.Factura_cab().Delete(t);
        }

        [Route("api/Factura_cab/Updated")]
        [HttpPost]
        public void Updated(ent.Factura_cab t)
        {
            new TiendaOnline.BS.Factura_cab().Updated(t);
        }

        [Route("api/Factura_cab/Insert")]
        [HttpPost]
        public void Insert(ent.Factura_cab t)
        {
            new TiendaOnline.BS.Factura_cab().Insert(t);
        }
    }
}
