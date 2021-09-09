using BusinessLogic.BindingModels;
using BusinessLogic.Interfaces;
using BusinessLogic.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DatabaseImplement.Implements
{
    public class ProductStorage : IProductStorage
    {
        public List<ProductViewModel> GetFullList()
        {
            using (var context = new newStockContext())
            {
                return context.Product
                .Select(CreateModel).ToList();
            }
        }

        public List<ProductViewModel> GetFilteredList(ProductBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            using (var context = new newStockContext())
            {
                return context.Product
                    .Where(rec =>
                    rec.Name.Contains(model.ProductName))
                    .Select(CreateModel).ToList();
            }
        }

        public ProductViewModel GetElement(ProductBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            using (var context = new newStockContext())
            {
                var product = context.Product
                .FirstOrDefault(rec => rec.Id == model.Id);
                return product != null ?
                CreateModel(product) : null;
            }
        }

        public void Insert(ProductBindingModel model)
        {
            using (var context = new newStockContext())
            {
                context.Product.Add(CreateModel(model, new Product()));
                context.SaveChanges();
            }
        }

        public void Update(ProductBindingModel model)
        {
            using (var context = new newStockContext())
            {
                var element = context.Product.FirstOrDefault(rec => rec.Id == model.Id);
                if (element == null)
                {
                    throw new Exception("Продукт не найден");
                }
                CreateModel(model, element);
                context.SaveChanges();
            }
        }

        public void Delete(ProductBindingModel model)
        {
            using (var context = new newStockContext())
            {
                Product element = context.Product.FirstOrDefault(rec => rec.Id == model.Id);
                if (element != null)
                {
                    context.Product.Remove(element);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Продукт не найден");
                }
            }
        }

        private Product CreateModel(ProductBindingModel model, Product product)
        {
            product.Name = model.ProductName;       
            return product;
        }

        private ProductViewModel CreateModel(Product product)
        {
            return new ProductViewModel
            {
                Id = product.Id,
                ProductName = product.Name               
            };
        }
    }
}
