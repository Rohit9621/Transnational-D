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
    
    public partial class tblApplySurHeaderDetail
    {
        public int SurHeaderDId { get; set; }
        public Nullable<int> SurHeaderId { get; set; }
        public Nullable<int> ReferenceId { get; set; }
        public string ASRateType { get; set; }
        public string ASSurchargeId { get; set; }
        public string ASValue { get; set; }
        public Nullable<bool> Colection { get; set; }
        public Nullable<bool> Delivery { get; set; }
        public Nullable<System.DateTime> ASCreatedDate { get; set; }
        public Nullable<System.DateTime> ASUpdatedDate { get; set; }
        public Nullable<int> ASCreatedBy { get; set; }
        public Nullable<int> ASUpdatedBy { get; set; }
    }
}