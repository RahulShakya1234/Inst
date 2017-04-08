using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
namespace ERPDTO.Masters
{

    public class DETGRNDTO : ERPDTOBase
    {
        [DataMember]
        public int SNo { get; set; }

        [DataMember]
        public int MaterialDesc { get; set; }

        [DataMember]
        public int UnitCode { get; set; }

        [DataMember]
        public float DC { get; set; }

        [DataMember]
        public float Recieved { get; set; }

        [DataMember]
        public float AcceptedIntoStock { get; set; }

        [DataMember]
        public string MaterialCheckingSlipNo { get; set; }

        [DataMember]
        public float Value { get; set; }
    }
}

