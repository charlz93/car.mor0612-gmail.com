using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ent = TiendaOnline.DO.Objects;

namespace TiendaOnline.API.Controllers
{
    [Route("api/Categorias")]
    public class CategoriasController : ApiController
    {
        [Route("api/Categorias/GetAll/")]
        [HttpGet]
        public IEnumerable<ent.Categoria> GetAll()
        {
            return new TiendaOnline.BS.Categoria().GetAll();
        }

        [Route("api/Categorias/GetOneById/5")]
        [HttpGet]
        public ent.Categoria GetOneById(int id)
        {
            return new TiendaOnline.BS.Categoria().GetOneById(id);
        }

        [Route("api/Categorias/Delete")]
        [HttpPost]
        public void Delete(ent.Categoria t)
        {
            new TiendaOnline.BS.Categoria().Delete(t);
        }

        [Route("api/Categorias/Updated")]
        [HttpPost]
        public void Updated(ent.Categoria t)
        {
            new TiendaOnline.BS.Categoria().Updated(t);
        }

        [Route("api/Categorias/Insert")]
        [HttpPost]
        public void Insert(ent.Categoria t)
        {
            new TiendaOnline.BS.Categoria().Insert(t);
        }
    }
}
