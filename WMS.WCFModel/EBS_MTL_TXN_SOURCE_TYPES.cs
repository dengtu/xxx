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
    
    public partial class EBS_MTL_TXN_SOURCE_TYPES
    {
    	[DataMember]
        public decimal TRANSACTION_SOURCE_TYPE_ID { get; set; }
    	[DataMember]
        public System.DateTime LAST_UPDATE_DATE { get; set; }
    	[DataMember]
        public decimal LAST_UPDATED_BY { get; set; }
    	[DataMember]
        public System.DateTime CREATION_DATE { get; set; }
    	[DataMember]
        public decimal CREATED_BY { get; set; }
    	[DataMember]
        public string TRANSACTION_SOURCE_TYPE_NAME { get; set; }
    	[DataMember]
        public string DESCRIPTION { get; set; }
    	[DataMember]
        public Nullable<System.DateTime> DISABLE_DATE { get; set; }
    	[DataMember]
        public string USER_DEFINED_FLAG { get; set; }
    	[DataMember]
        public string VALIDATED_FLAG { get; set; }
    	[DataMember]
        public string DESCRIPTIVE_FLEX_CONTEXT_CODE { get; set; }
    	[DataMember]
        public string ATTRIBUTE_CATEGORY { get; set; }
    	[DataMember]
        public string ATTRIBUTE1 { get; set; }
    	[DataMember]
        public string ATTRIBUTE2 { get; set; }
    	[DataMember]
        public string ATTRIBUTE3 { get; set; }
    	[DataMember]
        public string ATTRIBUTE4 { get; set; }
    	[DataMember]
        public string ATTRIBUTE5 { get; set; }
    	[DataMember]
        public string ATTRIBUTE6 { get; set; }
    	[DataMember]
        public string ATTRIBUTE7 { get; set; }
    	[DataMember]
        public string ATTRIBUTE8 { get; set; }
    	[DataMember]
        public string ATTRIBUTE9 { get; set; }
    	[DataMember]
        public string ATTRIBUTE10 { get; set; }
    	[DataMember]
        public string ATTRIBUTE11 { get; set; }
    	[DataMember]
        public string ATTRIBUTE12 { get; set; }
    	[DataMember]
        public string ATTRIBUTE13 { get; set; }
    	[DataMember]
        public string ATTRIBUTE14 { get; set; }
    	[DataMember]
        public string ATTRIBUTE15 { get; set; }
    	[DataMember]
        public Nullable<decimal> REQUEST_ID { get; set; }
    	[DataMember]
        public Nullable<decimal> PROGRAM_APPLICATION_ID { get; set; }
    	[DataMember]
        public Nullable<decimal> PROGRAM_ID { get; set; }
    	[DataMember]
        public Nullable<System.DateTime> PROGRAM_UPDATE_DATE { get; set; }
    	[DataMember]
        public string TRANSACTION_SOURCE_CATEGORY { get; set; }
    	[DataMember]
        public string TRANSACTION_SOURCE { get; set; }
    }
}
