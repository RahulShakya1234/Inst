using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace ERPDTO.Masters
{
     [DataContract]
    public class ItemDTO : ERPDTOBase
    {
         [DataMember]
        public string DisplayName { get; set; }

        [DataMember]
         public string AliasItemCode { get; set; }

        [DataMember]
        public string PrintDescription { get; set; }

        [DataMember]
        public float BasicUnit { get; set; }

        [DataMember]
        public string Package { get; set; }

        [DataMember]
        public int GroupName { get; set; }

        [DataMember]
        public float SaleRate { get; set; }

        [DataMember]
        public float MRP { get; set; }

        [DataMember]
        public float PurchaseRate { get; set; }

        [DataMember]
        public float MRPRate { get; set; }

        [DataMember]
        public float ExportRate { get; set; }

        [DataMember]
        public float PlatingRate { get; set; }

        [DataMember]
        public float StockRate { get; set; }

        [DataMember]
        public float Value { get; set; }

        [DataMember]
        public int RT12Code { get; set; }

        [DataMember]
        public string TraiffNo { get; set; }

        [DataMember]
        public bool Active { get; set; }

        [DataMember]
        public bool TaxableItem { get; set; }

        [DataMember]
        public int ExciseRegister { get; set; }

        [DataMember]
        public int ItemType { get; set; }

        [DataMember]
        public float NonExciseStock { get; set; }

        [DataMember]
        public float ExciseRG1Stock { get; set; }

        [DataMember]
        public float ExciseRG23AStock { get; set; }

        [DataMember]
        public float ExciseRG23CStock { get; set; }

        [DataMember]
        public float TotalStock { get; set; }

     // Other Tab
        [DataMember]
        public float MinQuantity { get; set; }

        [DataMember]
        public float MaxQty { get; set; }

        [DataMember]
        public float ReOrderLevel { get; set; }

        [DataMember]
        public float NetWeight { get; set; }

        [DataMember]
        public float CutWeight { get; set; }

        [DataMember]
        public float GrossWeight { get; set; }

        [DataMember]
        public float Length { get; set; }

        [DataMember]
        public float Width { get; set; }

        [DataMember]
        public float BinPackageQty { get; set; }

        [DataMember]
        public float FreeQtyBin { get; set; }


        [DataMember]
        public float AlternateUnit { get; set; }

        [DataMember]
        public string ConversionFormule1 { get; set; }

        [DataMember]
        public string ConversionFormule2 { get; set; }

        [DataMember]
        public int ItemSpecCode { get; set; }

        [DataMember]
        public string DescriptionForInvoice { get; set; }

        [DataMember]
        public string RackNo { get; set; }

        [DataMember]
        public bool MakeMRNJwAuto { get; set; }

        [DataMember]
        public float ItemArea { get; set; }

        [DataMember]
        public string FileName  { get; set; }
       

        [DataMember]
        public float MinOrderQty { get; set; }

        [DataMember]
        public float LeadTime { get; set; }

        [DataMember]
        public int PackageType { get; set; }

        [DataMember]
        public string Code { get; set; }

        [DataMember]
        public int RawMaterialUsed { get; set; }

        [DataMember]
        public int PriceListName { get; set; }

        [DataMember]
        public float RateFactor1 { get; set; }

        [DataMember]
        public float RateFactor2 { get; set; }

        [DataMember]
        public float RateFactor3 { get; set; }

        [DataMember]
        public float RateFactor4 { get; set; }

        [DataMember]
        public int ProcessName { get; set; }

        
      
      
      
      
    
    }
}
