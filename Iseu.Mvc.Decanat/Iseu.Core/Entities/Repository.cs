using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Data.Objects;
using Iseu.Core.Interfaces;

namespace Iseu.Core.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected IObjectContext _context;

        protected IObjectSet<T> _objectSet;


        public Repository(IObjectContext objectContext)
        {
            _context = objectContext;
            _objectSet = objectContext.CreateObjectSet<T>();
        }


        public IQueryable<T> AsQueryable()
        {
            return _objectSet;
        }

        public IEnumerable<T> GetAll()
        {
            return _objectSet.ToList();
        }

        public IEnumerable<T> Find(Expression<Func<T, bool>> where)
        {
            return _objectSet.Where(where);
        }

        public virtual T Single(Expression<Func<T, bool>> where)
        {
            return _objectSet.Single(where);
        }

        public T First(Expression<Func<T, bool>> where)
        {
            return _objectSet.First(where);
        }

        public void Delete(T entity)
        {
            _objectSet.DeleteObject(entity);
        }

        public void Add(T entity)
        {
            _objectSet.AddObject(entity);
        }

        public void Attach(T entity)
        {
            _objectSet.Attach(entity);
        }

        public T Create()
        {
            return _context.CreateObject<T>();
        }
    }
}
