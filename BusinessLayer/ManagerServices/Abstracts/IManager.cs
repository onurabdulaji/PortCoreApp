using EntityLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ManagerServices.Abstracts
{
    public interface IManager<T> where T : class, IEntity
    {
        // Basic Commands
        void TAdd(T entity);
        void TDelete(T entity);
        void TUpdate(T entity);
        T TGetById(int id);
        List<T> TGetAll();
        List<T> TGetAll(Expression<Func<T, bool>> expression);
        T TFirstOrDefault(Expression<Func<T, bool>> expression);
    }
}
