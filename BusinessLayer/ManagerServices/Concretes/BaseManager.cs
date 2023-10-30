using BusinessLayer.ManagerServices.Abstracts;
using DataAccessLayer.Repositories.Abstracts;
using EntityLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ManagerServices.Concretes
{
    public class BaseManager<T> : IManager<T> where T : class, IEntity
    {
        protected IRepository<T> _iRepository;
        public BaseManager(IRepository<T> iRepository)
        {
            _iRepository = iRepository;
        }

        public void TAdd(T entity)
        {
            throw new NotImplementedException();
        }

        public void TDelete(T entity)
        {
            throw new NotImplementedException();
        }

        public T TFirstOrDefault(Expression<Func<T, bool>> expression)
        {
            return _iRepository.FirstOrDefault(expression);
        }

        public List<T> TGetAll()
        {
            throw new NotImplementedException();
        }

        public List<T> TGetAll(Expression<Func<T, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public T TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(T entity)
        {
            _iRepository.Update(entity);
        }
    }
}
