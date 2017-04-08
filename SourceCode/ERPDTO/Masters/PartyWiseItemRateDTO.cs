using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;


namespace ERPDTO.Masters
{
    [DataContract]
   public class PartyWiseItemRateDTO : ERPDTOBase
    {
        [DataMember]
        public int PartyName { get; set; }

        [DataMember]
        public string ItemName { get; set; }

        [DataMember]
        public float ItemCode { get; set; }

        [DataMember]
        public float PackingRate { get; set; }

        [DataMember]
        public string PONo { get; set; }

        [DataMember]
        public int AmendmentNo { get; set; }

        [DataMember]
        public DateTime PODate { get; set; }

        [DataMember]
        public DateTime AmendmentDate { get; set; }

        [DataMember]
        public string PartNo { get; set; }

        [DataMember]
        public float ToolSupplyForQty { get; set; }

        [DataMember]
        public float ToolRate { get; set; }

        [DataMember]
        public float Tax { get; set; }

        [DataMember]
        public string ToolNarr { get; set; }

        [DataMember]
        public string ProcessName { get; set; }
    }
}
