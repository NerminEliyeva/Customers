using Customer.DAL.Abstract.Repository;
using Customer.DAL.Concrete.EntityFramework;
using Customer.Models.Entities;
using Customer.Models.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer.DAL.Concrete.Reposiyory
{
    public class CustomerRepository : BaseRepository<Customers>, ICustomerRepository
    {
        private readonly CustomerDbContext _customerDbContext;
        public CustomerRepository(CustomerDbContext customerDbContext) : base(customerDbContext)
        {
            _customerDbContext = customerDbContext;
        }

        public List<CustomerAndCity> GetCustomerWithCity()
        {
            return _customerDbContext.Customers
                .Join(
                _customerDbContext.Countries,
                cust => cust.CustomerCity,
                cou => cou.CountryId,
                (cust, cou) => new CustomerAndCity
                {
                    CustomerDto = new CustomerDto()
                    {
                        CustomerCity = cust.CustomerCity,
                        CustomerName = cust.CustomerName,
                        CustomerPosition = cust.CustomerPosition,
                        CustomerSalary = cust.CustomerSalary,
                        CustomerStatus = cust.CustomerStatus,
                        CustomerSurname = cust.CustomerSurname
                    },
                    CityName = cou.CountryName
                }).ToList();
        }

    }
}
