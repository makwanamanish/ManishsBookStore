using ManishsBookStore.DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using ManishsBooks.DataAccess.Repository.IRepository;
using ManishsBookStore.DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace ManishsBooks.DataAccess.Repository
{
    //Implements all the methods of the IRepository
    public class Repository<T> : IRepository<T> where T : class
    {
        //Modify the database with the db context
        private readonly ApplicationDbContext _db;      
        internal DbSet<T> dbSet;

        public Repository(ApplicationDbContext db)     
        {
            _db = db;
            this.dbSet = _db.Set<T>();
        }
        public void Add(T entity)
        {
            dbSet.Add(entity);      //Add context so classes correspond to the DbSet in ApplicationDbContext
        }
        public T Get(int id)
        {
            return dbSet.Find(id);
        }
        public IEnumerable<T> GetAll(Expression<Func<T, bool>> filter = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, string includeProperties = null)
        {
            IQueryable<T> query = dbSet;
            if (filter != null)
            {
                query = query.Where(filter);
            }

            if (includeProperties != null)
            {
                foreach (var includeProp in includeProperties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(includeProp);
                }
            }

            if (orderBy != null)
            {
                return orderBy(query).ToList();
            }
            return query.ToList();      //Returns the IEnumerable based on the conditions of the query
        }
        public T GetFirstOrDefault(Expression<Func<T, bool>> filter = null, string includeProperties = null)
        {
            IQueryable<T> query = dbSet;
            if (filter != null)
            {
                query = query.Where(filter);
            }

            if (includeProperties != null)
            {
                foreach (var includeProp in includeProperties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(includeProp);
                }
            }
            return query.FirstOrDefault();      //Returns the IEnumerable based on the conditions of the query
        }
        public void Remove(int id)
        {
            T entity = dbSet.Find(id);
            Remove(entity);
        }
        public void Remove(T entity)
        {
            dbSet.Remove(entity);
        }
        public void RemoveRange(IEnumerable<T> entity)
        {
            dbSet.RemoveRange(entity);
        }
    }
}