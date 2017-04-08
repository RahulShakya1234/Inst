using System.Text;
using ERPDTO;
using ERPDTO.Masters;
using ERPDAL;
using ERPDAL.Masters;
using System.Data;

namespace ERPBL.Masters
{
    public class SaleOrderReceivingEntryBL
    {

        public Result Save(ERPDTOBase obj)
        {
            SaleOrderReceivingEntryDTO account = obj as SaleOrderReceivingEntryDTO;
            return new SaleOrderReceivingEntryDAL().Save(account);
        }

        public Result SaveSaleOrderReceivingEntryDTOMst(ERPDTOBase obj)
        {
            MSTSaleOrderReceivingEntryDTO account = obj as MSTSaleOrderReceivingEntryDTO;
            return new SaleOrderReceivingEntryDAL().SaveSaleOrderReceivingEntryDTOMst(account);
        }

        public DataTable MSTGetSaleOrderReceivingDetail()
        {
            return new SaleOrderReceivingEntryDAL().MSTGetSaleOrderReceivingDetail();
        }

        public DataTable DETGetSaleOrderReceivingDetail()
        {
            return new SaleOrderReceivingEntryDAL().DETGetSaleOrderReceivingDetail();
        }
        public DataTable MastersListing()
        {
            return new SaleOrderReceivingEntryDAL().MastersListing();
        }

        public Result Delete(int id)
        {
            return new SaleOrderReceivingEntryDAL().Delete(id);
        }
    }
}
