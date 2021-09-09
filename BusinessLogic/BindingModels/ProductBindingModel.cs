using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace BusinessLogic.BindingModels
{
    [DataContract]
    public class ProductBindingModel
    {
        [DataMember]
        public int? Id { get; set; }
        [DataMember]
        public string ProductName { get; set; }
        [DataMember]
        public int CountOnStock { get; set; }

    }
}
