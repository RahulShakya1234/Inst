using System.Text;
using ERPDTO;
using ERPDTO.Masters;
using ERPDAL;
using ERPDAL.Masters;
using System.Data;


namespace ERPBL.Masters
{
  public  class IssueMasterBL
    {
      public Result SaveDETIssueUser(ERPDTOBase obj)
      {
          DETIssueUserDTO account = obj as DETIssueUserDTO;
          return new IssueMasterDAL().SaveDETIssueUser(account);
      }

      public Result SaveMSTIssueUser(ERPDTOBase obj)
        {
            MSTIssueMasterDTO account = obj as MSTIssueMasterDTO;
            return new IssueMasterDAL().SaveMSTIssueUser(account);
        }

        public DataTable GetDETIssueMasterList(Search search)
        {
            return new IssueMasterDAL().GetDETIssueMasterList(search);
        }
        //public DataTable GetDETPurchaseBillDetail()
        //{
        //    return new PurchaseBillDAL().GetDETPurchaseBillDetail(search);
        //}

        public DataTable GetMSTIssueMasterList()
        {
            return new IssueMasterDAL().GetMSTIssueMasterList();
        }
        public DataTable MastersListing()
        {
            return new IssueMasterDAL().MastersListing();
        }

        public Result Delete(int id)
        {
            return new IssueMasterDAL().Delete(id);
        }

    }
}
