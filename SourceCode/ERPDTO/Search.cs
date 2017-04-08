using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace ERPDTO
{
    [DataContract]
    public class Search : ERPDTOBase
    {
        [DataMember]
        public string SearchText { get; set; }

        [DataMember]
        public int Type { get; set; }

    }
}