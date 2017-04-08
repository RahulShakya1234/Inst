using System.Text;
using ERPDTO;
using ERPDTO.Masters;
using ERPDAL;
using ERPDAL.Masters;
using System.Data;


namespace ERPBL.Masters
{
  public  class DirectEntryDL
    {
        public Result SaveDETPurchaseBill(ERPDTOBase obj)
        {
            return null;
            //DETDirectEntryDTO account = obj as DETDirectEntryDTO;
            //return new DirectEntryDAL().SaveDETPurchaseBill(account);
        }

        public Result SaveMSTPurchaseBill(ERPDTOBase obj)
        {
            return null;
            //MSTDirectEntryDTO account = obj as MSTDirectEntryDTO;
            //return new DirectEntryDAL().SaveMSTPurchaseBill(account);
        }

        public DataTable GetDETPurchaseBillDetail(Search search)
        {
            return null;
            //return new DirectEntryDAL().GetDETPurchaseBillDetail(search);
        }
        //public DataTable GetDETPurchaseBillDetail()
        //{
        //    return new PurchaseBillDAL().GetDETPurchaseBillDetail(search);
        //}

        public DataTable GetMSTPurchaseBillDetail()
        {
            return null;
            //return new DirectEntryDAL().GetMSTPurchaseBillDetail();
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
