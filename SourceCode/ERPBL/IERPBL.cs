using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ERPDTO;

namespace ERPBL
{
    public interface IERPBL
    {
        Result Save(ERPDTOBase obj);
    }
}
