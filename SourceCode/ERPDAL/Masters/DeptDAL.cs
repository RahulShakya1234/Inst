﻿using System;
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
    public class DeptDAL
    {
        public Result Save(DeptDTO obj)
        {
            try
            {
                using (DbCommand cmd = Common.dbConn.GetStoredProcCommand("MSTDeptSave"))
                {
                    Common.dbConn.AddInParameter(cmd, "Id", DbType.Int32, obj.Id);
                    Common.dbConn.AddInParameter(cmd, "Dept", DbType.String, obj.Dept);
                  
                    Common.dbConn.ExecuteNonQuery(cmd);
                    return new Result { Id = 1, Message = "Saved", ResultStatus = OperationStatus.SavedSuccessFully };
                }
            }
            catch (Exception exception)
            {
                throw exception;
            }
            return null;
        }

        public DataTable GetMstDeptGetList()
        {
            try
            {
                using (DbCommand cmd = Common.dbConn.GetStoredProcCommand("MstDeptGetList"))
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
                throw exception;
            }
            return null;
        }

        public Result Delete(int id)
        {
            try
            {
                using (DbCommand cmd = Common.dbConn.GetStoredProcCommand("MSTDeptDelete"))
                {
                    Common.dbConn.AddInParameter(cmd, "Id", DbType.Int32, id);
                    Common.dbConn.ExecuteNonQuery(cmd);
                    return new Result { Id = 1, Message = "Deleted Successfully", ResultStatus = OperationStatus.DeletedSuccessFully };
                }
            }
            catch (Exception exception)
            {
                throw exception;
            }
            return null;
        }

        public DataTable MastersListing()
        {
            try
            {
                using (DbCommand cmd = Common.dbConn.GetStoredProcCommand("MstDeptList"))
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
