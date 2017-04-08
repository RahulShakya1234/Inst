using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ERPDTO;
using ERPDTO.Masters;
using ERPDAL;
using ERPDAL.Masters;
using System.Data;

namespace ERPBL.Masters
{
    public class AccountGroupBL
    {
        public Result Save(ERPDTOBase obj)
        {
            AccountGroupDTO accountGroup = obj as AccountGroupDTO;
            return new AccountGroupDAL().Save(accountGroup);
        }

        public DataTable GetAccountGroupList()
        {
            return new AccountGroupDAL().GetAccountGroupList();
        }

        //public DataTable DeleteAccountGroupList()
        //{
        //    return new AccountGroupDAL().DeleteAccountGroupList();
        //}

        public DataTable MastersListing()
        {
            return new AccountGroupDAL().MastersListing();
        }

        public Result Delete(int id)
        {
            return new AccountGroupDAL().Delete(id);
        }
    }
}
    