//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace School_Management_System
{
    using System;
    using System.Collections.Generic;
    
    public partial class parent
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public parent()
        {
            this.students = new HashSet<student>();
        }
    
        public int pr_id { get; set; }
        public string name_ { get; set; }
        public string email { get; set; }
        public string cnic { get; set; }
        public string cell_no { get; set; }
        public string occupation { get; set; }
        public string office_no { get; set; }
        public Nullable<decimal> monthly_income { get; set; }
        public string status { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<student> students { get; set; }
    }
}
