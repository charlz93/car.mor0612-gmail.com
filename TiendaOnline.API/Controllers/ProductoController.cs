using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ent = TiendaOnline.DO.Objects;

namespace TiendaOnline.API.Controllers
{
    [Route("api/Producto")]
    public class ProductoController : ApiController
    {
        [Route("api/Producto/GetAll/")]
        [HttpGet]
        public IEnumerable<ent.Producto> GetAll()
        {
            return new TiendaOnline.BS.Producto().GetAll();
        }

        [Route("api/Producto/GetOneById/5")]
        [HttpGet]
        public ent.Producto GetOneById(int id)
        {
            return new TiendaOnline.BS.Producto().GetOneById(id);
        }

        [Route("api/Producto/Delete")]
        [HttpPost]
        public void Delete(ent.Producto t)
        {
            new TiendaOnline.BS.Producto().Delete(t);
        }

        [Route("api/Producto/Updated")]
        [HttpPost]
        public void Updated(ent.Producto t)
        {
            new TiendaOnline.BS.Producto().Updated(t);
        }

        [Route("api/Producto/Insert")]
        [HttpPost]
        public void Insert(ent.Producto t)
        {
            new TiendaOnline.BS.Producto().Insert(t);
        }
    }
}
