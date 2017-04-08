using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;


namespace ERPDTO.Masters
{
    [DataContract]
    public class DesignationDTO : ERPDTOBase
    {
        [DataMember]
        public string Designation { get; set; }
    }
}
