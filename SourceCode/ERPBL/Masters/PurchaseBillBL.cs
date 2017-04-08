using System.Text;
using ERPDTO;
using ERPDTO.Masters;
using ERPDAL;
using ERPDAL.Masters;
using System.Data;

namespace ERPBL.Masters
{
    public class PurchaseBillBL
    {
        public Result SaveMSTPurchaseBill(ERPDTOBase obj)
        {
            MSTPurchaseBillDTO oMSTPurchaseBillDTO = obj as MSTPurchaseBillDTO;
            return new PurchaseBillDAL().SaveMSTPurchaseBill(oMSTPurchaseBillDTO);
        }
        
        public Result SaveDETPurchaseBill(ERPDTOBase obj)
        {
            DETPurchaseBillDTO oDETPurchaseBillDTO = obj as DETPurchaseBillDTO;
            return new PurchaseBillDAL().SaveDETPurchaseBill(oDETPurchaseBillDTO);
        }



        public DataTable GetDETPurchaseBillDetail(Search search)
        {
            return new PurchaseBillDAL().GetDETPurchaseBillDetail(search);
        }
        //public DataTable GetDETPurchaseBillDetail()
        //{
        //    return new PurchaseBillDAL().GetDETPurchaseBillDetail(search);
        //}

        public DataTable GetMSTPurchaseBillDetail( )
        {
            return new PurchaseBillDAL().GetMSTPurchaseBillDetail();
        }

        public DataTable GetMSTPurchaseBillDetail(Search search)
        {
            return new PurchaseBillDAL().GetMSTPurchaseBillDetail(search);
        }



        public DataTable MastersListing()
        {
            return new PurchaseBillDAL().MastersListing();
        }

        public Result Delete(int id)
        {
            return new PurchaseBillDAL().Delete(id);
        }
    }
}
