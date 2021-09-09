using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace DatabaseImplement
{
    public partial class Worker
    {
        public Worker()
        {
            Delivery = new HashSet<Delivery>();
        }

        public int Id { get; set; }
        public string Fio { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }

        public virtual ICollection<Delivery> Delivery { get; set; }
    }
}
