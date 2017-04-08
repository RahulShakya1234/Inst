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
    public class AccountBL
    {
        public Result Save(ERPDTOBase obj)
        {
            AccountDTO account = obj as AccountDTO;
            return new AccountDAL().Save(account);
        }

        public DataTable GetAccountList()
        {
            return new AccountDAL().GetAccountList();
        }

        public DataTable MastersListing()
        {
            return new AccountDAL().MastersListing();
        }

        public Result Delete(int id)
        {
            return new AccountDAL().Delete(id);
        }
    }
}
