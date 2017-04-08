using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.EnterpriseLibrary.Data;

namespace ERPDAL
{
    class Common
    {
        public static Database dbConn = DatabaseFactory.CreateDatabase();
    }
}
