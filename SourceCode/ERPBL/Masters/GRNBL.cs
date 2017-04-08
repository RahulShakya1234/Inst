using System;
using System.Text;
using ERPDTO;
using ERPDTO.Masters;
using ERPDAL;
using ERPDAL.Masters;
using System.Data;

namespace ERPBL.Masters
{
   public class GRNBL
    {
       public Result SaveMST(ERPDTOBase obj)
       {
           MSTGRNDTO oMSTGRNDTO = obj as MSTGRNDTO;
           return new GRNDAL().SaveMSTGRN(oMSTGRNDTO);
       }

       public Result SaveDET(ERPDTOBase obj)
       {
           DETGRNDTO oDETGRNDTO = obj as DETGRNDTO;
           return new GRNDAL().SaveDETGRN(oDETGRNDTO);
       } 
   
   }
    
}
