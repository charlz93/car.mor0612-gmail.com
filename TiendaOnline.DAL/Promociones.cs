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
    public class Promociones : ICRUD<data.Promocione>
    {
        private Repository.Repository<data.Promocione> _repository = new Repository.Repository<data.Promocione>(new BDCARROONLINEEntities1());
        public void Delete(data.Promocione t)
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

        public IEnumerable<data.Promocione> GetAll()
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

        public data.Promocione GetOneById(int id)
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

        public void Insert(data.Promocione t)
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

        public void Updated(data.Promocione t)
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
