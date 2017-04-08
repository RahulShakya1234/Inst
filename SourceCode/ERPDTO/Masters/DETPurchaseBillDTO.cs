using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace ERPDTO.Masters
{
    [DataContract]
    public class DETPurchaseBillDTO : ERPDTOBase
    {
        [DataMember]
        public int SNo { get; set; }

        [DataMember]
        public int MaterialDesc { get; set; }

        [DataMember]
        public int UMOId { get; set; }

        [DataMember]
        public float Qty { get; set; }

        [DataMember]
        public float Rate { get; set; }

        [DataMember]
        public float DiscPerc { get; set; }


        [DataMember]
        public float DicsAmount { get; set; }

        [DataMember]
        public float ExciseDuty { get; set; }

        [DataMember]
        public float ECess { get; set; }

        [DataMember]
        public float HECessPerc { get; set; }

        [DataMember]
        public float HECessAmount { get; set; }

        [DataMember]
        public string Tariff { get; set; }


        [DataMember]
        public DateTime InvoiceDate { get; set; }


        [DataMember]
        public DateTime ETADate { get; set; }

        [DataMember]
        public string Specs { get; set; }

        [DataMember]
        public float TotalAmount { get; set; }

        [DataMember]
        public float CVDAmount { get; set; }

    }
}
