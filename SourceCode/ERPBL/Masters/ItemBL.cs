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
    public class ItemBL
    {
        public Result Save(ERPDTOBase obj)
        {
            ItemDTO item = obj as ItemDTO;
            return new ItemDAL().Save(item);
        }

        public DataTable GetItemList()
        {
            return new ItemDAL().GetItemList();
        }

        public DataTable MastersListing()
        {
            return new ItemDAL().MastersListing();
        }

        public Result Delete(int id)
        {
            return new ItemDAL().Delete(id);
        }
    }
}
