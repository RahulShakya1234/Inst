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
    public class UMOBL
    {

        public Result Save(ERPDTOBase obj)
        {
            UMODTO accountGroup = obj as UMODTO;
            return new UMODAL().Save(accountGroup);
        }

        public DataTable GetUMOList()
        {
            return new UMODAL().GetUMOList();
        }

        //public DataTable DeleteAccountGroupList()
        //{
        //    return new AccountGroupDAL().DeleteAccountGroupList();
        //}
        public DataTable MastersListing()
        {
            return new UMODAL().MastersListing();
        }

       
        public Result Delete(int id)
        {
            return new UMODAL().Delete(id);
        }
    }
}
