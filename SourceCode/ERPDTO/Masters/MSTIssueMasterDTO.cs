using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace ERPDTO.Masters
{
    [DataContract]
   public class MSTIssueMasterDTO : ERPDTOBase
    {
        [DataMember]
        public string OrderNo { get; set; }

        [DataMember]
        public DateTime Orderdate { get; set; }

        [DataMember]
        public string Remarks { get; set; }

        [DataMember]
        public int IssueTo { get; set; }

        



    }
}
