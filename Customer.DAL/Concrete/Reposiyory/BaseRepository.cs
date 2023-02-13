using Customer.DAL.Abstract.Repository;
using Customer.DAL.Concrete.EntityFramework;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer.DAL.Concrete.Reposiyory
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        private readonly CustomerDbContext _customerDbContext;
        private readonly DbSet<T> _dbSet;
        public BaseRepository(CustomerDbContext customerDbContext)
        {
            _customerDbContext = customerDbContext;
            _dbSet = customerDbContext.Set<T>();
        }

        public IEnumerable<T> GetAll()
        {
            return _dbSet;
        }
        public T GetById(int id)
        {
            return _dbSet.Find(id);
        }
        public void Add(T entity)
        {
            _dbSet.Add(entity);
        }
        public void SaveChanges()
        {
            _customerDbContext.SaveChanges();
        }


    }
}
