using BusinessLogic.BindingModels;
using BusinessLogic.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.Interfaces
{
    public interface IBuyStorage
    {
        List<BuyViewModel> GetFullList();
        List<BuyViewModel> GetFilteredList(BuyBindingModel model);
        BuyViewModel GetElement(BuyBindingModel model);
        void Insert(BuyBindingModel model);
        void Update(BuyBindingModel model);
        void Delete(BuyBindingModel model);
    }
}
