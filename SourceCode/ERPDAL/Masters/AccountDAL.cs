using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ERPDTO.Masters;
using System.Data.Common;
using System.Data;
using ERPDTO;
using Common;

namespace ERPDAL.Masters
{
   public class AccountDAL
    {

       public Result Save(AccountDTO obj)
            {
            try
            {
                using (DbCommand cmd = Common.dbConn.GetStoredProcCommand("MSTAccountSave"))
                {
                    Common.dbConn.AddInParameter(cmd, "Id", DbType.Int32, obj.Id);
                    Common.dbConn.AddInParameter(cmd, "AccountName", DbType.String, obj.Account);
                   // Common.dbConn.AddInParameter(cmd, "GroupName", DbType.Int32, obj.GroupName);
                    Common.dbConn.AddInParameter(cmd, "AccountGroupMasId", DbType.Int32, obj.GroupName);
                    Common.dbConn.AddInParameter(cmd, "AccType", DbType.Int32, obj.AccountType);
                    Common.dbConn.AddInParameter(cmd, "STypeCode", DbType.Int32, obj.SaleType);
                    Common.dbConn.AddInParameter(cmd, "State", DbType.Int32, obj.State);
                    Common.dbConn.AddInParameter(cmd, "PTypeCode", DbType.Int32, obj.PurchaseType);
                    Common.dbConn.AddInParameter(cmd, "Balance", DbType.Double, obj.Balance);
                    Common.dbConn.AddInParameter(cmd, "BalanceType", DbType.Int32, obj.DrCr);
                    Common.dbConn.AddInParameter(cmd, "Address", DbType.String, obj.Address);
                    Common.dbConn.AddInParameter(cmd, "MobileNo", DbType.Int32, obj.MobileNo);
                    Common.dbConn.AddInParameter(cmd, "EMail", DbType.String, obj.Email);
                    Common.dbConn.AddInParameter(cmd, "RegistratnNo", DbType.String, obj.Registration);
                    Common.dbConn.AddInParameter(cmd, "PLACodeNo", DbType.String, obj.PLACodeNo);
                    Common.dbConn.AddInParameter(cmd, "Commodity", DbType.String, obj.Commodity);
                    Common.dbConn.AddInParameter(cmd, "Range", DbType.String, obj.PanNo);
                    Common.dbConn.AddInParameter(cmd, "Division", DbType.String, obj.Division);
                    Common.dbConn.AddInParameter(cmd, "Collectorate", DbType.String, obj.Collactorate);
                    Common.dbConn.AddInParameter(cmd, "PanNo", DbType.String, obj.PanNo);
                    Common.dbConn.AddInParameter(cmd, "CSTNo", DbType.String, obj.CSTNo);
                    Common.dbConn.AddInParameter(cmd, "TinSTNo", DbType.String, obj.STNo);
                    Common.dbConn.AddInParameter(cmd, "ECCNo", DbType.String, obj.ECCNo);
                    Common.dbConn.AddInParameter(cmd, "CreditDays", DbType.String, obj.CreditDays);
                    Common.dbConn.AddInParameter(cmd, "AdjBillWise", DbType.Boolean, obj.AdjBillWise);
                    Common.dbConn.AddInParameter(cmd, "TDSCategory", DbType.String, obj.TDSRate);
                    Common.dbConn.AddInParameter(cmd, "TDSRate", DbType.String, obj.TDSCategory);
                    Common.dbConn.AddInParameter(cmd, "LockAccount", DbType.Boolean, obj.LockAcc);
                    Common.dbConn.AddInParameter(cmd, "ModeofTransport", DbType.String, obj.ModeofTransport);
                    Common.dbConn.AddInParameter(cmd, "NatureofPay", DbType.String, obj.NatureofPay);
                    Common.dbConn.AddInParameter(cmd, "VenderCode", DbType.String, obj.VenderCode);
                    Common.dbConn.AddInParameter(cmd, "typeOfSupplier", DbType.Int32, obj.TypeOfSupplier);
                    Common.dbConn.AddInParameter(cmd, "Country", DbType.String, obj.Country);
                    Common.dbConn.AddInParameter(cmd, "Destination", DbType.String, obj.Destination);
                    Common.dbConn.AddInParameter(cmd, "Fax", DbType.String, obj.Fax);
                    Common.dbConn.AddInParameter(cmd, "CodeNo", DbType.String, obj.CodeNo);
                    Common.dbConn.AddInParameter(cmd, "Discount", DbType.String, obj.Discount);
                    Common.dbConn.AddInParameter(cmd, "TypeofCustomer", DbType.Int32, obj.CustomerType);
                    Common.dbConn.AddInParameter(cmd, "Location", DbType.String, obj.Location);
                    Common.dbConn.AddInParameter(cmd, "InterestRate", DbType.String, obj.IntrestRate);
                    Common.dbConn.AddInParameter(cmd, "Active", DbType.Boolean, obj.Active);
                    Common.dbConn.ExecuteNonQuery(cmd);
                    return new Result { Id = 1, Message = "Saved", ResultStatus = OperationStatus.SavedSuccessFully };
                }
            }
            catch (Exception exception)
            {
                ErrorLog.LogErrorInTxtFormat(exception);
            }
            return null;

        }

        public DataTable GetAccountList()
        {
            try
            {
                using (DbCommand cmd = Common.dbConn.GetStoredProcCommand("MstAccountListGet"))
                {
                    DataSet dsResult = Common.dbConn.ExecuteDataSet(cmd);

                    if (dsResult.Tables.Count > 0 && dsResult.Tables[0].Rows.Count > 0)
                    {
                        return dsResult.Tables[0];
                    }
                }
            }
            catch (Exception exception)
            {
                ErrorLog.LogErrorInTxtFormat(exception);
            }
            return null;
        }

        public DataTable MastersListing()
        {
            try
            {
                using (DbCommand cmd = Common.dbConn.GetStoredProcCommand("MSTAccountNameList"))
                {
                    DataSet dsResult = Common.dbConn.ExecuteDataSet(cmd);

                    if (dsResult.Tables.Count > 0 && dsResult.Tables[0].Rows.Count > 0)
                    {
                        return dsResult.Tables[0];
                    }
                }
            }
            catch (Exception exception)
            {
                ErrorLog.LogErrorInTxtFormat(exception);
            }
            return null;
        }

        public Result Delete(int id)
        {
            try
            {
                using (DbCommand cmd = Common.dbConn.GetStoredProcCommand("MSTAccountAddDelete"))
                {
                    Common.dbConn.AddInParameter(cmd, "Id", DbType.Int32, id);
                    Common.dbConn.ExecuteNonQuery(cmd);
                    return new Result { Id = 1, Message = "Deleted Successfully", ResultStatus = OperationStatus.DeletedSuccessFully };
                }
            }
            catch (Exception exception)
            {
                ErrorLog.LogErrorInTxtFormat(exception);
            }
            return null;
        }

    }
}
