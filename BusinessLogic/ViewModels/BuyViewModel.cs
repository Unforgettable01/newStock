using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace BusinessLogic.ViewModels
{
    [DataContract]
    public class BuyViewModel
    {
        public int? id { get; set; }
        [DataMember]
        public DateTime BuyDate { get; set; }
        [DataMember]
        public string CustomerName { get; set; }

    }
}
