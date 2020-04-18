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
    public class Categoria : ICRUD<data.Categoria>
    {
        private Repository.Repository<data.Categoria> _repository = new Repository.Repository<data.Categoria>(new BDCARROONLINEEntities1());
        public void Delete(data.Categoria t)
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

        public IEnumerable<data.Categoria> GetAll()
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

        public data.Categoria GetOneById(int id)
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

        public void Insert(data.Categoria t)
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

        public void Updated(data.Categoria t)
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
