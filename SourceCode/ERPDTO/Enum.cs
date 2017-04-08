using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ERPDTO
{
    public enum OperationStatus
    {
        SavedSuccessFully = 1,
        DeletedSuccessFully=2,
        LoginSuccessFully=3,
        Loginfailed = 4,
    }

    public enum PageName
    {
        AccountGroup = 1,
        ItemGroup = 2,
        Account = 3,
        Item = 4,
        PartyWiseItemRate = 5,
        SaleOrderReceivingEntryMST = 6,
        SaleOrderReceivingEntryDET = 7,
        MSTPurchaseBill=8,
        DETPurchaseBill = 9,
        ItemDescp = 10,
        UMO=11,
        MSTDirectEntry=12,
        DETDirectEntry = 13,
        SoftwareRole=14,
        Dept=15,
        Desig=16,
        Location=17,
        UserDetails= 18,
        MSTIssueMaster=19,
        DETIssueMaster=20,
        MSTUserDetails=21,
        MSTGRN=24,
        DETGRN=25

    }   

}
