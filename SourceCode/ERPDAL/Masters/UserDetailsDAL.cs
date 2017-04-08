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
    public class UserDetailsDAL
    {
        public Result Save(UserDetailsDTO obj)
        {
            try
            {
                using (DbCommand cmd = Common.dbConn.GetStoredProcCommand("MSTUserDetailsSave"))
                {
                    Common.dbConn.AddInParameter(cmd, "UserCode", DbType.Int32, obj.Id);
                    Common.dbConn.AddInParameter(cmd, "UserName", DbType.String, obj.UserName);
                    Common.dbConn.AddInParameter(cmd, "Password", DbType.String, obj.Password);
                    Common.dbConn.AddInParameter(cmd, "Gender", DbType.Int32, obj.Gender);
                  
                    if (obj.DOB == DateTime.MinValue)
                    {
                        Common.dbConn.AddInParameter(cmd, "DOB", DbType.Date, System.DBNull.Value);
                    }
                    else
                    {
                        Common.dbConn.AddInParameter(cmd, "DOB", DbType.Date, obj.DOB);
                    }
                    if (obj.DOJ == DateTime.MinValue)
                    {
                        Common.dbConn.AddInParameter(cmd, "DOJ", DbType.Date, System.DBNull.Value);
                    }
                    else
                    {
                        Common.dbConn.AddInParameter(cmd, "DOJ", DbType.Date, obj.DOJ);
                    }

                    if (obj.DOL == DateTime.MinValue)
                    {
                        Common.dbConn.AddInParameter(cmd, "DOL", DbType.Date, System.DBNull.Value);
                    }
                    else
                    {
                        Common.dbConn.AddInParameter(cmd, "DOL", DbType.Date, obj.DOL);
                    }

                    Common.dbConn.AddInParameter(cmd, "Department", DbType.Int32, obj.Department);
                    Common.dbConn.AddInParameter(cmd, "Location", DbType.Int32, obj.Location);
                    Common.dbConn.AddInParameter(cmd, "Designation", DbType.Int32, obj.Designation);
                    Common.dbConn.AddInParameter(cmd, "SoftwareRole", DbType.Int32, obj.SoftwareRole);

                    Common.dbConn.ExecuteNonQuery(cmd);
                    return new Result { Id = 1, Message = "Saved", ResultStatus = OperationStatus.SavedSuccessFully };
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable GetUserDetails()
        {
            try
            {
                using (DbCommand cmd = Common.dbConn.GetStoredProcCommand("MSTUserDetails"))
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
                using (DbCommand cmd = Common.dbConn.GetStoredProcCommand("MSTUserDetailsDelete"))
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
