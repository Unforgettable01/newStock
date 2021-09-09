using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace DatabaseImplement
{
    public partial class Delivery
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int WorkerId { get; set; }

        public virtual Worker Worker { get; set; }
    }
}
