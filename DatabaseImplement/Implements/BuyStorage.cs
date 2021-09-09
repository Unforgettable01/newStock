using BusinessLogic.BindingModels;
using BusinessLogic.Interfaces;
using BusinessLogic.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DatabaseImplement.Implements
{
    public class BuyStorage : IBuyStorage
    {
        public List<BuyViewModel> GetFullList()
        {
            using (var context = new newStockContext())
            {
                return context.Buy.Select(rec => new BuyViewModel
                {
                    id = rec.Id,
                    CustomerName = context.Customer.FirstOrDefault(r => r.Id == rec.CustomerId).Fio,
                    BuyDate = rec.Date
                }).ToList();
            }
        }

        public List<BuyViewModel> GetFilteredList(BuyBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            using (var context = new newStockContext())
            {
                return context.Buy.Where(rec => rec.Id.Equals(model.Id)).Select(rec => new BuyViewModel
                {
                    id = rec.Id,
                    CustomerName = context.Customer.FirstOrDefault(r => r.Id == rec.CustomerId).Fio,
                    BuyDate = rec.Date
                }).ToList();
            }
        }

        public BuyViewModel GetElement(BuyBindingModel model)
        {
            if (model == null)
            {
                return null;
            }

            using (var context = new newStockContext())
            {
                var buy = context.Buy.FirstOrDefault(rec => rec.Id == model.Id);
                return buy != null ?
                new BuyViewModel
                {
                    id = buy.Id,
                    CustomerName = context.Customer.FirstOrDefault(r => r.Id == buy.CustomerId).Fio,
                    BuyDate = buy.Date
                } : null;
            }
        }

        public void Insert(BuyBindingModel model)
        {
            using (var context = new newStockContext())
            {
                using (var transaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        context.Buy.Add(CreateModel(model, new Buy(), context));
                        context.SaveChanges();
                        transaction.Commit();
                    }
                    catch
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }
        }

        public void Update(BuyBindingModel model)
        {
            using (var context = new newStockContext())
            {
                using (var transaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        var element = context.Buy.FirstOrDefault(rec => rec.Id == model.Id);
                        if (element == null)
                        {
                            throw new Exception("Элемент не найден");
                        }
                        CreateModel(model, element, context);
                        context.SaveChanges();
                        transaction.Commit();
                    }
                    catch
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }
        }

        public void Delete(BuyBindingModel model)
        {
            using (var context = new newStockContext())
            {
                Buy element = context.Buy.FirstOrDefault(rec => rec.Id == model.Id);
                if (element != null)
                {
                    context.Buy.Remove(element);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Элемент не найден");
                }
            }
        }

        private Buy CreateModel(BuyBindingModel model, Buy buy, newStockContext context)
        {
            buy.CustomerId = model.CustomerId;
            buy.Date = model.DateBuy;
            return buy;
        }
    }
}
