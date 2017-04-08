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
    public class AccountGroupDAL
    {

        public Result Save(AccountGroupDTO obj)
        {
            try
            {
                using (DbCommand cmd = Common.dbConn.GetStoredProcCommand("MSTAccountGroupSave"))
                {
                    Common.dbConn.AddInParameter(cmd, "Id", DbType.Int32, obj.Id);
                    Common.dbConn.AddInParameter(cmd, "AccountGroupName", DbType.String, obj.AccountGroupName);
                    Common.dbConn.AddInParameter(cmd, "PrimaryAccountGroup", DbType.Int32, obj.PrimaryAccountGroup);
                    Common.dbConn.AddInParameter(cmd, "RefrenceNo", DbType.Int32, obj.RefrenceNo);
                    Common.dbConn.AddInParameter(cmd, "BType", DbType.String, obj.BType);
                    Common.dbConn.AddInParameter(cmd, "Type", DbType.Int16, obj.GType);
                    Common.dbConn.AddInParameter(cmd, "PrintSummaryBalType", DbType.Int16, obj.PrintSummaryTrialBalType);
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

        public DataTable GetAccountGroupList()
        {
            try
            {
                using (DbCommand cmd = Common.dbConn.GetStoredProcCommand("MstAccountGroupListGet"))
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
                using (DbCommand cmd = Common.dbConn.GetStoredProcCommand("MSTAccountGroupDelete"))
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

        public DataTable MastersListing()
        {
            try
            {
                using (DbCommand cmd = Common.dbConn.GetStoredProcCommand("MSTAccountGroupList"))
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
    }
}
