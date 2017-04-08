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
    public class DesignationBl
    {

        public Result Save(ERPDTOBase obj)
        {
            DesignationDTO accountGroup = obj as DesignationDTO;
            return new DesignationDAL().Save(accountGroup);
        }

        public DataTable GetMstDesigGetList()
        {
            return new DesignationDAL().GetMstDesigGetList();
        }

        //public DataTable DeleteAccountGroupList()
        //{
        //    return new AccountGroupDAL().DeleteAccountGroupList();
        //}
        public DataTable MastersListing()
        {
            return new DesignationDAL().MastersListing();
        }

       
        public Result Delete(int id)
        {
            return new DesignationDAL().Delete(id);
        }
    }
}
