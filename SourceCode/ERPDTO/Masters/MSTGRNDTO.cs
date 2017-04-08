using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace ERPDTO.Masters
{

    public class MSTGRNDTO : ERPDTOBase
    {

        [DataMember]
        public int SupplierName { get; set; }

        [DataMember]
        public string DCBillInvoiceNo { get; set; }

        [DataMember]
        public DateTime DcBillInvoiceDate { get; set; }


        [DataMember]
        public string GRNNo { get; set; }

        [DataMember]
        public DateTime GRNDate { get; set; }

        [DataMember]
        public string LLRRWayBillNo { get; set; }

        [DataMember]
        public DateTime LLRRWayBillDate { get; set; }

        [DataMember]
        public string PONo { get; set; }

        [DataMember]
        public DateTime PODate { get; set; }

        [DataMember]
        public string Prepared { get; set; }

        [DataMember]
        public string StoreIncharge { get; set; }

        [DataMember]
        public string MaterialManager { get; set; }

        [DataMember]
        public string PostedIntoStockBy { get; set; }
    }
}

