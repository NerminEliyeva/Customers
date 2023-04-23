using Customer.Models.Entities;
using Customer.Models.Request;
using Customer.Models.Responce;
using Customer.Services;
using Customer.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Customer.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _customerService;
        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }
        [HttpGet("GetAllCustomers")]
        public BaseResponceModel<List<CustomerAndCity>> GetAllCustomers()
        {
            return _customerService.GetAllCustomers();
        }
        [HttpGet("GetAllCountries")]
        public BaseResponceModel<List<Countries>> GetAllCountries()
        {
            return _customerService.GetAllCountries();
        }
        [HttpGet("GetCustomersById/{id}")]
        public BaseResponceModel<Customers> GetCustomersById(int id)
        {
            return _customerService.GetCustomerById(id);
        }
        [HttpGet("GetCountryById/{id}")]
        public BaseResponceModel<Countries> GetCountryById(int id)
        {
            return _customerService.GetCountryById(id);
        }


        [HttpPost("AddCustomer")]
        public BaseResponceModel<bool> AddCustomer(CustomerDto customer)
        {
            return _customerService.AddCustomer(customer);
        }
        [HttpPost("DeleteCustomer/{id}")]
        public BaseResponceModel<bool> DeleteCustomer(int id)
        {
            return _customerService.DeleteCustomer(id);
        }
        [HttpPost("UpdateCustomer/{id}")]
        public BaseResponceModel<bool> UpdateCustomer(int id,UpdatedCustomers customer)
        {
            return _customerService.UpdateCustomer(id,customer);
        }
    }
}
