using Customer.DAL.Abstract.Repository;
using Customer.Models.Entities;
using Customer.Models.Request;
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
        public BaseResponceModel<bool> AddCustomer(CustomerDto customers)
        {
            BaseResponceModel<bool> model = new BaseResponceModel<bool>();
            try
            {
                model.IsSuccess = false;
                model.Obj = false;
                if (string.IsNullOrWhiteSpace(customers?.CustomerName) || string.IsNullOrEmpty(customers?.CustomerName))
                {
                    model.Message = "Ad bos ola bilmez";
                    return model;
                }
                if (string.IsNullOrWhiteSpace(customers?.CustomerSurname) || string.IsNullOrEmpty(customers?.CustomerSurname))
                {
                    model.Message = "Soyad bos ola bilmez";
                    return model;
                }
                if (string.IsNullOrWhiteSpace(customers?.CustomerPosition) || string.IsNullOrEmpty(customers?.CustomerPosition))
                {
                    model.Message = "Vezife bos ola bilmez";
                    return model;
                }
                if (string.IsNullOrWhiteSpace(customers?.CustomerSalary.ToString()) || string.IsNullOrEmpty(customers?.CustomerSalary.ToString()))
                {
                    model.Message = "Maas bos ola bilmez";
                     return model;
                }
                if (string.IsNullOrWhiteSpace(customers?.CustomerCity.ToString()) || string.IsNullOrEmpty(customers?.CustomerCity.ToString()))
                {
                    model.Message = "Olke bos ola bilmez";
                     return model;
                }
                var customer = new Customers
                {
                    CustomerName = customers.CustomerName,
                    CustomerSurname = customers.CustomerSurname,
                    CustomerPosition = customers.CustomerPosition,
                    CustomerSalary = customers.CustomerSalary,
                    CustomerCity = customers.CustomerCity,
                    CustomerStatus = 1
                };
             
                _customerRepository.Add(customer);
                _customerRepository.SaveChanges();

                model.Obj = true;
                model.IsSuccess = true;
                model.Message = "Elave olundu";
                return model;
            }
            catch (Exception ex)
            {
                model.Obj = false;
                model.IsSuccess = false;
                model.Message = "Xeta bas verdi" + ex.ToString();
                return model;
            }
           
        }
        public BaseResponceModel<bool> DeleteCustomer(int id)
        {
            BaseResponceModel<bool> model = new BaseResponceModel<bool>();
            try
            {
                var deletedCustomer = _customerRepository.GetById(id);
                if (deletedCustomer is null)
                {
                    model.IsSuccess = false;
                    model.Obj = false;
                    model.Message = "Melumat tapilmadi";
                    return model;
                }
                if (deletedCustomer.CustomerStatus == 0)
                {
                    model.IsSuccess = false;
                    model.Obj = false;
                    model.Message = "Melumat tapilmadi";
                    return model;
                }
                deletedCustomer.CustomerStatus = 0;
                _customerRepository.SaveChanges();
                model.IsSuccess = true;
                model.Obj = true;
                model.Message = "Silindi";
                return model;
            }
            catch (Exception ex)
            {
                model.IsSuccess = false;
                model.Obj = false;
                model.Message = "Xeta bas verdi" + ex.ToString();
                return model;
            }
            
        }

    }
}
