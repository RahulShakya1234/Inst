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
    public class PartyWiseItemRateDAL
    {
        public Result Save(PartyWiseItemRateDTO obj)
        {
            try
            {
                using (DbCommand cmd = Common.dbConn.GetStoredProcCommand("DETPartyWiseItemRateAdd"))
                {
                    Common.dbConn.AddInParameter(cmd, "Id", DbType.Int32, obj.Id);
                    Common.dbConn.AddInParameter(cmd, "AccountGroupMasId", DbType.Int32, obj.PartyName);
                    Common.dbConn.AddInParameter(cmd, "ItemName", DbType.String, obj.ItemName);
                    Common.dbConn.AddInParameter(cmd, "ItemCode", DbType.Int32, obj.ItemCode);
                    Common.dbConn.AddInParameter(cmd, "PackingRate", DbType.Double, obj.PackingRate);
                    Common.dbConn.AddInParameter(cmd, "PONo", DbType.String, obj.PONo);
                    Common.dbConn.AddInParameter(cmd, "AmendmentNo", DbType.Int32, obj.AmendmentNo);
                    if (obj.PODate == DateTime.MinValue)
                    {
                        Common.dbConn.AddInParameter(cmd, "PODate", DbType.Date, System.DBNull.Value);
                    }
                    else
                    {
                        Common.dbConn.AddInParameter(cmd, "PODate", DbType.Date, obj.PODate);
                    }
                    if (obj.AmendmentDate==DateTime.MinValue)
                    {
                        Common.dbConn.AddInParameter(cmd, "AmendmentDate", DbType.Date,System.DBNull.Value );
                    }
                    else
                    {
                        Common.dbConn.AddInParameter(cmd, "AmendmentDate", DbType.Date, obj.AmendmentDate);
                    }

                    Common.dbConn.AddInParameter(cmd, "PartNo", DbType.String, obj.PartNo);
                    Common.dbConn.AddInParameter(cmd, "ToolSupplyForQty", DbType.Double, obj.ToolSupplyForQty);
                    Common.dbConn.AddInParameter(cmd, "ToolRate", DbType.Double, obj.ToolRate);
                    Common.dbConn.AddInParameter(cmd, "Tax", DbType.Double, obj.Tax);
                    Common.dbConn.AddInParameter(cmd, "ToolNarr", DbType.String, obj.ToolNarr);
                    Common.dbConn.AddInParameter(cmd, "ProcessName", DbType.String, obj.ProcessName);

                    Common.dbConn.ExecuteNonQuery(cmd);
                    return new Result { Id = 1, Message = "Saved", ResultStatus = OperationStatus.SavedSuccessFully };
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable GetPartyWiseItemRateList()
        {
            try
            {
                using (DbCommand cmd = Common.dbConn.GetStoredProcCommand("MSTPartyWiseItemGet"))
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
                using (DbCommand cmd = Common.dbConn.GetStoredProcCommand("MSTAccountNameList"))
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
                using (DbCommand cmd = Common.dbConn.GetStoredProcCommand("MSTPartyWiseItemDelete"))
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
