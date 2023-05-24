﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Transnational.Controllers.Login
{
    public class user
    {
        public int UserId { get; set; }
        public string LoginId { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Sex { get; set; }
        public Nullable<System.DateTime> DOB { get; set; }
        public string PhoneNo1 { get; set; }
        public string PhoneNo2 { get; set; }
        public string MobileNo { get; set; }
        public Nullable<int> DesignationId { get; set; }
        public Nullable<int> DepartmentId { get; set; }
        public Nullable<int> BranchId { get; set; }
        public string UserType { get; set; }
        public Nullable<float> HourPerDay { get; set; }
        public string EmailAddress { get; set; }
        public string PersonalityProfile { get; set; }
        public string LAddress { get; set; }
        public Nullable<int> LStateId { get; set; }
        public Nullable<int> LCityId { get; set; }
        public Nullable<int> LCountryId { get; set; }
        public string PAddress { get; set; }
        public Nullable<int> PStateId { get; set; }
        public Nullable<int> PCityid { get; set; }
        public Nullable<int> PCountryid { get; set; }
        public Nullable<int> UType { get; set; }
        public Nullable<System.DateTime> DOJ { get; set; }
        public Nullable<int> Status { get; set; }
        public Nullable<float> EGroup { get; set; }
        public Nullable<System.DateTime> DOUJ { get; set; }
        public string Health { get; set; }
        public string NSROD { get; set; }
        public Nullable<float> EyeSight { get; set; }
        public Nullable<float> MaritalStaus { get; set; }
        public string PassportId { get; set; }
        public string NRICNO { get; set; }
        public string DLicence { get; set; }
        public Nullable<float> ReligionId { get; set; }
        public string Nationality { get; set; }
        public Nullable<float> NService { get; set; }
        public Nullable<float> RaceId { get; set; }
        public string Remark { get; set; }
        public string PostalCode { get; set; }
        public string UserPhotoUrl { get; set; }
        public string Salutation { get; set; }
        public Nullable<int> LanguageId { get; set; }
        public byte[] SSMA_TimeStamp { get; set; }
        public Nullable<int> UserLanguageId { get; set; }
        public Nullable<int> LDistrictId { get; set; }
        public Nullable<System.DateTime> ActiveDateFrom { get; set; }
        public Nullable<System.DateTime> ActiveDateTo { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> LUDate { get; set; }
        public Nullable<int> LUBy { get; set; }
        public string Address3 { get; set; }
        public string Address4 { get; set; }
        public string ApprovedDiscount { get; set; }
        public Nullable<int> LRegionId { get; set; }
        public Nullable<int> LnewStateid { get; set; }
    }
}