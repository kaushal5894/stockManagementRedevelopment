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
    using System.Collections.Generic;
    
    public partial class AddPMContainer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AddPMContainer()
        {
            this.tblExpensePMContainers = new HashSet<tblExpensePMContainer>();
        }
    
        public int ID { get; set; }
        public Nullable<int> PMID { get; set; }
        public Nullable<decimal> Quantity { get; set; }
        public Nullable<System.DateTime> DateOfReceival { get; set; }
        public Nullable<System.DateTime> AddedOn { get; set; }
        public Nullable<int> AddedBy { get; set; }
        public Nullable<System.DateTime> ModidfiedOn { get; set; }
        public Nullable<int> ModifiedBy { get; set; }
        public Nullable<int> CategoryID { get; set; }
    
        public virtual CategoryMaster CategoryMaster { get; set; }
        public virtual PMandContainerMaster PMandContainerMaster { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblExpensePMContainer> tblExpensePMContainers { get; set; }
    }
}