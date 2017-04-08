using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace ERPDTO.Masters
{
      [DataContract]
    public class UserDetailsDTO : ERPDTOBase
    {

        [DataMember]
        public int UserCode { get; set; }

        [DataMember]
        public string UserName { get; set; }

        [DataMember]
        public string Password { get; set; }

        [DataMember]
        public int Gender { get; set; }

        [DataMember]
        public DateTime DOB { get; set; }

        [DataMember]
        public DateTime DOJ { get; set; }

        [DataMember]
        public DateTime DOL { get; set; }

        [DataMember]
        public int Department { get; set; }

        [DataMember]
        public int Location { get; set; }

        [DataMember]
        public int Designation { get; set; }

        [DataMember]
        public int SoftwareRole { get; set; }


    }
}
