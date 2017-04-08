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
    public class SoftwareRoleBL
    {

        public Result Save(ERPDTOBase obj)
        {
            SoftwareRoleDTO accountGroup = obj as SoftwareRoleDTO;
            return new SoftwareRoleDAL().Save(accountGroup);
        }

        public DataTable GetMstSoftwareRoleGetList()
        {
            return new SoftwareRoleDAL().GetMstSoftwareRoleGetList();
        }

        //public DataTable DeleteAccountGroupList()
        //{
        //    return new AccountGroupDAL().DeleteAccountGroupList();
        //}
        public DataTable MastersListing()
        {
            return new SoftwareRoleDAL().MastersListing();
        }

       
        public Result Delete(int id)
        {
            return new SoftwareRoleDAL().Delete(id);
        }
    }
}
