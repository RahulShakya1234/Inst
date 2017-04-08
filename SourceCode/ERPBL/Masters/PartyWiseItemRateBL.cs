using System.Text;
using ERPDTO;
using ERPDTO.Masters;
using ERPDAL;
using ERPDAL.Masters;
using System.Data;

namespace ERPBL.Masters
{
    public class PartyWiseItemRateBL
    {
        public Result Save(ERPDTOBase obj)
        {
            PartyWiseItemRateDTO account = obj as PartyWiseItemRateDTO;
            return new PartyWiseItemRateDAL().Save(account);
        }

        public DataTable GetPartyWiseItemRateList()
        {
            return new PartyWiseItemRateDAL().GetPartyWiseItemRateList();
        }

        public DataTable MastersListing()
        {
            return new PartyWiseItemRateDAL().MastersListing();
        }

        public Result Delete(int id)
        {
            return new PartyWiseItemRateDAL().Delete(id);
        }
    }
}
