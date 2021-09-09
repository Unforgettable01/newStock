using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace BusinessLogic.ViewModels
{
    [DataContract]
    public class DeliveryViewModel
    {
        public int? id { get; set; }
        [DataMember]
        public DateTime DeliveryDate { get; set; }
        [DataMember]
        public string WorkerName { get; set; }

    }
}
