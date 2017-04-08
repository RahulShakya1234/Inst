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
    public class ItemGroupBL
    {
        public Result Save(ERPDTOBase obj)
        {
            ItemGroupDTO ItemGrp = obj as ItemGroupDTO;
            return new ItemGroupDAL().Save(ItemGrp);
        }

        public DataTable GetItemGroupList()
        {
            return new ItemGroupDAL().GetItemGroupList();
        }

        public DataTable MastersListing()
        {
            return new ItemGroupDAL().MastersListing();
        }

        public Result Delete(int id)
        {
            return new ItemGroupDAL().Delete(id);
        }
    }
}
