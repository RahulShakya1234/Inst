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
  public  class DirectEntryDAL
    {

      public Result SaveMSTDirectEntry(MSTDirectEntryDTO obj)
        {
            try
            {
                // DataSet ds = SqlHelper.ExecuteDataset(trans, CommandType.StoredProcedure, "InsertUpdatePreShipmentMaster", sqlParameter);
                using (DbCommand cmd = Common.dbConn.GetStoredProcCommand("MSTPurchaseBillSave"))
                {
                    Common.dbConn.AddInParameter(cmd, "@Id", DbType.Int32, obj.Id);
                    Common.dbConn.AddInParameter(cmd, "@SerialBillNo", DbType.String, obj.SerialBillNo);
                    Common.dbConn.AddInParameter(cmd, "@BillNo", DbType.String, obj.BillNo);
                    //Common.dbConn.AddInParameter(cmd, "@Supplier", DbType.Int32, obj.Supplier);
                    Common.dbConn.AddInParameter(cmd, "@Narration", DbType.String, obj.Narration);

                    if (obj.Entrydate == DateTime.MinValue)
                    {
                        Common.dbConn.AddInParameter(cmd, "@Entrydate", DbType.Date, System.DBNull.Value);
                    }
                    else
                    {
                        Common.dbConn.AddInParameter(cmd, "@Entrydate", DbType.Date, obj.Entrydate);
                    }

                    if (obj.BillDate == DateTime.MinValue)
                    {
                        Common.dbConn.AddInParameter(cmd, "@BillDate", DbType.Date, System.DBNull.Value);
                    }
                    else
                    {
                        Common.dbConn.AddInParameter(cmd, "@BillDate", DbType.Date, obj.BillDate);
                    }

                    Common.dbConn.AddInParameter(cmd, "@PurchaseCategy", DbType.Int32, obj.PurchaseCategy);
                    Common.dbConn.AddInParameter(cmd, "@PurchaseType", DbType.Int32, obj.PurchaseType);
                    Common.dbConn.AddInParameter(cmd, "@AccountGroupMasId", DbType.Int32, obj.PurchaseAcc);
                    Common.dbConn.AddInParameter(cmd, "@TotalAmount", DbType.Decimal, obj.TotalAmount);
                    Common.dbConn.AddInParameter(cmd ,"@Type" ,DbType.Int16 ,1);

                   // Common.dbConn.AddInParameter(cmd, "@ExciseDuty", DbType.Double, obj.ExciseDuty);

                   
                    //Common.dbConn.ExecuteNonQuery(cmd);

                    DataSet dsResult = Common.dbConn.ExecuteDataSet(cmd);
                    return new Result { Id = ((dsResult.Tables[0].Rows[0]["Result"])).ToInt(), Message = "Saved", ResultStatus = OperationStatus.SavedSuccessFully };
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


      public Result SaveDETDirectEntry(DETDirectEntryDTO obj)
        {
            try
            {
                // PurchaseBillId
                //sessionState.SetCachedValue(privateKey, {some integer value});


                using (DbCommand cmd = Common.dbConn.GetStoredProcCommand("DETPurchaseBillSave"))
                {
                    Common.dbConn.AddInParameter(cmd, "@MSTPurchaseBillId", DbType.Int32, obj.Id);
                    Common.dbConn.AddInParameter(cmd, "@SNo", DbType.Int32, obj.SNo);
                    Common.dbConn.AddInParameter(cmd, "@MaterialDesc", DbType.Int32, obj.MaterialDesc);
                    Common.dbConn.AddInParameter(cmd, "@UMO", DbType.Int32, obj.UMOId);
                    Common.dbConn.AddInParameter(cmd, "@Qty", DbType.Double, obj.Qty);
                    Common.dbConn.AddInParameter(cmd, "@Rate", DbType.Double, obj.Rate);
                    Common.dbConn.AddInParameter(cmd, "@TotalAmount", DbType.Double, obj.TotalAmount);
                    Common.dbConn.ExecuteNonQuery(cmd);
                    return new Result { Id = 1, Message = "Saved", ResultStatus = OperationStatus.SavedSuccessFully };
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return null;
        }


        public DataTable GetDETDirectEntryDetail(Search obj)
        {
            try
            {
                using (DbCommand cmd = Common.dbConn.GetStoredProcCommand("DETPurchaseBillGetList"))
                {
                    Common.dbConn.AddInParameter(cmd, "MSTPurchaseBillId", DbType.Int32, obj.Id);
                    return Common.dbConn.ExecuteDataSet(cmd).Tables[0];
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return null;
        }


        public DataTable GetMSTDirectEntryDetail()
        {
            try
            {
                using (DbCommand cmd = Common.dbConn.GetStoredProcCommand("MSTPurchaseBillGetList"))
                {
                    Common.dbConn.AddInParameter(cmd, "@Type", DbType.Int32, 1);
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
                using (DbCommand cmd = Common.dbConn.GetStoredProcCommand("MSTItemDescList"))
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
                using (DbCommand cmd = Common.dbConn.GetStoredProcCommand("MSTPurchaseBillDelete"))
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
