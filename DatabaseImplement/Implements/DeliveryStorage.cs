using BusinessLogic.BindingModels;
using BusinessLogic.Interfaces;
using BusinessLogic.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DatabaseImplement.Implements
{
    public class DeliveryStorage : IDeliveryStorage
    {
        public List<DeliveryViewModel> GetFullList()
        {
            using (var context = new newStockContext())
            {
                return context.Delivery.Select(rec => new DeliveryViewModel
                {
                    id = rec.Id,
                    WorkerName = context.Worker.FirstOrDefault(r => r.Id == rec.WorkerId).Fio,
                    DeliveryDate = rec.Date
                }).ToList();
            }
        }

        public List<DeliveryViewModel> GetFilteredList(DeliveryBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            using (var context = new newStockContext())
            {
                return context.Delivery.Where(rec => rec.Id.Equals(model.Id)).Select(rec => new DeliveryViewModel
                {
                    id = rec.Id,
                    WorkerName = context.Worker.FirstOrDefault(r => r.Id == rec.WorkerId).Fio,
                    DeliveryDate = rec.Date
                }).ToList();
            }
        }

        public DeliveryViewModel GetElement(DeliveryBindingModel model)
        {
            if (model == null)
            {
                return null;
            }

            using (var context = new newStockContext())
            {
                var delivery = context.Delivery.FirstOrDefault(rec => rec.Id == model.Id);
                return delivery != null ?
                new DeliveryViewModel
                {
                    id = delivery.Id,
                    WorkerName = context.Worker.FirstOrDefault(r => r.Id == delivery.WorkerId).Fio,
                    DeliveryDate = delivery.Date
                } : null;
            }
        }

        public void Insert(DeliveryBindingModel model)
        {
            using (var context = new newStockContext())
            {
                using (var transaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        context.Delivery.Add(CreateModel(model, new Delivery(), context));
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

        public void Update(DeliveryBindingModel model)
        {
            using (var context = new newStockContext())
            {
                using (var transaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        var element = context.Delivery.FirstOrDefault(rec => rec.Id == model.Id);
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

        public void Delete(DeliveryBindingModel model)
        {
            using (var context = new newStockContext())
            {
                Delivery element = context.Delivery.FirstOrDefault(rec => rec.Id == model.Id);
                if (element != null)
                {
                    context.Delivery.Remove(element);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Элемент не найден");
                }
            }
        }

        private Delivery CreateModel(DeliveryBindingModel model, Delivery delivery, newStockContext context)
        {
            delivery.WorkerId = model.WorkerId;
            delivery.Date = model.DateDelivery;
            return delivery;
        }
    }
}
