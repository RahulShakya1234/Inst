using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ERPDTO.Masters;
using System.Data.Common;
using System.Data;
using ERPDTO;
using Common;


namespace ERPBL.Masters
{
    public class GRNDAL
    {
        public Result SaveMSTGRN(MSTGRNDTO oMSTGRNDTO)
        {
            try
            {
                using (DbCommand cmd = ERPDAL.Common.dbConn.GetStoredProcCommand("MSTGRNBillSave"))
                {
                    ERPDAL.Common.dbConn.AddInParameter(cmd, "@Id", DbType.Int32, oMSTGRNDTO.Id);
                    ERPDAL.Common.dbConn.AddInParameter(cmd, "@SupplierName", DbType.Int32, oMSTGRNDTO.SupplierName);
                    ERPDAL.Common.dbConn.AddInParameter(cmd, "@DCBillInvoiceNo", DbType.String, oMSTGRNDTO.DCBillInvoiceNo);
                    ERPDAL.Common.dbConn.AddInParameter(cmd, "@MDCBillInvoiceDate", DbType.DateTime, oMSTGRNDTO.DcBillInvoiceDate);
                    ERPDAL.Common.dbConn.AddInParameter(cmd, "@GRNNo", DbType.String, oMSTGRNDTO.GRNNo);
                    ERPDAL.Common.dbConn.AddInParameter(cmd, "@GRNDate", DbType.DateTime, oMSTGRNDTO.GRNDate);
                    ERPDAL.Common.dbConn.AddInParameter(cmd, "@LLRRWayBillNo", DbType.String, oMSTGRNDTO.LLRRWayBillNo);
                    ERPDAL.Common.dbConn.AddInParameter(cmd, "@LLRRWayBillDate", DbType.DateTime, oMSTGRNDTO.LLRRWayBillDate);
                    ERPDAL.Common.dbConn.AddInParameter(cmd, "@PONo", DbType.String, oMSTGRNDTO.PONo);
                    ERPDAL.Common.dbConn.AddInParameter(cmd, "@PODate", DbType.DateTime, oMSTGRNDTO.PODate);
                    ERPDAL.Common.dbConn.AddInParameter(cmd, "@Prepared", DbType.String, oMSTGRNDTO.Prepared);
                    ERPDAL.Common.dbConn.AddInParameter(cmd, "@StoreIncharge", DbType.String, oMSTGRNDTO.StoreIncharge);
                    ERPDAL.Common.dbConn.AddInParameter(cmd, "@MaterialManager", DbType.String, oMSTGRNDTO.MaterialManager);
                    ERPDAL.Common.dbConn.AddInParameter(cmd, "@PostedIntoStockBy", DbType.String, oMSTGRNDTO.PostedIntoStockBy);
                    DataSet dsResult = ERPDAL.Common.dbConn.ExecuteDataSet(cmd);
                    Result res = new Result { Id = ((dsResult.Tables[0].Rows[0]["Result"])).ToInt(), Message = "Saved", ResultStatus = OperationStatus.SavedSuccessFully };
                   res.Message = res.Id.ToString();
                   return res;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public Result SaveDETGRN(DETGRNDTO oDETGRNDTO)
        {
            try
            {
                using (DbCommand cmd = ERPDAL.Common.dbConn.GetStoredProcCommand("DETGRNBillSave"))
                {
                    ERPDAL.Common.dbConn.AddInParameter(cmd, "@Id", DbType.Int32, oDETGRNDTO.Id);
                    ERPDAL.Common.dbConn.AddInParameter(cmd, "@SNo", DbType.Int32, oDETGRNDTO.SNo);
                    ERPDAL.Common.dbConn.AddInParameter(cmd, "@MaterialDescId", DbType.Int32, oDETGRNDTO.MaterialDesc);
                    ERPDAL.Common.dbConn.AddInParameter(cmd, "@UnitCodeId", DbType.Int32, oDETGRNDTO.UnitCode);
                    ERPDAL.Common.dbConn.AddInParameter(cmd, "@DC", DbType.Double, oDETGRNDTO.DC);
                    ERPDAL.Common.dbConn.AddInParameter(cmd, "@Recieved", DbType.Double, oDETGRNDTO.Recieved);
                    ERPDAL.Common.dbConn.AddInParameter(cmd, "@AcceptedIntoStock", DbType.Double, oDETGRNDTO.AcceptedIntoStock);
                    ERPDAL.Common.dbConn.AddInParameter(cmd, "@MaterialCheckingSlipNo", DbType.String, oDETGRNDTO.MaterialCheckingSlipNo);
                    ERPDAL.Common.dbConn.AddInParameter(cmd, "@Value", DbType.Double, oDETGRNDTO.Value);
                    DataSet dsResult = ERPDAL.Common.dbConn.ExecuteDataSet(cmd);
                   // return new  Result { Id = ((dsResult.Tables[0].Rows[0]["Result"])).ToInt(),Message="Saved", ResultStatus = OperationStatus.SavedSuccessFully };
                    return new Result { Id = 1, Message = "Saved", ResultStatus = OperationStatus.SavedSuccessFully };

                }




            }
            catch (Exception ex)
            {
                throw ex;
            }
         
        }


    }
}
