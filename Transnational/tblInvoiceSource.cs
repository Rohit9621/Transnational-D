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
    
    public partial class tblInvoiceSource
    {
        public int ISourceId { get; set; }
        public string InvoiceId { get; set; }
        public Nullable<float> MarketSegment1 { get; set; }
        public Nullable<float> MarketSubSegment1 { get; set; }
        public Nullable<float> MarketSubSegment2 { get; set; }
        public Nullable<float> MarketSegment2 { get; set; }
        public Nullable<float> MarketSegment3 { get; set; }
        public string Remark { get; set; }
        public Nullable<System.DateTime> DepartDate { get; set; }
        public string OrderNo { get; set; }
    }
}
