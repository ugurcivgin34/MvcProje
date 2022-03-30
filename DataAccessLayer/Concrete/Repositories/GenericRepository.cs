﻿using DataAccessLayer.Abstract;
using EntityLayer.Abstarct;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.Repositories
{
    public class GenericRepository<T> : IRepository<T> where T : class, IEntity, new()
    {
        Context c = new Context();
        DbSet<T> _object;

        public GenericRepository()
        {
            _object = c.Set<T>();
        }
        public void Delete(T t)
        {
            var deletedEntity = c.Entry(t);
            deletedEntity.State = EntityState.Deleted;
            c.SaveChanges();
        }

        public T Get(Expression<Func<T, bool>> filter)
        {
            return _object.SingleOrDefault(filter); //Tek değer döndürmek için kullanılır
        }

        public void Insert(T t)
        {
            var addedEntity = c.Entry(t);
            addedEntity.State = EntityState.Added;
            c.SaveChanges();
            //_object.Add(t);
            //c.SaveChanges();
        }

        public List<T> List()
        {
            return _object.ToList();
        }

        public List<T> List(Expression<Func<T, bool>> filter)
        {
            return _object.Where(filter).ToList();
        }

        public void Update(T t)
        {
            var editedEntity = c.Entry(t);
            editedEntity.State = EntityState.Modified;
            c.SaveChanges();
        }
    }
}
