using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using ERPDTO;
using System.Data;

namespace ERPService
{
    // [ServiceContract] and [OperationContract]are included in System.ServiceModel namespace.
    //NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IPurelifeErp
    {   

        [OperationContract]
        Result Save(PageName page, ERPDTOBase objIERPDO);

        [OperationContract]
        DataTable DataListing(PageName page);

        [OperationContract]
        DataTable DataListingWithSearch(PageName page, Search search);


        [OperationContract]
        DataTable DETDataListing(PageName page, Search search);

        [OperationContract]
        DataTable MastersListing(PageName page );



        [OperationContract]
        Result Delete(PageName page, int id);

        [OperationContract]
        Result UserLogin(PageName page, string Username, string Password);

    }


   
}
