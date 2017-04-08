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
  public  class SaleOrderReceivingEntryDAL
    {
      public Result SaveSaleOrderReceivingEntryDTOMst(MSTSaleOrderReceivingEntryDTO obj)
      {
          try
          {
              using (DbCommand cmd = Common.dbConn.GetStoredProcCommand("MSTSaleOrderReceivingSave"))
              {
                  Common.dbConn.AddInParameter(cmd, "ID", DbType.Int32, obj.Id);
                  Common.dbConn.AddInParameter(cmd, "OrderNo", DbType.String, obj.OrderNo);
                  if (obj.OrderDate == DateTime.MinValue)
                  {
                      Common.dbConn.AddInParameter(cmd, "OrderDate", DbType.Date, System.DBNull.Value);
                  }
                  else
                  {
                      Common.dbConn.AddInParameter(cmd, "OrderDate", DbType.Date, obj.OrderDate);
                  }

                  Common.dbConn.AddInParameter(cmd, "PartyName", DbType.Int32, obj.PartyName);
                  Common.dbConn.AddInParameter(cmd, "Remarks", DbType.String, obj.Remarks);
                  Common.dbConn.AddInParameter(cmd, "Active", DbType.Boolean, obj.Active);
                  Common.dbConn.AddInParameter(cmd, "Total", DbType.Double, obj.Total);
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
        public Result Save(SaleOrderReceivingEntryDTO obj)
        {
            try
            {
                int MSTSaleOrderReceivingEntryId = 0;
                using (DbCommand cmd = Common.dbConn.GetStoredProcCommand("DETSaleOrderReceivingDetail"))
                {
                    Common.dbConn.AddInParameter(cmd, "MSTSaleOrderReceivingEntryId", DbType.Int32, obj.Id);
                    //Common.dbConn.AddInParameter(cmd, "OrderNo", DbType.String, obj.OrderNo);
                    //if (obj.OrderDate == DateTime.MinValue)
                    //{
                    //    Common.dbConn.AddInParameter(cmd, "OrderDate", DbType.Date, System.DBNull.Value);
                    //}
                    //else
                    //{
                    //    Common.dbConn.AddInParameter(cmd, "OrderDate", DbType.Date, obj.OrderDate);
                    //}

                    //Common.dbConn.AddInParameter(cmd, "PartyName", DbType.String, obj.PartyName);
                    //Common.dbConn.AddInParameter(cmd, "Active", DbType.Boolean, obj.Active);
                    //Common.dbConn.AddInParameter(cmd, "Remarks", DbType.String, obj.Remarks);
                    Common.dbConn.AddInParameter(cmd, "SNo", DbType.Int32, obj.SNo);
                    Common.dbConn.AddInParameter(cmd, "ItemMasId", DbType.Int32, obj.ItemDescription);
                    Common.dbConn.AddInParameter(cmd, "Qty", DbType.Double, obj.Qty);
                    Common.dbConn.AddInParameter(cmd, "Rate", DbType.Double, obj.Rate);
                    Common.dbConn.AddInParameter(cmd, "Amount", DbType.Double, obj.Amount);
                    //Common.dbConn.AddInParameter(cmd, "Total", DbType.Double, obj.Total);
                    Common.dbConn.ExecuteNonQuery(cmd);
                    return new Result { Id = 1, Message = "Saved", ResultStatus = OperationStatus.SavedSuccessFully };
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        public DataTable MSTGetSaleOrderReceivingDetail()
        {
            try
            {
                using (DbCommand cmd = Common.dbConn.GetStoredProcCommand("MSTSaleOrderReceivingListGet"))
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

        public DataTable DETGetSaleOrderReceivingDetail()
        {
            try
            {
                using (DbCommand cmd = Common.dbConn.GetStoredProcCommand("DETSaleOrderReceivingListGet"))
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

      //public Result Save(DETPurchaseBillDTO obj)
      //  {
      //      try
      //      { 
      //         int MSTSaleOrderReceivingEntryId=0;
      //         using (DbCommand cmd = Common.dbConn.GetStoredProcCommand("DETPurchaseBillSave"))
      //          {
      //              //Common.dbConn.AddInParameter(cmd, "@MSTPurchaseBillId", DbType.Int32, MSTSaleOrderReceivingEntryId);
      //              //Common.dbConn.AddInParameter(cmd, "OrderNo", DbType.String, obj.OrderNo);
      //              //if (obj.OrderDate == DateTime.MinValue)
      //              //{
      //              //    Common.dbConn.AddInParameter(cmd, "OrderDate", DbType.Date, System.DBNull.Value);
      //              //}
      //              //else
      //              //{
      //              //    Common.dbConn.AddInParameter(cmd, "OrderDate", DbType.Date, obj.OrderDate);
      //              //}
                   
      //              //Common.dbConn.AddInParameter(cmd, "PartyName", DbType.String, obj.PartyName);
      //              //Common.dbConn.AddInParameter(cmd, "Active", DbType.Boolean, obj.Active);
      //              //Common.dbConn.AddInParameter(cmd, "Remarks", DbType.String, obj.Remarks);
      //              Common.dbConn.AddInParameter(cmd, "@SNo", DbType.Int32, obj.SNo);
      //              Common.dbConn.AddInParameter(cmd, "@MaterialDesc", DbType.Int32, obj.MaterialDesc);
      //              Common.dbConn.AddInParameter(cmd, "@Qty", DbType.Double, obj.Qty);
      //              Common.dbConn.AddInParameter(cmd, "@Rate", DbType.Double, obj.Rate);
      //              Common.dbConn.AddInParameter(cmd, "@DiscPerc", DbType.Double, obj.DiscPerc);
      //              Common.dbConn.AddInParameter(cmd, "@DicsAmount", DbType.Int32, obj.DicsAmount);
      //              Common.dbConn.AddInParameter(cmd, "@ExciseDuty", DbType.Double, obj.ExciseDuty);
      //              Common.dbConn.AddInParameter(cmd, "@ECess", DbType.Double, obj.ECess);
      //              Common.dbConn.AddInParameter(cmd, "@HECessPerc", DbType.Double, obj.HECessPerc);
      //              Common.dbConn.AddInParameter(cmd, "@HECessAmount", DbType.Int32, obj.HECessAmount);
      //              Common.dbConn.AddInParameter(cmd, "@Tariff", DbType.Double, obj.Tariff);

      //              if (obj.InvoiceDate == DateTime.MinValue)
      //              {
      //                  Common.dbConn.AddInParameter(cmd, "@InvoiceDate", DbType.Double, obj.InvoiceDate);
      //              }
      //              else
      //              {
      //                  Common.dbConn.AddInParameter(cmd, "@Entrydate", DbType.Date, obj.InvoiceDate);
      //              }
      //              if (obj.ETADate == DateTime.MinValue)
      //              {
      //                  Common.dbConn.AddInParameter(cmd, "@ETADate", DbType.Double, obj.ETADate);
      //              }
      //              else
      //              {
      //                  Common.dbConn.AddInParameter(cmd, "@ETADate", DbType.Date, obj.ETADate);
      //              }
      //              Common.dbConn.AddInParameter(cmd, "@Specs", DbType.Int32, obj.Specs);
      //              Common.dbConn.AddInParameter(cmd, "@TotalAmount", DbType.Double, obj.Specs);
      //              Common.dbConn.AddInParameter(cmd, "@CVDAmount", DbType.Double, obj.CVDAmount);
                   
                    
                    
      //              Common.dbConn.ExecuteNonQuery(cmd);
      //              return new Result { Id = 1, Message = "Saved", ResultStatus = OperationStatus.SavedSuccessFully };
      //          }
      //      }
      //      catch (Exception ex)
      //      {
      //          throw ex;
      //      }
      //  }

      //public Result Save2(MSTPurchaseBillDTO obj)
      //{
      //    try
      //    {
      //        using (DbCommand cmd = Common.dbConn.GetStoredProcCommand("MSTPurchaseBillSave"))
      //        {
      //            Common.dbConn.AddInParameter(cmd, "@Id", DbType.Int32, obj.Id);
      //            Common.dbConn.AddInParameter(cmd, "@SerialBillNo", DbType.String, obj.SerialBillNo);
      //            Common.dbConn.AddInParameter(cmd, "@BillNo", DbType.String, obj.BillNo);
      //            Common.dbConn.AddInParameter(cmd, "@Supplier", DbType.Int32, obj.Supplier);
      //            Common.dbConn.AddInParameter(cmd, "@Narration", DbType.String, obj.Narration);
               
      //            if (obj.Entrydate == DateTime.MinValue)
      //            {
      //                Common.dbConn.AddInParameter(cmd, "@Entrydate", DbType.Date, System.DBNull.Value);
      //            }
      //            else
      //            {
      //                Common.dbConn.AddInParameter(cmd, "@Entrydate", DbType.Date, obj.Entrydate);
      //            }

      //            if (obj.BillDate == DateTime.MinValue)
      //            {
      //                Common.dbConn.AddInParameter(cmd, "@BillDate", DbType.Date, System.DBNull.Value);
      //            }
      //            else
      //            {
      //                Common.dbConn.AddInParameter(cmd, "@BillDate", DbType.Date, obj.BillDate);
      //            }

      //            Common.dbConn.AddInParameter(cmd, "@PurchaseCategy", DbType.Int32, obj.PurchaseCategy);
      //            Common.dbConn.AddInParameter(cmd, "@PurchaseType", DbType.Int32, obj.PurchaseType);
      //            Common.dbConn.AddInParameter(cmd, "@PurchaseAcc", DbType.Int32, obj.PurchaseAcc);
      //            Common.dbConn.AddInParameter(cmd, "@ExciseDuty", DbType.Double, obj.ExciseDuty);

      //            Common.dbConn.AddInParameter(cmd, "@Cess", DbType.Double, obj.Cess);
      //            Common.dbConn.AddInParameter(cmd, "@HECess", DbType.Double, obj.HECess);
      //            Common.dbConn.AddInParameter(cmd, "@AddExcise", DbType.Boolean, obj.AddExcise);
      //            Common.dbConn.AddInParameter(cmd, "@ExciseReg", DbType.Double, obj.ExciseReg);

      //            Common.dbConn.AddInParameter(cmd, "@ExciseNo", DbType.Double, obj.ExciseNo);
      //            Common.dbConn.AddInParameter(cmd, "@Transport", DbType.String, obj.Transport);
      //            Common.dbConn.AddInParameter(cmd, "@Carrier", DbType.String, obj.Carrier);
      //            Common.dbConn.AddInParameter(cmd, "@Remarks", DbType.String, obj.Remarks);

      //            Common.dbConn.AddInParameter(cmd, "@TotalAmount", DbType.Double, obj.TotalAmount);
      //            Common.dbConn.AddInParameter(cmd, "@SaleTax", DbType.Double, obj.SaleTax);
      //            Common.dbConn.AddInParameter(cmd, "@SurchargeTax", DbType.Double, obj.SurchargeTax);
      //            Common.dbConn.AddInParameter(cmd, "@BillAmount", DbType.Double, obj.BillAmount);
      //            Common.dbConn.AddInParameter(cmd, "@MakeIssueToProductionBill", DbType.Boolean, obj.MakeIssueToProductionBill);
      //            Common.dbConn.ExecuteNonQuery(cmd);
      //            return new Result { Id = 1, Message = "Saved", ResultStatus = OperationStatus.SavedSuccessFully };
      //        }
      //    }
      //    catch (Exception ex)
      //    {
      //        throw ex;
      //    }
      //}

      //public DataTable GetSaleOrderReceivingDetail()
      //  {
      //      try
      //      {
      //          using (DbCommand cmd = Common.dbConn.GetStoredProcCommand("MSTPurchaseBillListGet"))
      //          {
      //              DataSet dsResult = Common.dbConn.ExecuteDataSet(cmd);

      //              if (dsResult.Tables.Count > 0 && dsResult.Tables[0].Rows.Count > 0)
      //              {
      //                  return dsResult.Tables[0];
      //              }
      //          }
      //      }
      //      catch (Exception ex)
      //      {
      //          throw ex;
      //      }
      //      return null;
      //  }

      //public DataTable GetSaleOrderReceivingDetail2()
      //{
      //    try
      //    {
      //        using (DbCommand cmd = Common.dbConn.GetStoredProcCommand("DETPurchaseBillListGet"))
      //        {
      //            DataSet dsResult = Common.dbConn.ExecuteDataSet(cmd);

      //            if (dsResult.Tables.Count > 0 && dsResult.Tables[0].Rows.Count > 0)
      //            {
      //                return dsResult.Tables[0];
      //            }
      //        }
      //    }
      //    catch (Exception ex)
      //    {
      //        throw ex;
      //    }
      //    return null;
      //}

      //  public DataTable MastersListing()
      //  {
      //      try
      //      {
      //          using (DbCommand cmd = Common.dbConn.GetStoredProcCommand("MSTAccountNameList"))
      //          {
      //              DataSet dsResult = Common.dbConn.ExecuteDataSet(cmd);

      //              if (dsResult.Tables.Count > 0 && dsResult.Tables[0].Rows.Count > 0)
      //              {
      //                  return dsResult.Tables[0];
      //              }
      //          }
      //      }
      //      catch (Exception ex)
      //      {
      //          throw ex;
      //      }
      //      return null;
      //  }

      //  //public Result Delete(int id)
      //  //{
      //  //    try
      //  //    {
      //  //        using (DbCommand cmd = Common.dbConn.GetStoredProcCommand("MSTPartyWiseItemDelete"))
      //  //        {
      //  //            Common.dbConn.AddInParameter(cmd, "Id", DbType.Int32, id);
      //  //            Common.dbConn.ExecuteNonQuery(cmd);
      //  //            return new Result { Id = 1, Message = "Deleted Successfully", ResultStatus = OperationStatus.DeletedSuccessFully };
      //  //        }
      //  //    }
      //  //    catch (Exception ex)
      //  //    {
      //  //        throw ex;
      //  //    }
      //  //}
    }
}
