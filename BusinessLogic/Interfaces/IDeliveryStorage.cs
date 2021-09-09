using BusinessLogic.BindingModels;
using BusinessLogic.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.Interfaces
{
    public interface IDeliveryStorage
    {
        List<DeliveryViewModel> GetFullList();
        List<DeliveryViewModel> GetFilteredList(DeliveryBindingModel model);
        DeliveryViewModel GetElement(DeliveryBindingModel model);
        void Insert(DeliveryBindingModel model);
        void Update(DeliveryBindingModel model);
        void Delete(DeliveryBindingModel model);
    }
}
