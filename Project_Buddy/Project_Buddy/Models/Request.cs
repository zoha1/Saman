//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Project_Buddy.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Request
    {
        public int request_id { get; set; }
        public Nullable<int> group_id { get; set; }
        public Nullable<int> user_id { get; set; }
        public string request_status { get; set; }
    
        public virtual Group Group { get; set; }
        public virtual User User { get; set; }
    }
}
