using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ERPDTO.Masters;
using System.Data.Common;
using System.Data;
using ERPDTO;
using Common;
using System.Windows.Forms;


namespace ERPDAL.Masters
{
    public class LoginDAL
    {
        public Result UserLogin(string Username, string Password)
        {
            try
            {
                int flag = 0;
                using (DbCommand cmd = Common.dbConn.GetStoredProcCommand("CheckIfUserExists"))
                {
                    Common.dbConn.AddInParameter(cmd, "@Username", DbType.String, Username);
                    Common.dbConn.AddInParameter(cmd, "@Password", DbType.String, Password);
                    DataSet dsResult = Common.dbConn.ExecuteDataSet(cmd);

                    return dsResult.Tables[0].Rows.Count > 0 ? new Result { Id = dsResult.Tables[0].Rows[0]["UserCode"].ToInt(), Message = "Login Success", ResultStatus = OperationStatus.LoginSuccessFully } : new Result { Id = 0, Message = "Login failed", ResultStatus = OperationStatus.Loginfailed };
                }
            }
            catch (Exception ex)
            {
                ErrorLog.LogErrorInTxtFormat(ex);
                return new Result {Id = 0, Message = ex.Message, ResultStatus = OperationStatus.Loginfailed};
            }
        }
    }


}


