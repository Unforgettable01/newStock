using BusinessLogic.BindingModels;
using BusinessLogic.Interfaces;
using BusinessLogic.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.Logic
{
    public class ProductBusinessLogic
    {
        private readonly IProductStorage productStorage;

        public ProductBusinessLogic(IProductStorage productStorage)
        {
            this.productStorage = productStorage;
        }

        public List<ProductViewModel> Read(ProductBindingModel model)
        {
            if (model == null)
            {
                return productStorage.GetFullList();
            }
            if (model.Id.HasValue)
            {
                return new List<ProductViewModel> { productStorage.GetElement(model) };
            }
            return productStorage.GetFilteredList(model);
        }

        public void CreateOrUpdate(ProductBindingModel model)
        {
            var element = productStorage.GetElement(new ProductBindingModel { ProductName = model.ProductName });
            if (element != null && element.Id != model.Id)
            {
                throw new Exception("Уже есть продукт с таким названием");
            }
            if (model.Id.HasValue)
            {
                productStorage.Update(model);
            }
            else
            {
                productStorage.Insert(model);
            }
        }
        public void Delete(ProductBindingModel model)
        {
            var element = productStorage.GetElement(new ProductBindingModel { Id = model.Id });
            if (element == null)
            {
                throw new Exception("Продукт не найден");
            }
            productStorage.Delete(model);
        }
    }
}
