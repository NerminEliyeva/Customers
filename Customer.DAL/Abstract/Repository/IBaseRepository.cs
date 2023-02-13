using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer.DAL.Abstract.Repository
{
    public interface IBaseRepository<T> where T : class 
    {
        IEnumerable<T> GetAll();
        T GetById(int id);
        void Add(T entity);
    }
}
