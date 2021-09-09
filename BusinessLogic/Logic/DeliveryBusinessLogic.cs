using BusinessLogic.BindingModels;
using BusinessLogic.Interfaces;
using BusinessLogic.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.Logic
{
    public class DeliveryBusinessLogic
    {
        private readonly IDeliveryStorage deliveryStorage;

        public DeliveryBusinessLogic(IDeliveryStorage deliveryStorage)
        {
            this.deliveryStorage = deliveryStorage;
        }
        public List<DeliveryViewModel> Read(DeliveryBindingModel model)
        {
            if (model == null)
            {
                return deliveryStorage.GetFullList();
            }
            if (model.Id.HasValue)
            {
                return new List<DeliveryViewModel> { deliveryStorage.GetElement(model) };
            }
            return deliveryStorage.GetFilteredList(model);
        }

        public void CreateDelivery(DeliveryBindingModel model)
        {
            deliveryStorage.Insert(new DeliveryBindingModel
            {
                Id = model.Id,
                WorkerId = model.WorkerId,
                DateDelivery = model.DateDelivery
            });
        }
    }
}
