using BusinessLogic.BindingModels;
using BusinessLogic.Interfaces;
using BusinessLogic.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.Logic
{
    public class BuyBusinessLogic
    {
        private readonly IBuyStorage buyStorage;

        public BuyBusinessLogic(IBuyStorage buyStorage)
        {
            this.buyStorage = buyStorage;
        }
        public List<BuyViewModel> Read(BuyBindingModel model)
        {
            if (model == null)
            {
                return buyStorage.GetFullList();
            }
            if (model.Id.HasValue)
            {
                return new List<BuyViewModel> { buyStorage.GetElement(model) };
            }
            return buyStorage.GetFilteredList(model);
        }

        public void CreateBuy(BuyBindingModel model)
        {
            buyStorage.Insert(new BuyBindingModel
            {
                Id = model.Id,
                CustomerId = model.CustomerId,
                DateBuy = model.DateBuy                
            });
        }
    }
}
