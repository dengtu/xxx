//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace WMS.WCFModel
{
    using System;
    using System.Runtime.Serialization;
    using System.Collections.Generic;
    
    [DataContract(IsReference = true)]
    
    public partial class WMS_TRANSACTIONS
    {
    	[DataMember]
        public decimal T_ID { get; set; }
    	[DataMember]
        public decimal TYPE_ID { get; set; }
    	[DataMember]
        public decimal OU_ID { get; set; }
    	[DataMember]
        public decimal ORG_ID { get; set; }
    	[DataMember]
        public decimal INV_ID { get; set; }
    	[DataMember]
        public Nullable<decimal> LOC_ID { get; set; }
    	[DataMember]
        public Nullable<decimal> AGT_ID { get; set; }
    	[DataMember]
        public Nullable<decimal> DEPT_ID { get; set; }
    	[DataMember]
        public decimal ITEM_ID { get; set; }
    	[DataMember]
        public Nullable<decimal> QTY { get; set; }
    	[DataMember]
        public Nullable<decimal> UOM_ID { get; set; }
    	[DataMember]
        public Nullable<decimal> QTY2 { get; set; }
    	[DataMember]
        public Nullable<decimal> UOM_ID2 { get; set; }
    	[DataMember]
        public string LOT_NUMBER { get; set; }
    	[DataMember]
        public string HEAT_NUMBER { get; set; }
    	[DataMember]
        public Nullable<System.DateTime> INV_DATE { get; set; }
    	[DataMember]
        public Nullable<decimal> VND_ID { get; set; }
    	[DataMember]
        public Nullable<decimal> SOURCE_TYPE { get; set; }
    	[DataMember]
        public Nullable<decimal> SOURCE_ID { get; set; }
    	[DataMember]
        public string SOURCE_CODE { get; set; }
    	[DataMember]
        public string COMMENTS { get; set; }
    	[DataMember]
        public Nullable<decimal> FLAG { get; set; }
    }
}
