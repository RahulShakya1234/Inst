using System.Text;
using ERPDTO;
using ERPDTO.Masters;
using ERPDAL;
using ERPDAL.Masters;
using System.Data;


namespace ERPBL.Masters
{
  public  class DirectEntryBL
    {
        public Result SaveDETPurchaseBill(ERPDTOBase obj)
        {
            DETDirectEntryDTO account = obj as DETDirectEntryDTO;
            return new DirectEntryDAL().SaveDETDirectEntry(account);
        }

        public Result SaveMSTPurchaseBill(ERPDTOBase obj)
        {
            MSTDirectEntryDTO account = obj as MSTDirectEntryDTO;
            return new DirectEntryDAL().SaveMSTDirectEntry(account);
        }

        public DataTable GetDETDirectEntryDetail(Search search)
        {
            return new DirectEntryDAL().GetDETDirectEntryDetail(search);
        }
        public DataTable GetDETPurchaseBillDetail(Search search)
        {
            return new PurchaseBillDAL().GetDETPurchaseBillDetail(search);
        }

        public DataTable GetMSTPurchaseBillDetail()
        {
            return new DirectEntryDAL().GetMSTDirectEntryDetail();
        }
        public DataTable MastersListing()
        {
            return new DirectEntryDAL().MastersListing();
        }

        public Result Delete(int id)
        {
            return new DirectEntryDAL().Delete(id);
        }

    }
}
