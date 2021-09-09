using BusinessLogic.BindingModels;
using BusinessLogic.Interfaces;
using BusinessLogic.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DatabaseImplement.Implements
{
    public class CustomerStorage : ICustomerStorage
    {
        public List<CustomerViewModel> GetFullList()
        {
            using (var context = new newStockContext())
            {
                return context.Customer
                .Select(CreateModel).ToList();
            }
        }

        public List<CustomerViewModel> GetFilteredList(CustomerBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            using (var context = new newStockContext())
            {
                return context.Customer
                    .Where(rec =>
                    rec.Fio.Contains(model.CustomerName) || (rec.Login.Equals(model.Login) && rec.Password.Equals(model.Password)))
                    .Select(CreateModel).ToList();
            }
        }

        public CustomerViewModel GetElement(CustomerBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            using (var context = new newStockContext())
            {
                var customer = context.Customer
                .FirstOrDefault(rec => rec.Login.Equals(model.Login) || rec.Id == model.Id);
                return customer != null ?
                CreateModel(customer) : null;
            }
        }

        public void Insert(CustomerBindingModel model)
        {
            using (var context = new newStockContext())
            {
                context.Customer.Add(CreateModel(model, new Customer()));
                context.SaveChanges();
            }
        }

        public void Update(CustomerBindingModel model)
        {
            using (var context = new newStockContext())
            {
                var element = context.Customer.FirstOrDefault(rec => rec.Id == model.Id);
                if (element == null)
                {
                    throw new Exception("Покупатель не найден");
                }
                CreateModel(model, element);
                context.SaveChanges();
            }
        }

        public void Delete(CustomerBindingModel model)
        {
            using (var context = new newStockContext())
            {
                Customer element = context.Customer.FirstOrDefault(rec => rec.Id == model.Id);
                if (element != null)
                {
                    context.Customer.Remove(element);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Покупатель не найден");
                }
            }
        }

        private Customer CreateModel(CustomerBindingModel model, Customer customer)
        {
            customer.Fio = model.CustomerName;
            customer.Login = model.Login;
            customer.Password = model.Password;
            return customer;
        }

        private CustomerViewModel CreateModel(Customer customer)
        {
            return new CustomerViewModel
            {
                Id = customer.Id,
                CustomerName = customer.Fio,
                Login = customer.Login,
                Password = customer.Password
            };
        }
    }
}
