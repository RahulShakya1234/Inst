using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace ERPDTO.Masters
{
    [DataContract]
    public class LocationDTO : ERPDTOBase
    {
      [DataMember]
        public string Location { get; set; }
    }
}
