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
    
    public partial class WMS_FUNCTIONS
    {
    	[DataMember]
        public decimal FUC_ID { get; set; }
    	[DataMember]
        public decimal MENU_ID { get; set; }
    	[DataMember]
        public string FUC_NAME { get; set; }
    	[DataMember]
        public string FUC_FORM { get; set; }
    	[DataMember]
        public string FUC_DESC { get; set; }
    	[DataMember]
        public Nullable<decimal> ORDER_NO { get; set; }
    }
}
