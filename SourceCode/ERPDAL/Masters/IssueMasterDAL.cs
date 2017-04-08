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
    public class IssueMasterDAL
    {

        public Result SaveMSTIssueUser(MSTIssueMasterDTO obj)
        {
            try
            {
                // DataSet ds = SqlHelper.ExecuteDataset(trans, CommandType.StoredProcedure, "InsertUpdatePreShipmentMaster", sqlParameter);
                using (DbCommand cmd = Common.dbConn.GetStoredProcCommand("MSTIssueMasterSave"))
                {
                    Common.dbConn.AddInParameter(cmd, "@OrderId", DbType.Int32, obj.Id);
                    Common.dbConn.AddInParameter(cmd, "@OrderNo", DbType.String, obj.OrderNo);
                    if (obj.Orderdate == DateTime.MinValue)
                    {
                        Common.dbConn.AddInParameter(cmd, "@Orderdate", DbType.Date, System.DBNull.Value);
                    }
                    else
                    {
                        Common.dbConn.AddInParameter(cmd, "@Orderdate", DbType.Date, obj.Orderdate);
                    }
                    Common.dbConn.AddInParameter(cmd, "@Remarks", DbType.String, obj.Remarks);
                    Common.dbConn.AddInParameter(cmd, "@IssueTo", DbType.Int32, obj.IssueTo);
                    // Common.dbConn.AddInParameter(cmd, "@ExciseDuty", DbType.Double, obj.ExciseDuty);
                    //Common.dbConn.ExecuteNonQuery(cmd);
                    DataSet dsResult = Common.dbConn.ExecuteDataSet(cmd);
                    Result res = new Result { Id = ((dsResult.Tables[0].Rows[0]["Result"])).ToInt(), Message = "Saved", ResultStatus = OperationStatus.SavedSuccessFully };
                    res.Message = res.Id.ToString();

                    using (DbCommand cmdUpdateSno = Common.dbConn.GetStoredProcCommand("UpdateOrderSno"))
                    {
                        Common.dbConn.AddInParameter(cmdUpdateSno, "@OrderId", DbType.Int32, res.Id);
                        Common.dbConn.AddInParameter(cmdUpdateSno, "@OrderNo", DbType.String, res.Message);
                        Common.dbConn.ExecuteNonQuery(cmdUpdateSno);
                    }

                    return res;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public Result SaveDETIssueUser(DETIssueUserDTO obj)
        {
            try
            {
                // PurchaseBillId
                //sessionState.SetCachedValue(privateKey, {some integer value});


                using (DbCommand cmd = Common.dbConn.GetStoredProcCommand("DETIssueMasterSave"))
                {
                    Common.dbConn.AddInParameter(cmd, "@MSTIssueUseId", DbType.Int32, obj.Id);
                    Common.dbConn.AddInParameter(cmd, "@SNo", DbType.Int32, obj.SNo);
                    Common.dbConn.AddInParameter(cmd, "@MaterialDesc", DbType.Int32, obj.MaterialDesc);
                    Common.dbConn.AddInParameter(cmd, "@UMO", DbType.Int32, obj.UMOId);
                    Common.dbConn.AddInParameter(cmd, "@Quantity", DbType.Double, obj.Qty);



                    Common.dbConn.ExecuteNonQuery(cmd);
                    return new Result { Id = 1, Message = "Saved", ResultStatus = OperationStatus.SavedSuccessFully };
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return null;
            //  }
        }


        public DataTable GetDETIssueMasterList(Search obj)
        {
            try
            {
                using (DbCommand cmd = Common.dbConn.GetStoredProcCommand("DETIssueMasterGetList"))
                {
                    Common.dbConn.AddInParameter(cmd, "MSTIssueMasterId", DbType.Int32, obj.Id);
                    return Common.dbConn.ExecuteDataSet(cmd).Tables[0];
                }
            }
            catch (Exception ex)
            {
                throw ex;

            }
            return null;
        }

        public DataTable GetMSTIssueMasterList()
        {
            try
            {
                using (DbCommand cmd = Common.dbConn.GetStoredProcCommand("MSTIssueMasterList"))
                {
                    DataSet dsResult = Common.dbConn.ExecuteDataSet(cmd);

                    if (dsResult.Tables.Count > 0 && dsResult.Tables[0].Rows.Count > 0)
                    {
                        return dsResult.Tables[0];
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return null;
        }

        public DataTable MastersListing()
        {
            try
            {
                using (DbCommand cmd = Common.dbConn.GetStoredProcCommand("MstIssueUserList"))
                {
                    DataSet dsResult = Common.dbConn.ExecuteDataSet(cmd);

                    if (dsResult.Tables.Count > 0 && dsResult.Tables[0].Rows.Count > 0)
                    {
                        return dsResult.Tables[0];
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return null;
        }

        public Result Delete(int id)
        {
            try
            {
                using (DbCommand cmd = Common.dbConn.GetStoredProcCommand("MSTIssueMasterDelete"))
                {
                    Common.dbConn.AddInParameter(cmd, "Id", DbType.Int32, id);
                    Common.dbConn.ExecuteNonQuery(cmd);
                    return new Result { Id = 1, Message = "Deleted Successfully", ResultStatus = OperationStatus.DeletedSuccessFully };
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
