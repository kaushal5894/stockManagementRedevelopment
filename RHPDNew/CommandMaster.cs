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
    
    public partial class CommandMaster
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CommandMaster()
        {
            this.Formations = new HashSet<Formation>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public string Descripition { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<int> Addedby { get; set; }
        public Nullable<System.DateTime> Addedon { get; set; }
        public Nullable<int> Updatedby { get; set; }
        public Nullable<System.DateTime> UndatedOn { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Formation> Formations { get; set; }
    }
}
