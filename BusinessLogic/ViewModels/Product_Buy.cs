using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BusinessLogic.ViewModels
{
    public class Product_Buy
    {
        public int Id { get; set; }
        [DisplayName("Название продукта")]
        public string ProductName { get; set; }
        [DisplayName("Количество")]
        public string Number { get; set; }
    }
}
