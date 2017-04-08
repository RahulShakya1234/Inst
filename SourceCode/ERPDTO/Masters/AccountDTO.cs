using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace ERPDTO.Masters
{
    [DataContract]
    public class AccountDTO : ERPDTOBase
    {
        [DataMember]
        public string Account { get; set; }

        [DataMember]
        public int GroupName { get; set; }

        [DataMember]
        public int AccountType { get; set; }

        [DataMember]
        public int Balance { get; set; }

        [DataMember]
        public int DrCr { get; set; }

        [DataMember]
        public int State { get; set; }

        [DataMember]
        public int SaleType { get; set; }

        [DataMember]
        public int PurchaseType { get; set; }

        [DataMember]
        public string Address { get; set; }

        [DataMember]
        public int MobileNo { get; set; }

        [DataMember]
        public string Email { get; set; }

        [DataMember]
        public string Registration { get; set; }

        [DataMember]
        public string PLACodeNo { get; set; }

        [DataMember]
        public string Commodity { get; set; }

        [DataMember]
        public string Range { get; set; }

        [DataMember]
        public string Division { get; set; }

        [DataMember]
        public string Collactorate { get; set; }

        [DataMember]
        public string PanNo { get; set; }

        [DataMember]
        public string CSTNo { get; set; }

        [DataMember]
        public string STNo { get; set; }

        [DataMember]
        public string ECCNo { get; set; }

        [DataMember]
        public string CreditDays { get; set; }

        [DataMember]
        public bool AdjBillWise { get; set; }

        [DataMember]
        public string TDSRate { get; set; }


        [DataMember]
        public string TDSCategory { get; set; }

        [DataMember]
        public bool LockAcc { get; set; }

        [DataMember]
        public string ModeofTransport { get; set; }

        [DataMember]
        public string NatureofPay { get; set; }

        [DataMember]
        public string VenderCode { get; set; }

        [DataMember]
        public int TypeOfSupplier { get; set; }

        [DataMember]
        public string Country { get; set; }
        [DataMember]
        public string Destination { get; set; }

        [DataMember]
        public string Fax { get; set; }

        [DataMember]
        public string CodeNo { get; set; }

        [DataMember]
        public string Discount { get; set; }

        [DataMember]
        public int CustomerType { get; set; }

        [DataMember]
        public string Location { get; set; }

        [DataMember]
        public string IntrestRate { get; set; }

        [DataMember]
        public bool Active { get; set; }

    }
}


