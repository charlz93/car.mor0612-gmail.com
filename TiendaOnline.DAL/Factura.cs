using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaOnline.DO.Interfaces;
using data = TiendaOnline.DAL.EF;
using TiendaOnline.DAL.EF;

namespace TiendaOnline.DAL
{
    public class Factura : ICRUD<data.Factura>
    {
        private Repository.Repository<data.Factura> _repository = new Repository.Repository<data.Factura>(new BDCARROONLINEEntities1());
        public void Delete(data.Factura t)
        {
            try
            {
                _repository.Delete(t);
                _repository.Commit();
            }
            catch (Exception ee)
            {
                throw;
            }
        }

        public IEnumerable<data.Factura> GetAll()
        {
            try
            {
                return _repository.GetAll();
            }
            catch (Exception ee)
            {

                throw;
            }
        }

        public data.Factura GetOneById(int id)
        {
            try
            {
                return _repository.GetOneByID(id);
            }
            catch (Exception ee)
            {

                throw;
            }
        }

        public void Insert(data.Factura t)
        {
            try
            {
                _repository.Insert(t);
                _repository.Commit();
            }
            catch (Exception ee)
            {

                throw;
            }
        }

        public void Updated(data.Factura t)
        {
            try
            {
                _repository.Updated(t);
                _repository.Commit();
            }
            catch (Exception ee)
            {

                throw;
            }
        }
    }
}
