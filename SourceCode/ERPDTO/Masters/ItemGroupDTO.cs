using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace ERPDTO.Masters
{
     [DataContract]
    public class ItemGroupDTO : ERPDTOBase
    {
        [DataMember]
        public string ItemGroupName { get; set; }

        [DataMember]
        public int UpperGroup { get; set; }

        [DataMember]
        public string Prefix { get; set; }

        [DataMember]
        public bool SalableItemGrp { get; set; }

        [DataMember]
        public bool AutomaticQC { get; set; }

        [DataMember]
        public bool AutoAssemlyfromRGP { get; set; }

        [DataMember]
        public bool AutoMRN { get; set; }

        [DataMember]
        public bool PORequiredinMRN { get; set; }

        [DataMember]
        public bool ShowinWorkerOrder { get; set; }

        [DataMember]
        public bool MakeAutoProductionEntry { get; set; }

        [DataMember]
        public bool ScheduleNoRequiredinMRN { get; set; }

       
    }
}
