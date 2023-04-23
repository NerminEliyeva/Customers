using Customer.Models.Entities;
using Customer.Models.Request;
using Customer.Models.Responce;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer.Services.Interfaces
{
    public interface ICustomerService
    {
        BaseResponceModel<List<CustomerAndCity>> GetAllCustomers();
        BaseResponceModel<List<Countries>> GetAllCountries();
        BaseResponceModel<Customers> GetCustomerById(int id);
        BaseResponceModel<bool> AddCustomer(CustomerDto customers);
        BaseResponceModel<bool> DeleteCustomer(int id);
        BaseResponceModel<bool> UpdateCustomer(int id, UpdatedCustomers customer);
        BaseResponceModel<Countries> GetCountryById(int id);
    }
}
