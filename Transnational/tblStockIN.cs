//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TokenAuthenticationInWebAPI
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblStockIN
    {
        public int StockInId { get; set; }
        public Nullable<int> ServiceId { get; set; }
        public Nullable<int> Quantity { get; set; }
        public Nullable<int> StockInByUserId { get; set; }
        public Nullable<int> CreatedByUserId { get; set; }
        public Nullable<System.DateTime> CreationDateTime { get; set; }
        public Nullable<System.DateTime> LastModifiedByUserId { get; set; }
        public Nullable<System.DateTime> LastModificationDateTime { get; set; }
    }
}
