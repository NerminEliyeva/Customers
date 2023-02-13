using Customer.DAL.Abstract.Repository;
using Customer.Models.Entities;
using Customer.Models.Responce;
using Customer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;
        public CustomerService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public BaseResponceModel<List<Customers>> GetAllCustomers()
        {
            BaseResponceModel<List<Customers>> model = new BaseResponceModel<List<Customers>>();
            var result = _customerRepository.GetAll().Where(x => x.CustomerStatus == 1).ToList();

            if (result.Count() <= 0)
            {
                model.Obj = null;
                model.IsSuccess = false;
                model.Message = "Bazada melumat tapilmadi";
                return model;
            }
            model.Obj = result;
            model.IsSuccess = true;
            model.Message = "Emeliyyat ugurludur";
            return model;
        }
        public BaseResponceModel<Customers> GetCustomerById(int id)
        {
            BaseResponceModel<Customers> model = new BaseResponceModel<Customers>();
            try
            {
                var result = _customerRepository.GetById(id);
                if (result is null)
                {
                    model.IsSuccess = false;
                    model.Message = "Melumat tapilmadi";
                }
                else
                {
                    model.Obj = result;
                    model.IsSuccess = true;
                    model.Message = "Emeliyyat ugurludur";
                }
                return model;

            }
            catch (Exception ex)
            {
                model.IsSuccess = true;
                model.Message = "Xeta bas verdi" + ex.ToString();
                return model;
            }
        }

    }
}
