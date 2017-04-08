using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ERPDTO;
using ERPDTO.Masters;
using ERPDAL;
using ERPDAL.Masters;
using System.Data;

namespace ERPBL.Masters
{
   public class UserLoginBL
    {
       public Result UserLogin(string Username, string Password)
       {
           return new LoginDAL().UserLogin(Username, Password);
       }

    }
}
