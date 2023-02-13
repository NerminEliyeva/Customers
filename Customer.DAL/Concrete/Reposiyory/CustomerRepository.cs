using Customer.DAL.Abstract.Repository;
using Customer.DAL.Concrete.EntityFramework;
using Customer.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer.DAL.Concrete.Reposiyory
{
    public class CustomerRepository : BaseRepository<Customers>, ICustomerRepository
    {
        public CustomerRepository(CustomerDbContext customerDbContext) : base(customerDbContext)
        {
        }
    }
}
