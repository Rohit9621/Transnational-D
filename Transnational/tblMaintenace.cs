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
    
    public partial class tblMaintenace
    {
        public int MaintainanceId { get; set; }
        public Nullable<float> InstallationNumber { get; set; }
        public Nullable<System.DateTime> From { get; set; }
        public Nullable<System.DateTime> To { get; set; }
        public string Type { get; set; }
        public Nullable<float> ServiceFeeCurrencyId { get; set; }
        public Nullable<double> ServiceFeeAmount { get; set; }
    }
}
