using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace DatabaseImplement
{
    public partial class ProductBuy
    {
        public int ProductId { get; set; }
        public int BuyId { get; set; }
        public int Count { get; set; }

        public virtual Buy Buy { get; set; }
        public virtual Product Product { get; set; }
    }
}
