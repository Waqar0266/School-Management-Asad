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
    
    public partial class Operator
    {
        public int user_id { get; set; }
        public Nullable<int> role_id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string user_name { get; set; }
        public string email { get; set; }
        public string password_ { get; set; }
    
        public virtual role role { get; set; }
    }
}
