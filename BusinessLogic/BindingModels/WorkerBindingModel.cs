using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace BusinessLogic.BindingModels
{
    [DataContract]
    public class WorkerBindingModel
    {
        [DataMember]
        public int? Id { get; set; }
        [DataMember]
        public string WorkerName { get; set; }
        [DataMember]
        public string Login { get; set; }
        [DataMember]
        public string Password { get; set; }

    }
}
