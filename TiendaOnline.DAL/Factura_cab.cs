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
    public class Factura_cab : ICRUD<data.Factura_cab>
    {
        private Repository.Repository<data.Factura_cab> _repository = new Repository.Repository<data.Factura_cab>(new BDCARROONLINEEntities());
        public void Delete(data.Factura_cab t)
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

        public IEnumerable<data.Factura_cab> GetAll()
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

        public data.Factura_cab GetOneById(int id)
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

        public void Insert(data.Factura_cab t)
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

        public void Updated(data.Factura_cab t)
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
