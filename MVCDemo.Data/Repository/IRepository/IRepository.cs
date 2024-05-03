using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCDemo.Data.Repository.IRepository
{
    public interface IRepository<TEntity> where TEntity : class
    {
        IEnumerable<TEntity> GetAll(string includeProperties = null);
        TEntity GetById(int id);
        void Insert(TEntity entity);
        void Save();
        void Update(TEntity entity);
        void Delete(TEntity entity);
    }
}
