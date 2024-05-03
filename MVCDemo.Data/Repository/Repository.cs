using Microsoft.EntityFrameworkCore;
using MVCDemo.Data.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace MVCDemo.Data.Repository
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private AppDbContext _dbContext { get; set; }
        public Repository(AppDbContext context)
        {
            _dbContext = context;
        }
        public IEnumerable<TEntity> GetAll(string includeProperties = null)
        {
            IQueryable<TEntity> query = _dbContext.Set<TEntity>();
            if (includeProperties != null)
            {
                foreach (var includeProperty in includeProperties.Split(
                new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(includeProperty);
                }
            }
            return query.ToList();
        }

        public TEntity GetById(int id)
        {
            return _dbContext.Set<TEntity>().Find(id);
        }

        public void Insert(TEntity entity)
        {
             _dbContext.Set<TEntity>().Add(entity);
        }
        public void Update(TEntity entity)
        {
            _dbContext.Set<TEntity>().Update(entity);
        }
        public void Delete(TEntity entity)
        {
            _dbContext.Set<TEntity>().Remove(entity);
        }
        public void Save()
        {
            _dbContext.SaveChanges();
        }
    }
}
