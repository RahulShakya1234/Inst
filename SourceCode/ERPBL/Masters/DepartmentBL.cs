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
    public class DepartmentBL
    {

        public Result Save(ERPDTOBase obj)
        {
            DeptDTO accountGroup = obj as DeptDTO;
            return new DeptDAL().Save(accountGroup);
        }

        public DataTable GetMstDeptGetList()
        {
            return new DeptDAL().GetMstDeptGetList();
        }

        //public DataTable DeleteAccountGroupList()
        //{
        //    return new AccountGroupDAL().DeleteAccountGroupList();
        //}
        public DataTable MastersListing()
        {
            return new DeptDAL().MastersListing();
        }

       
        public Result Delete(int id)
        {
            return new DeptDAL().Delete(id);
        }
    }
}
