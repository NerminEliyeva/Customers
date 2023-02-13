using Customer.Models.Entities;
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
        BaseResponceModel<List<Customers>> GetAllCustomers();
        BaseResponceModel<Customers> GetCustomerById(int id);
    }
}
