//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RHPDNew
{
    using System;
    
    public partial class sp_IssueVoucher_Result
    {
        public int Id { get; set; }
        public Nullable<int> IdtId { get; set; }
        public Nullable<int> ToDepuId { get; set; }
        public Nullable<int> ToUnitId { get; set; }
        public string VechileNo { get; set; }
        public string Authority { get; set; }
        public string Through { get; set; }
        public Nullable<int> AddedBy { get; set; }
        public Nullable<System.DateTime> AddedOn { get; set; }
        public Nullable<int> ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedOn { get; set; }
        public Nullable<bool> IsActive { get; set; }
    }
}