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
    public class UserDetailsBL
    {

        public Result Save(ERPDTOBase obj)
        {
            UserDetailsDTO accountGroup = obj as UserDetailsDTO;
            return new UserDetailsDAL().Save(accountGroup);
        }

        public DataTable GetUserDetails()
        {
            return new UserDetailsDAL().GetUserDetails();
        }

        //public DataTable DeleteAccountGroupList()
        //{
        //    return new AccountGroupDAL().DeleteAccountGroupList();
        //}
        public DataTable MastersListing()
        {
            return new UserDetailsDAL().MastersListing();
        }

       
        public Result Delete(int id)
        {
            return new UserDetailsDAL().Delete(id);
        }
    }
}
