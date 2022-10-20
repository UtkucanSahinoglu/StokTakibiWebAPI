using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using System;

namespace StokTakibiWebAPI.Repository.Interface
{
    public interface IGenericRepository <T> where T : class
    {
        Task<IEnumerable<T>> GetAll();
        void Add(T entity);
        void Update(T entity);
        //Task<T> GetById(Guid Id);
        //T Get(Expression<Func<T, bool>> filter);
        //void Delete(T entity);
        //Task<T> DeleteById(T entity);
    }
}
