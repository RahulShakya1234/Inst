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
    public class PurchaseBillDAL
    {
        //public int MSTSaleOrderReceivingEntryId { get; set; }

        public Result SaveMSTPurchaseBill(MSTPurchaseBillDTO oMSTPurchaseBillDTO)
        {
            try
            {
                // DataSet ds = SqlHelper.ExecuteDataset(trans, CommandType.StoredProcedure, "InsertUpdatePreShipmentMaster", sqlParameter);
                using (DbCommand cmd = Common.dbConn.GetStoredProcCommand("MSTPurchaseBillSave"))
                {
                    Common.dbConn.AddInParameter(cmd, "@Id", DbType.Int32, oMSTPurchaseBillDTO.Id);
                    Common.dbConn.AddInParameter(cmd, "@SerialBillNo", DbType.String, oMSTPurchaseBillDTO.SerialBillNo);
                    Common.dbConn.AddInParameter(cmd, "@BillNo", DbType.String, oMSTPurchaseBillDTO.BillNo);
                    Common.dbConn.AddInParameter(cmd, "@Supplier", DbType.Int32, oMSTPurchaseBillDTO.Supplier);
                    Common.dbConn.AddInParameter(cmd, "@Narration", DbType.String, oMSTPurchaseBillDTO.Narration);

                    if (oMSTPurchaseBillDTO.Entrydate == DateTime.MinValue)
                    {
                        Common.dbConn.AddInParameter(cmd, "@Entrydate", DbType.Date, System.DBNull.Value);
                    }
                    else
                    {
                        Common.dbConn.AddInParameter(cmd, "@Entrydate", DbType.Date, oMSTPurchaseBillDTO.Entrydate.ToString("dd/MM/yyyy"));
                    }

                    if (oMSTPurchaseBillDTO.BillDate == DateTime.MinValue)
                    {
                        Common.dbConn.AddInParameter(cmd, "@BillDate", DbType.Date, System.DBNull.Value);
                    }
                    else
                    {
                        Common.dbConn.AddInParameter(cmd, "@BillDate", DbType.Date, oMSTPurchaseBillDTO.BillDate.Date.ToString("dd/MM/yyyy"));
                    }
                    Common.dbConn.AddInParameter(cmd, "@PurchaseCategy", DbType.Int32, oMSTPurchaseBillDTO.PurchaseCategy);
                    Common.dbConn.AddInParameter(cmd, "@PurchaseType", DbType.Int32, oMSTPurchaseBillDTO.PurchaseType);
                    Common.dbConn.AddInParameter(cmd, "@AccountGroupMasId", DbType.Int32, oMSTPurchaseBillDTO.PurchaseAcc);
                    Common.dbConn.AddInParameter(cmd, "@ExciseDuty", DbType.Double, oMSTPurchaseBillDTO.ExciseDuty);
                    Common.dbConn.AddInParameter(cmd, "@Cess", DbType.Double, oMSTPurchaseBillDTO.Cess);
                    Common.dbConn.AddInParameter(cmd, "@HECess", DbType.Double, oMSTPurchaseBillDTO.HECess);
                    Common.dbConn.AddInParameter(cmd, "@AddExcise", DbType.Boolean, oMSTPurchaseBillDTO.AddExcise);
                    Common.dbConn.AddInParameter(cmd, "@ExciseReg", DbType.Double, oMSTPurchaseBillDTO.ExciseReg);
                    Common.dbConn.AddInParameter(cmd, "@ExciseNo", DbType.Double, oMSTPurchaseBillDTO.ExciseNo);
                    Common.dbConn.AddInParameter(cmd, "@Transport", DbType.String, oMSTPurchaseBillDTO.Transport);
                    Common.dbConn.AddInParameter(cmd, "@Carrier", DbType.String, oMSTPurchaseBillDTO.Carrier);
                    Common.dbConn.AddInParameter(cmd, "@Remarks", DbType.String, oMSTPurchaseBillDTO.Remarks);
                    Common.dbConn.AddInParameter(cmd, "@TotalAmount", DbType.Double, oMSTPurchaseBillDTO.TotalAmount);
                    Common.dbConn.AddInParameter(cmd, "@SaleTax", DbType.Double, oMSTPurchaseBillDTO.SaleTax);
                    Common.dbConn.AddInParameter(cmd, "@SurchargeTax", DbType.Double, oMSTPurchaseBillDTO.SurchargeTax);
                    Common.dbConn.AddInParameter(cmd, "@BillAmount", DbType.Double, oMSTPurchaseBillDTO.BillAmount);
                    Common.dbConn.AddInParameter(cmd, "@MakeIssueToProductionBill", DbType.Boolean, oMSTPurchaseBillDTO.MakeIssueToProductionBill);
                    Common.dbConn.AddInParameter(cmd, "@PackingForwarding", DbType.String, oMSTPurchaseBillDTO.PackingForwarding);
                    Common.dbConn.AddInParameter(cmd, "@friegthInsurance", DbType.String, oMSTPurchaseBillDTO.Freightnsurance);
                    Common.dbConn.AddInParameter(cmd, "@Type", DbType.Int16, oMSTPurchaseBillDTO.Type);

                    DataSet dsResult = Common.dbConn.ExecuteDataSet(cmd);

                    Result res = new Result { Id = ((dsResult.Tables[0].Rows[0]["Result"])).ToInt(), ResultStatus = OperationStatus.SavedSuccessFully };
                    //res.Message = GetSno(res.Id);
                    res.Message = res.Id.ToString();

                    using (DbCommand cmdUpdateSno = Common.dbConn.GetStoredProcCommand("UpdatePurchaseBillSno"))
                    {
                        Common.dbConn.AddInParameter(cmdUpdateSno, "@PurchaseBillId", DbType.Int32, res.Id);
                        Common.dbConn.AddInParameter(cmdUpdateSno, "@SerialBillNo", DbType.String, res.Message);
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
        private static string GetSno(int no)
        {
            int i = 5 - no.ToString().Length;
            return string.Format("PB/{0}-{1}", DateTime.Now.Year.ToString().Substring(2, 2), DateTime.Now.Year.ToString().Substring(2, 2) + 1) + new string('0', i) + no.ToString();
        }

        public Result SaveDETPurchaseBill(DETPurchaseBillDTO oDETPurchaseBillDTO)
        {
            try
            {
                // PurchaseBillId
                //sessionState.SetCachedValue(privateKey, {some integer value});


                using (DbCommand cmd = Common.dbConn.GetStoredProcCommand("DETPurchaseBillSave"))
                {
                    Common.dbConn.AddInParameter(cmd, "@MSTPurchaseBillId", DbType.Int32, oDETPurchaseBillDTO.Id);
                    Common.dbConn.AddInParameter(cmd, "@SNo", DbType.Int32, oDETPurchaseBillDTO.SNo);
                    Common.dbConn.AddInParameter(cmd, "@MaterialDesc", DbType.Int32, oDETPurchaseBillDTO.MaterialDesc);
                    Common.dbConn.AddInParameter(cmd, "@UMO", DbType.Int32, oDETPurchaseBillDTO.UMOId);
                    Common.dbConn.AddInParameter(cmd, "@Qty", DbType.Double, oDETPurchaseBillDTO.Qty);
                    Common.dbConn.AddInParameter(cmd, "@Rate", DbType.Double, oDETPurchaseBillDTO.Rate);
                    Common.dbConn.AddInParameter(cmd, "@DiscPerc", DbType.Double, oDETPurchaseBillDTO.DiscPerc);
                    Common.dbConn.AddInParameter(cmd, "@DicsAmount", DbType.Double, oDETPurchaseBillDTO.DicsAmount);
                    Common.dbConn.AddInParameter(cmd, "@ExciseDuty", DbType.Double, oDETPurchaseBillDTO.ExciseDuty);
                    Common.dbConn.AddInParameter(cmd, "@ECess", DbType.Double, oDETPurchaseBillDTO.ECess);
                    Common.dbConn.AddInParameter(cmd, "@HECessPerc", DbType.Double, oDETPurchaseBillDTO.HECessPerc);
                    Common.dbConn.AddInParameter(cmd, "@HECessAmount", DbType.Double, oDETPurchaseBillDTO.HECessAmount);
                    Common.dbConn.AddInParameter(cmd, "@Tariff", DbType.String, oDETPurchaseBillDTO.Tariff);


                    if (oDETPurchaseBillDTO.InvoiceDate == DateTime.MinValue)
                    {
                        Common.dbConn.AddInParameter(cmd, "@InvoiceDate", DbType.Date, System.DBNull.Value);
                    }
                    else
                    {
                        Common.dbConn.AddInParameter(cmd, "@InvoiceDate", DbType.Date, oDETPurchaseBillDTO.InvoiceDate);
                    }
                    if (oDETPurchaseBillDTO.ETADate == DateTime.MinValue)
                    {
                        Common.dbConn.AddInParameter(cmd, "@ETADate", DbType.Date, System.DBNull.Value);
                    }
                    else
                    {
                        Common.dbConn.AddInParameter(cmd, "@ETADate", DbType.Date, oDETPurchaseBillDTO.ETADate);
                    }
                    Common.dbConn.AddInParameter(cmd, "@Specs", DbType.String, oDETPurchaseBillDTO.Specs);
                    Common.dbConn.AddInParameter(cmd, "@TotalAmount", DbType.Double, oDETPurchaseBillDTO.TotalAmount);
                    Common.dbConn.AddInParameter(cmd, "@CVDAmount", DbType.Double, oDETPurchaseBillDTO.CVDAmount);

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



        public DataTable GetDETPurchaseBillDetail(Search obj)
        {
            try
            {
                
                using (DbCommand cmd = Common.dbConn.GetStoredProcCommand("DETPurchaseBillGetList"))
                {
                    Common.dbConn.AddInParameter(cmd, "MSTPurchaseBillId", DbType.Int32, obj.Id);
                    DataTable ds = Common.dbConn.ExecuteDataSet(cmd).Tables[0];
                    return ds;  //Common.dbConn.ExecuteDataSet(cmd).Tables[0];
                }
            }
            catch (Exception ex)
            {
                throw ex;
                return null;
            }

        }

        public DataTable GetMSTPurchaseBillDetail()
        {
            try
            {
                using (DbCommand cmd = Common.dbConn.GetStoredProcCommand("MSTPurchaseBillGetList"))
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

        public DataTable GetMSTPurchaseBillDetail(Search search)
        {
            try
            {
                using (DbCommand cmd = Common.dbConn.GetStoredProcCommand("MSTPurchaseBillGetList"))
                {
                    Common.dbConn.AddInParameter(cmd, "@Type", DbType.Int32, search.Type);
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

        public Result UpDateSno(string Sno, int id)
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


        // public DbType MSTSaleOrderReceivingEntryId { get; set; }

        // public DbType MSTSaleOrderReceivingEntryId { get; set; }
    }
}
