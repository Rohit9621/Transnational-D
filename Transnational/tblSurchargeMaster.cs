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
    
    public partial class tblSurchargeMaster
    {
        public int SurchargeId { get; set; }
        public string SurchargeName { get; set; }
        public int LanguageId { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreationDate { get; set; }
        public Nullable<System.DateTime> CreationTime { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdationDate { get; set; }
        public Nullable<System.DateTime> UpdationTime { get; set; }
        public string English { get; set; }
        public string Simplified_China { get; set; }
        public string Traditional_China { get; set; }
        public string Bahasa_Idonesia { get; set; }
        public string Region_Code { get; set; }
    }
}
