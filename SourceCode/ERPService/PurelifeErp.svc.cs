using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using ERPDTO.Masters;
using ERPBL.Masters;    
using System.Data;
using ERPDTO;

namespace ERPService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    public class PurelifeErp : IPurelifeErp
    {
        public Result Save(PageName page, ERPDTOBase objIERPDO)
        {
            switch (page)
            {
                case PageName.AccountGroup:
                    return new AccountGroupBL().Save(objIERPDO);

                case PageName.ItemGroup:
                    return new ItemGroupBL().Save(objIERPDO);

                case PageName.Account:
                    return new AccountBL().Save(objIERPDO);

                case PageName.Item:
                    return new ItemBL().Save(objIERPDO);

                case PageName.PartyWiseItemRate:
                    return new PartyWiseItemRateBL().Save(objIERPDO);

                case PageName.SaleOrderReceivingEntryDET:
                    return new SaleOrderReceivingEntryBL().Save(objIERPDO);

                case PageName.SaleOrderReceivingEntryMST:
                    return new SaleOrderReceivingEntryBL().SaveSaleOrderReceivingEntryDTOMst(objIERPDO);

                case PageName.MSTPurchaseBill:
                    return new PurchaseBillBL().SaveMSTPurchaseBill(objIERPDO);

                case PageName.DETPurchaseBill:
                    return new PurchaseBillBL().SaveDETPurchaseBill(objIERPDO);

                case PageName.DETDirectEntry:
                    return new DirectEntryBL().SaveDETPurchaseBill(objIERPDO);

                case PageName.MSTDirectEntry:
                    return new DirectEntryBL().SaveMSTPurchaseBill(objIERPDO);

                case PageName.UMO:
                    return new UMOBL().Save(objIERPDO);

                case PageName.Dept:
                    return new DepartmentBL().Save(objIERPDO);

                case PageName.Desig:
                    return new DesignationBl().Save(objIERPDO);

                case PageName.SoftwareRole:
                    return new SoftwareRoleBL().Save(objIERPDO);

                case PageName.Location:
                    return new LocationBL().Save(objIERPDO);

                case PageName.UserDetails:
                    return new UserDetailsBL().Save(objIERPDO);

                case PageName.MSTIssueMaster:
                    return new IssueMasterBL().SaveMSTIssueUser(objIERPDO);

                case PageName.DETIssueMaster:
                    return new IssueMasterBL().SaveDETIssueUser(objIERPDO);

                case PageName.MSTGRN:
                    return new GRNBL().SaveMST(objIERPDO);

                case PageName.DETGRN :
                    return new GRNBL().SaveDET(objIERPDO);

                default:
                    return null;
            }
        }

        //Data for Master  
        public DataTable DataListing(PageName page)
        {

            switch (page)
            {
                //case PageName.AccountGroup:
                //    return new AccountGroupBL().GetAccountGroupList();

                case PageName.ItemGroup:
                    return new ItemGroupBL().GetItemGroupList();

                case PageName.Account:
                    return new AccountBL().GetAccountList();

                case PageName.Item:
                    return new ItemBL().GetItemList();

                case PageName.PartyWiseItemRate:
                    return new PartyWiseItemRateBL().GetPartyWiseItemRateList();

                case PageName.SaleOrderReceivingEntryDET:
                    return new SaleOrderReceivingEntryBL().DETGetSaleOrderReceivingDetail();

                case PageName.SaleOrderReceivingEntryMST:
                    return new SaleOrderReceivingEntryBL().MSTGetSaleOrderReceivingDetail();

                case PageName.MSTPurchaseBill:
                    return new PurchaseBillBL().GetMSTPurchaseBillDetail();

                case PageName.MSTDirectEntry:
                    return new DirectEntryBL().GetMSTPurchaseBillDetail();

                case PageName.UMO:
                    return new UMOBL().GetUMOList();

                case PageName.Desig:
                    return new DesignationBl().GetMstDesigGetList();

                case PageName.Dept:
                    return new DepartmentBL().GetMstDeptGetList();

                case PageName.SoftwareRole:
                    return new SoftwareRoleBL().GetMstSoftwareRoleGetList();

                case PageName.Location:
                    return new LocationBL().GetLocationGetList();

                case PageName.UserDetails:
                    return new UserDetailsBL().GetUserDetails();

                case PageName.MSTIssueMaster:
                    return new IssueMasterBL().GetMSTIssueMasterList();

                default:
                    return null;
            }
        }

        //Data for Master  
        public DataTable DataListingWithSearch(PageName page, Search search)
        {
            switch (page)
            {
                case PageName.MSTPurchaseBill:
                    return new PurchaseBillBL().GetMSTPurchaseBillDetail(search);
                default:
                    return null;

            }
        }


        //Data for Details
        public DataTable DETDataListing(PageName page, Search search)
        {
            switch (page)
            {

                case PageName.DETPurchaseBill:
                    return new PurchaseBillBL().GetDETPurchaseBillDetail(search);

                case PageName.DETDirectEntry:
                    return new DirectEntryBL().GetDETPurchaseBillDetail(search);

                case PageName.DETIssueMaster:
                    return new IssueMasterBL().GetDETIssueMasterList(search);
                default:
                    return null;
            }
        }

        // ddl for master data like item etc 
        public DataTable MastersListing(PageName page)
        {
            switch (page)
            {
                //case PageName.AccountGroup:
                //    return new AccountGroupBL().MastersListing();

                case PageName.ItemGroup:
                    return new ItemGroupBL().MastersListing();

                case PageName.Account:
                    return new AccountBL().MastersListing();

                case PageName.Item:
                    return new ItemBL().MastersListing();

                case PageName.PartyWiseItemRate:
                    return new PartyWiseItemRateBL().MastersListing();

                case PageName.SaleOrderReceivingEntryMST:
                    return new SaleOrderReceivingEntryBL().MastersListing();

                case PageName.DETPurchaseBill:
                    return new PurchaseBillBL().MastersListing();

                case PageName.ItemDescp:
                    return new PurchaseBillBL().MastersListing();

                case PageName.UMO:
                    return new UMOBL().MastersListing();

                case PageName.Location:
                    return new LocationBL().MastersListing();

                case PageName.SoftwareRole:
                    return new SoftwareRoleBL().MastersListing();

                case PageName.Dept:
                    return new DepartmentBL().MastersListing();

                case PageName.Desig:
                    return new DesignationBl().MastersListing();

                case PageName.MSTIssueMaster:
                    return new IssueMasterBL().MastersListing();

                default:
                    return null;
            }
        }

        public Result Delete(PageName page, int id)
        {
            switch (page)
            {
                case PageName.Account:
                    return new AccountBL().Delete(id);
                case PageName.Item:
                    return new ItemBL().Delete(id);
                //case PageName.AccountGroup:
                //    return new AccountGroupBL().Delete(id);
                case PageName.ItemGroup:
                    return new ItemGroupBL().Delete(id);
                case PageName.PartyWiseItemRate:
                    return new PartyWiseItemRateBL().Delete(id);
                case PageName.SaleOrderReceivingEntryMST:
                    return new SaleOrderReceivingEntryBL().Delete(id);
                case PageName.MSTPurchaseBill:
                    return new PurchaseBillBL().Delete(id);

                case PageName.MSTDirectEntry:
                    return new DirectEntryBL().Delete(id);

                case PageName.UMO:
                    return new UMOBL().Delete(id);

                case PageName.Dept:
                    return new DepartmentBL().Delete(id);

                case PageName.SoftwareRole:
                    return new SoftwareRoleBL().Delete(id);

                case PageName.Desig:
                    return new DesignationBl().Delete(id);

                case PageName.Location:
                    return new LocationBL().Delete(id);


                case PageName.UserDetails:
                    return new UserDetailsBL().Delete(id);

                case PageName.MSTIssueMaster:
                    return new IssueMasterBL().Delete(id);

                //case PageName.DETIssueMaster:
                //    return new IssueMasterBL().Delete(id);
                default:
                    return null;
            }
        }

        public Result UserLogin(PageName page, string Username, string Password)
        {
            switch (page)
            {
                case PageName.MSTUserDetails:
                    return new UserLoginBL().UserLogin(Username, Password);

            }
            return null;
        }

    }
}
