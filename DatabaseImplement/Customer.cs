﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace DatabaseImplement
{
    public partial class Customer
    {
        public Customer()
        {
            Buy = new HashSet<Buy>();
        }

        public int Id { get; set; }
        public string Fio { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }

        public virtual ICollection<Buy> Buy { get; set; }
    }
}
