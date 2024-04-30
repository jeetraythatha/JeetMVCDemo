﻿using Microsoft.EntityFrameworkCore;
using MVCDemo.Data.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace MVCDemo.Data.Repository
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private AppDbContext _dbContext { get; set; }
        public Repository(AppDbContext context)
        {
            _dbContext = context;
        }
        public IEnumerable<TEntity> GetAll()
        {
            return _dbContext.Set<TEntity>().ToList();
        }

        public TEntity GetById(int id)
        {
            return _dbContext.Set<TEntity>().Find(id);
        }

        public void Insert(TEntity entity)
        {
             _dbContext.Set<TEntity>().Add(entity);
        }
    }
}