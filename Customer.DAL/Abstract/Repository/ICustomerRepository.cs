using Customer.Models.Entities;
using Customer.Models.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer.DAL.Abstract.Repository
{
    public interface ICustomerRepository : IBaseRepository<Customers>
    {
        List<CustomerAndCity> GetCustomerWithCity();
    }
}
