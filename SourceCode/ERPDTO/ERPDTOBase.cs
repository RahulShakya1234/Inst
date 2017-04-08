using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using ERPDTO.Masters;

namespace ERPDTO
{
    [KnownType(typeof(DETIssueUserDTO))]
    [KnownType(typeof(MSTIssueMasterDTO))]
    [KnownType(typeof(UserDetailsDTO))]
    [KnownType(typeof(DesignationDTO))]
    [KnownType(typeof(SoftwareRoleDTO))]
    [KnownType(typeof(LocationDTO))]
    [KnownType(typeof(DeptDTO))]

    [KnownType(typeof(MSTDirectEntryDTO))]
    [KnownType(typeof(DETDirectEntryDTO))]
    [KnownType(typeof(UMODTO))]
    [KnownType(typeof(DETPurchaseBillDTO))]
    [KnownType(typeof(MSTPurchaseBillDTO))]
    [KnownType(typeof(MSTSaleOrderReceivingEntryDTO))]
    [KnownType(typeof(SaleOrderReceivingEntryDTO))]
    [KnownType(typeof(PartyWiseItemRateDTO))]
    [KnownType(typeof(ItemDTO))]
    [KnownType(typeof(AccountDTO))]
    [KnownType(typeof(ItemGroupDTO))]
    [KnownType(typeof(Search))]
    [KnownType (typeof(MSTGRNDTO))]
    [KnownType(typeof(DETGRNDTO))]
    [DataContract, KnownType(typeof(AccountGroupDTO))]
    


    public class ERPDTOBase
    {
        [DataMember]
        public int Id { get; set; }

        //[DataMember]
        //public int MSTSaleOrderReceivingEntryId { get; set; }
    }

}
