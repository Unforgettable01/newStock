using BusinessLogic.BindingModels;
using BusinessLogic.Interfaces;
using BusinessLogic.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.Logic
{
    public class CustomerBusinessLogic
    {
        private readonly ICustomerStorage customerStorage;
        public CustomerBusinessLogic(ICustomerStorage customerStorage)
        {
            this.customerStorage = customerStorage;
        }

        public List<CustomerViewModel> Read(CustomerBindingModel model)
        {
            if (model == null)
            {
                return customerStorage.GetFullList();
            }
            if (model.Id.HasValue)
            {
                return new List<CustomerViewModel> { customerStorage.GetElement(model) };
            }
            return customerStorage.GetFilteredList(model);
        }

        public void CreateOrUpdate(CustomerBindingModel model)
        {
            var customer = customerStorage.GetElement(new CustomerBindingModel
            {
                Login = model.Login
            });
            if (customer != null && customer.Id != model.Id)
            {
                throw new Exception("Уже есть такой пользователь");
            }
            if (model.Id.HasValue)
            {
                customerStorage.Update(model);
            }
            else
            {
                customerStorage.Insert(model);
            }
        }
        public void Delete(CustomerBindingModel model)

        {
            var customer = customerStorage.GetElement(new CustomerBindingModel
            {
                Id = model.Id
            });
            if (customer == null)
            {
                throw new Exception("Пользователь не найден");
            }
            customerStorage.Delete(model);
        }
        public int CheckPassword(string login, string password)
        {
            var customer = customerStorage.GetElement(new CustomerBindingModel
            {
                Login = login
            });
            if (customer == null)
            {
                throw new Exception("Нет такого пользователя");
            }
            if (customer.Password != password)
            {
                throw new Exception("Неверный пароль");
            }
            return customer.Id;
        }
    }
}
