using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace ERPDTO
{
    [DataContract]
    public class Result : ERPDTOBase
    {
        [DataMember]
        public OperationStatus ResultStatus { get; set; }
        
        [DataMember]
        public string Message { get; set; }

    }
}
