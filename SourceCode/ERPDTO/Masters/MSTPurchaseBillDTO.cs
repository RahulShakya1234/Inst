using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace ERPDTO.Masters
{
    [DataContract]
    public class MSTPurchaseBillDTO : ERPDTOBase
    {
        [DataMember]
        public string SerialBillNo { get; set; }

        [DataMember]
        public DateTime Entrydate { get; set; }

        [DataMember]
        public string BillNo { get; set; }

        [DataMember]
        public DateTime BillDate { get; set; }

        [DataMember]
        public string Narration { get; set; }

        [DataMember]
        public int Supplier { get; set; }

        [DataMember]
        public int PurchaseCategy { get; set; }

        [DataMember]
        public int PurchaseType { get; set; }

        [DataMember]
        public int PurchaseAcc { get; set; }

        [DataMember]
        public float Cess { get; set; }

        [DataMember]
        public float HECess { get; set; }

        [DataMember]
        public bool AddExcise { get; set; }

        [DataMember]
        public float ExciseDuty { get; set; }

        


        [DataMember]
        public float ExciseReg { get; set; }

        [DataMember]
        public float ExciseNo { get; set; }

        [DataMember]
        public string Transport { get; set; }

        [DataMember]
        public string Carrier { get; set; }


        [DataMember]
        public string Remarks { get; set; }


        [DataMember]
        public float TotalAmount { get; set; }

        [DataMember]
        public float SaleTax { get; set; }

        [DataMember]
        public float SurchargeTax { get; set; }

        [DataMember]
        public float BillAmount { get; set; }

        [DataMember]
        public bool MakeIssueToProductionBill { get; set; }

        [DataMember]
        public string PackingForwarding { get; set; }

        [DataMember]
        public string Freightnsurance { get; set; }

       /// <summary>
       ///  1 for Purchase 
       ///  2 for Direct Entry
       /// </summary>

        [DataMember]
        public int Type { get; set; }    

    }
}
