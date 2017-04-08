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
    public class ItemGroupDAL
    {
        public Result Save(ItemGroupDTO obj)
        {
            try
            {
                using (DbCommand cmd = Common.dbConn.GetStoredProcCommand("MSTItemGroupSave"))
                {
                    Common.dbConn.AddInParameter(cmd, "Id", DbType.Int32, obj.Id);
                    Common.dbConn.AddInParameter(cmd, "ItemGroupName", DbType.String, obj.ItemGroupName);
                    Common.dbConn.AddInParameter(cmd, "UpperGroup", DbType.Int32, obj.UpperGroup);
                    Common.dbConn.AddInParameter(cmd, "Prefix", DbType.String, obj.Prefix);
                    Common.dbConn.AddInParameter(cmd, "SalableItemGrp", DbType.Boolean, obj.SalableItemGrp);
                    Common.dbConn.AddInParameter(cmd, "AutomaticQC", DbType.Boolean, obj.AutomaticQC);
                    Common.dbConn.AddInParameter(cmd, "AutoAssemblyFromRGP", DbType.Boolean, obj.AutoAssemlyfromRGP);
                    Common.dbConn.AddInParameter(cmd, "AutoMrn", DbType.Boolean, obj.AutoMRN);
                    Common.dbConn.AddInParameter(cmd, "POReqInMRN", DbType.Boolean, obj.PORequiredinMRN);
                    Common.dbConn.AddInParameter(cmd, "ShowInWorkerOrder", DbType.Boolean, obj.ShowinWorkerOrder);
                    Common.dbConn.AddInParameter(cmd, "MakeAutoProdEntry", DbType.Boolean, obj.MakeAutoProductionEntry);
                    Common.dbConn.AddInParameter(cmd, "ScheduleNoRequiredinMRN", DbType.Boolean, obj.ScheduleNoRequiredinMRN);

                    Common.dbConn.ExecuteNonQuery(cmd);
                    return new Result { Id = 1, Message = "Saved", ResultStatus = OperationStatus.SavedSuccessFully };
                }
            }
            catch (Exception ex)
            {   
                throw ex;
            }
        }

        public DataTable GetItemGroupList()
        {
            try
            {
                using (DbCommand cmd = Common.dbConn.GetStoredProcCommand("MstItemGroupListGet"))
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
                using (DbCommand cmd = Common.dbConn.GetStoredProcCommand("MSTItemGroupList"))
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
                using (DbCommand cmd = Common.dbConn.GetStoredProcCommand("MSTItemGroupDelete"))
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
