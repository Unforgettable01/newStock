using System;
using System.Runtime.Serialization;

namespace BusinessLogic.BindingModels
{
    [DataContract]
    public class BuyBindingModel
    {
        [DataMember]
        public int? Id { get; set; }
        [DataMember]
        public int CustomerId { get; set; }
        [DataMember]
        public DateTime DateBuy { get; set; }

    }
}
