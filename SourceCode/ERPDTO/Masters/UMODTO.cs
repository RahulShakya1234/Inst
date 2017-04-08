using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace ERPDTO.Masters
{
    [DataContract]
    public class UMODTO : ERPDTOBase
    {
        [DataMember]
        public string Name { get; set; }
    }

}
