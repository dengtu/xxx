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
    
    public partial class EBS_MTL_TXN_REQUEST_LINES
    {
    	[DataMember]
        public decimal LINE_ID { get; set; }
    	[DataMember]
        public decimal HEADER_ID { get; set; }
    	[DataMember]
        public decimal LINE_NUMBER { get; set; }
    	[DataMember]
        public decimal ORGANIZATION_ID { get; set; }
    	[DataMember]
        public decimal INVENTORY_ITEM_ID { get; set; }
    	[DataMember]
        public string REVISION { get; set; }
    	[DataMember]
        public string FROM_SUBINVENTORY_CODE { get; set; }
    	[DataMember]
        public Nullable<decimal> FROM_LOCATOR_ID { get; set; }
    	[DataMember]
        public string TO_SUBINVENTORY_CODE { get; set; }
    	[DataMember]
        public Nullable<decimal> TO_LOCATOR_ID { get; set; }
    	[DataMember]
        public Nullable<decimal> TO_ACCOUNT_ID { get; set; }
    	[DataMember]
        public string LOT_NUMBER { get; set; }
    	[DataMember]
        public string SERIAL_NUMBER_START { get; set; }
    	[DataMember]
        public string SERIAL_NUMBER_END { get; set; }
    	[DataMember]
        public string UOM_CODE { get; set; }
    	[DataMember]
        public decimal QUANTITY { get; set; }
    	[DataMember]
        public Nullable<decimal> QUANTITY_DELIVERED { get; set; }
    	[DataMember]
        public Nullable<decimal> QUANTITY_DETAILED { get; set; }
    	[DataMember]
        public System.DateTime DATE_REQUIRED { get; set; }
    	[DataMember]
        public Nullable<decimal> REASON_ID { get; set; }
    	[DataMember]
        public string REFERENCE { get; set; }
    	[DataMember]
        public Nullable<decimal> REFERENCE_TYPE_CODE { get; set; }
    	[DataMember]
        public Nullable<decimal> REFERENCE_ID { get; set; }
    	[DataMember]
        public Nullable<decimal> PROJECT_ID { get; set; }
    	[DataMember]
        public Nullable<decimal> TASK_ID { get; set; }
    	[DataMember]
        public Nullable<decimal> TRANSACTION_HEADER_ID { get; set; }
    	[DataMember]
        public decimal LINE_STATUS { get; set; }
    	[DataMember]
        public System.DateTime STATUS_DATE { get; set; }
    	[DataMember]
        public decimal LAST_UPDATED_BY { get; set; }
    	[DataMember]
        public Nullable<decimal> LAST_UPDATE_LOGIN { get; set; }
    	[DataMember]
        public System.DateTime LAST_UPDATE_DATE { get; set; }
    	[DataMember]
        public Nullable<decimal> CREATED_BY { get; set; }
    	[DataMember]
        public System.DateTime CREATION_DATE { get; set; }
    	[DataMember]
        public Nullable<decimal> REQUEST_ID { get; set; }
    	[DataMember]
        public Nullable<decimal> PROGRAM_APPLICATION_ID { get; set; }
    	[DataMember]
        public Nullable<decimal> PROGRAM_ID { get; set; }
    	[DataMember]
        public Nullable<System.DateTime> PROGRAM_UPDATE_DATE { get; set; }
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
        public string ATTRIBUTE_CATEGORY { get; set; }
    	[DataMember]
        public Nullable<decimal> TXN_SOURCE_ID { get; set; }
    	[DataMember]
        public Nullable<decimal> TXN_SOURCE_LINE_ID { get; set; }
    	[DataMember]
        public Nullable<decimal> TXN_SOURCE_LINE_DETAIL_ID { get; set; }
    	[DataMember]
        public decimal TRANSACTION_TYPE_ID { get; set; }
    	[DataMember]
        public Nullable<decimal> TRANSACTION_SOURCE_TYPE_ID { get; set; }
    	[DataMember]
        public Nullable<decimal> PRIMARY_QUANTITY { get; set; }
    	[DataMember]
        public Nullable<decimal> TO_ORGANIZATION_ID { get; set; }
    	[DataMember]
        public Nullable<decimal> PUT_AWAY_STRATEGY_ID { get; set; }
    	[DataMember]
        public Nullable<decimal> PICK_STRATEGY_ID { get; set; }
    	[DataMember]
        public Nullable<decimal> SHIP_TO_LOCATION_ID { get; set; }
    	[DataMember]
        public string UNIT_NUMBER { get; set; }
    	[DataMember]
        public Nullable<decimal> REFERENCE_DETAIL_ID { get; set; }
    	[DataMember]
        public Nullable<decimal> ASSIGNMENT_ID { get; set; }
    	[DataMember]
        public Nullable<decimal> FROM_COST_GROUP_ID { get; set; }
    	[DataMember]
        public Nullable<decimal> TO_COST_GROUP_ID { get; set; }
    	[DataMember]
        public Nullable<decimal> LPN_ID { get; set; }
    	[DataMember]
        public Nullable<decimal> TO_LPN_ID { get; set; }
    	[DataMember]
        public Nullable<decimal> PICK_SLIP_NUMBER { get; set; }
    	[DataMember]
        public Nullable<System.DateTime> PICK_SLIP_DATE { get; set; }
    	[DataMember]
        public Nullable<decimal> FROM_SUBINVENTORY_ID { get; set; }
    	[DataMember]
        public Nullable<decimal> TO_SUBINVENTORY_ID { get; set; }
    	[DataMember]
        public Nullable<decimal> INSPECTION_STATUS { get; set; }
    	[DataMember]
        public Nullable<decimal> PICK_METHODOLOGY_ID { get; set; }
    	[DataMember]
        public Nullable<decimal> CONTAINER_ITEM_ID { get; set; }
    	[DataMember]
        public Nullable<decimal> CARTON_GROUPING_ID { get; set; }
    	[DataMember]
        public Nullable<decimal> BACKORDER_DELIVERY_DETAIL_ID { get; set; }
    	[DataMember]
        public Nullable<decimal> WMS_PROCESS_FLAG { get; set; }
    	[DataMember]
        public Nullable<decimal> SHIP_SET_ID { get; set; }
    	[DataMember]
        public Nullable<decimal> SHIP_MODEL_ID { get; set; }
    	[DataMember]
        public Nullable<decimal> MODEL_QUANTITY { get; set; }
    	[DataMember]
        public Nullable<decimal> CROSSDOCK_TYPE { get; set; }
    	[DataMember]
        public Nullable<decimal> REQUIRED_QUANTITY { get; set; }
    	[DataMember]
        public string GRADE_CODE { get; set; }
    	[DataMember]
        public Nullable<decimal> SECONDARY_QUANTITY { get; set; }
    	[DataMember]
        public Nullable<decimal> SECONDARY_QUANTITY_DELIVERED { get; set; }
    	[DataMember]
        public Nullable<decimal> SECONDARY_QUANTITY_DETAILED { get; set; }
    	[DataMember]
        public Nullable<decimal> SECONDARY_REQUIRED_QUANTITY { get; set; }
    	[DataMember]
        public string SECONDARY_UOM_CODE { get; set; }
    	[DataMember]
        public Nullable<decimal> WIP_ENTITY_ID { get; set; }
    	[DataMember]
        public Nullable<decimal> REPETITIVE_SCHEDULE_ID { get; set; }
    	[DataMember]
        public Nullable<decimal> OPERATION_SEQ_NUM { get; set; }
    	[DataMember]
        public Nullable<decimal> WIP_SUPPLY_TYPE { get; set; }
    	[DataMember]
        public Nullable<decimal> JL_FLAG { get; set; }
    }
}
