using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace ERPDTO.Masters
{
    [DataContract]
  public  class SaleOrderReceivingEntryDTOMst : ERPDTOBase
    {

        [DataMember]
        public string OrderNo { get; set; }

        [DataMember]
        public DateTime OrderDate { get; set; }

        [DataMember]
        public int PartyName { get; set; }

        [DataMember]
        public string Remarks { get; set; }

        [DataMember]
        public bool Active { get; set; }

       
        [DataMember]
        public float Total { get; set; }


    }
}
