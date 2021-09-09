using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace BusinessLogic.BindingModels
{
    [DataContract]
    public class DeliveryBindingModel
    {
        [DataMember]
        public int? Id { get; set; }
        [DataMember]
        public int WorkerId { get; set; }
        [DataMember]
        public DateTime DateDelivery { get; set; }

    }
}
