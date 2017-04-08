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
   public class ItemDAL
    {
        public Result Save(ItemDTO obj)
        {
            try
            {
                using (DbCommand cmd = Common.dbConn.GetStoredProcCommand("MSTItemSave"))
                {
                    Common.dbConn.AddInParameter(cmd, "Id", DbType.Int32, obj.Id);
                    Common.dbConn.AddInParameter(cmd, "DisplayName", DbType.String, obj.DisplayName);

                    Common.dbConn.AddInParameter(cmd, "AliasItemCode", DbType.String, obj.AliasItemCode);
                    Common.dbConn.AddInParameter(cmd, "PrintDescription", DbType.String, obj.PrintDescription);
                    Common.dbConn.AddInParameter(cmd, "BasicUnit", DbType.Double, obj.BasicUnit);
                    Common.dbConn.AddInParameter(cmd, "Package", DbType.String, obj.Package);
                    Common.dbConn.AddInParameter(cmd, "ItemGroupMasId", DbType.Int32, obj.GroupName);
                    Common.dbConn.AddInParameter(cmd, "SaleRate", DbType.Double, obj.SaleRate);
                    Common.dbConn.AddInParameter(cmd, "PurchaseRate", DbType.Double, obj.PurchaseRate);
                    Common.dbConn.AddInParameter(cmd, "ExportRate", DbType.Double, obj.ExportRate);
                    Common.dbConn.AddInParameter(cmd, "StockRate", DbType.Double, obj.StockRate);
                    Common.dbConn.AddInParameter(cmd, "RT12Code", DbType.Int32, obj.RT12Code);
                    Common.dbConn.AddInParameter(cmd, "MRP", DbType.Double, obj.MRP);
                    Common.dbConn.AddInParameter(cmd, "MRPRate", DbType.Double, obj.MRPRate);
                    Common.dbConn.AddInParameter(cmd, "PlatingRate", DbType.Double, obj.PlatingRate);
                    Common.dbConn.AddInParameter(cmd, "Value", DbType.Double, obj.Value);
                    Common.dbConn.AddInParameter(cmd, "TraiffNo", DbType.String, obj.TraiffNo);
                    Common.dbConn.AddInParameter(cmd, "Active", DbType.Boolean, obj.Active);
                    Common.dbConn.AddInParameter(cmd, "TaxableItem", DbType.Boolean, obj.TaxableItem);
                    Common.dbConn.AddInParameter(cmd, "ExciseRegister", DbType.Int32, obj.ExciseRegister);
                    Common.dbConn.AddInParameter(cmd, "ItemType", DbType.Int32, obj.ItemType);
                    Common.dbConn.AddInParameter(cmd, "NonExciseStock", DbType.Double, obj.NonExciseStock);
                    Common.dbConn.AddInParameter(cmd, "ExciseRG1Stock", DbType.Double, obj.ExciseRG1Stock);
                    Common.dbConn.AddInParameter(cmd, "ExciseRG23AStock", DbType.Double, obj.ExciseRG23AStock);
                    Common.dbConn.AddInParameter(cmd, "ExciseRG23CStock", DbType.Double, obj.ExciseRG23CStock);
                    Common.dbConn.AddInParameter(cmd, "TotalStock", DbType.Double, obj.TotalStock);
                    Common.dbConn.AddInParameter(cmd, "MinQuantity", DbType.Double, obj.MinQuantity);
                    Common.dbConn.AddInParameter(cmd, "MaxQty", DbType.Double, obj.MaxQty);
                    Common.dbConn.AddInParameter(cmd, "ReOrderLevel", DbType.Double, obj.ReOrderLevel);
                    Common.dbConn.AddInParameter(cmd, "NetWeight", DbType.Double, obj.NetWeight);
                    Common.dbConn.AddInParameter(cmd, "CutWeight", DbType.Double, obj.CutWeight);
                    Common.dbConn.AddInParameter(cmd, "GrossWeight", DbType.Double, obj.GrossWeight);
                    Common.dbConn.AddInParameter(cmd, "Length", DbType.Double, obj.Length);
                    Common.dbConn.AddInParameter(cmd, "Width", DbType.Double, obj.Width);
                    Common.dbConn.AddInParameter(cmd, "BinPackageQty", DbType.Double, obj.BinPackageQty);
                    Common.dbConn.AddInParameter(cmd, "FreeQtyBin", DbType.Double, obj.FreeQtyBin);
                    Common.dbConn.AddInParameter(cmd, "AlternateUnit", DbType.Double, obj.AlternateUnit);
                    Common.dbConn.AddInParameter(cmd, "ConversionFormule1", DbType.String, obj.ConversionFormule1);
                    Common.dbConn.AddInParameter(cmd, "ConversionFormule2", DbType.String, obj.ConversionFormule2);
                    Common.dbConn.AddInParameter(cmd, "ItemSpecificationCode", DbType.Int32, obj.ItemSpecCode);

                    Common.dbConn.AddInParameter(cmd, "DescriptionForInvoice", DbType.String, obj.DescriptionForInvoice);
                    Common.dbConn.AddInParameter(cmd, "RackNo", DbType.String, obj.RackNo);
                    Common.dbConn.AddInParameter(cmd, "MakeMRNJwAuto", DbType.Boolean, obj.MakeMRNJwAuto);
                    Common.dbConn.AddInParameter(cmd, "ItemArea", DbType.Double, obj.ItemArea);
                    Common.dbConn.AddInParameter(cmd, "FileName", DbType.String, obj.FileName);

                    Common.dbConn.AddInParameter(cmd, "MinOrderQty", DbType.Double, obj.MinOrderQty);
                    Common.dbConn.AddInParameter(cmd, "LeadTime", DbType.Double, obj.LeadTime);
                    Common.dbConn.AddInParameter(cmd, "PackageType", DbType.Int32, obj.PackageType);
                    Common.dbConn.AddInParameter(cmd, "Code", DbType.String, obj.Code);
                    Common.dbConn.AddInParameter(cmd, "RawMaterialUsed", DbType.Int32, obj.RawMaterialUsed);
                    Common.dbConn.AddInParameter(cmd, "PriceListName", DbType.Int32, obj.PriceListName);
                    Common.dbConn.AddInParameter(cmd, "RateFactor1", DbType.Double, obj.RateFactor1);
                    Common.dbConn.AddInParameter(cmd, "RateFactor2", DbType.Double, obj.RateFactor2);
                    Common.dbConn.AddInParameter(cmd, "RateFactor3", DbType.Double, obj.RateFactor3);
                    Common.dbConn.AddInParameter(cmd, "RateFactor4", DbType.Double, obj.RateFactor4);
                    Common.dbConn.AddInParameter(cmd, "ProcessName", DbType.Int32, obj.ProcessName);
                    Common.dbConn.ExecuteNonQuery(cmd);
                    return new Result { Id = 1, Message = "Saved", ResultStatus = OperationStatus.SavedSuccessFully };
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable GetItemList()
        {
            try
            {
                using (DbCommand cmd = Common.dbConn.GetStoredProcCommand("MSTItemListGet"))
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
                using (DbCommand cmd = Common.dbConn.GetStoredProcCommand("MSTItemGorupList"))
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
                using (DbCommand cmd = Common.dbConn.GetStoredProcCommand("MSTItemDelete"))
                {
                    Common.dbConn.AddInParameter(cmd, "Id", DbType.Int32, id);
                    Common.dbConn.ExecuteNonQuery(cmd);
                    return new Result { Id = 2, Message = "Deleted Successfully", ResultStatus = OperationStatus.DeletedSuccessFully };
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }   
        }
    }
}
