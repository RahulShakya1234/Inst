using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace ERPDTO.Masters
{
    [DataContract]
    public class AccountGroupDTO : ERPDTOBase
    {
        [DataMember]
        public string AccountGroupName { get; set; }

        [DataMember]
        public int PrimaryAccountGroup { get; set; }

        [DataMember]
        public int RefrenceNo { get; set; }

        [DataMember]
        public char BType { get; set; }

        [DataMember]
        public int GType { get; set; }

        [DataMember]
        public int PrintSummaryTrialBalType { get; set; }

        
        
    }
}
