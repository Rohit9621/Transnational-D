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
    
    public partial class tblCustomerHistory
    {
        public int HistoryId { get; set; }
        public Nullable<int> EnquiryId { get; set; }
        public Nullable<int> CustomerId { get; set; }
        public Nullable<int> ActivityId { get; set; }
        public Nullable<int> SourceCycleId { get; set; }
        public string Decesion { get; set; }
        public string DistanceTraveled { get; set; }
        public string Expenses { get; set; }
        public string InvoiceId { get; set; }
        public byte[] SSMA_TimeStamp { get; set; }
    }
}
