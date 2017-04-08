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
    public class LocationBL
    {

        public Result Save(ERPDTOBase obj)
        {
            LocationDTO accountGroup = obj as LocationDTO;
            return new LocationDAL().Save(accountGroup);
        }

        public DataTable GetLocationGetList()
        {
            return new LocationDAL().GetLocationGetList();
        }

        //public DataTable DeleteAccountGroupList()
        //{
        //    return new AccountGroupDAL().DeleteAccountGroupList();
        //}
        public DataTable MastersListing()
        {
            return new LocationDAL().MastersListing();
        }

       
        public Result Delete(int id)
        {
            return new LocationDAL().Delete(id);
        }
    }
}
