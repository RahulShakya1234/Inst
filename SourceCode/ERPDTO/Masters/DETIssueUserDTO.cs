﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace ERPDTO.Masters
{
    [DataContract]
    public class DETIssueUserDTO : ERPDTOBase
    {
        [DataMember]
        public int SNo { get; set; }

        [DataMember]
        public int MaterialDesc { get; set; }

        [DataMember]
        public int UMOId { get; set; }

        [DataMember]
        public float Qty { get; set; }
    }
}
