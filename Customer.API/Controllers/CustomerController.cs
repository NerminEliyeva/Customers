using Customer.Models.Entities;
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
        public BaseResponceModel<List<Customers>> GetAllCustomers()
        {
            return _customerService.GetAllCustomers();
        }
        [HttpGet("GetCustomersById/{id}")]
        public BaseResponceModel<Customers> GetCustomersById(int id)
        {
            return _customerService.GetCustomerById(id);
        }

    }
}
