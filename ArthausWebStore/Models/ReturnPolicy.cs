using System;
using System.Collections.Generic;

namespace ArthausWebStore.Models
{
    public partial class ReturnPolicy
    {
        public byte[] Timestamp { get; set; }
        public string StoreNo { get; set; }
        public string StoreGroupCode { get; set; }
        public string ItemCategoryCode { get; set; }
        public string ProductGroupCode { get; set; }
        public string ItemNo { get; set; }
        public string VariantCode { get; set; }
        public string VariantDimension1Code { get; set; }
        public byte RefundNotAllowed { get; set; }
        public byte ManagerPrivileges { get; set; }
        public string RefundPeriodLength { get; set; }
        public string Message1 { get; set; }
        public string Message2 { get; set; }
    }
}
