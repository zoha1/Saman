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
    
    public partial class User
    {
        public User()
        {
            this.Files = new HashSet<File>();
            this.Groups = new HashSet<Group>();
            this.Managers = new HashSet<Manager>();
            this.Members = new HashSet<Member>();
            this.Requests = new HashSet<Request>();
            this.Tasks = new HashSet<Task>();
        }
    
        public int user_id { get; set; }
        public string name { get; set; }
        public string password { get; set; }
        public string email { get; set; }
        public string mobileNo { get; set; }
        public string country { get; set; }
        public string city { get; set; }
        public byte[] image { get; set; }
        public string location { get; set; }
    
        public virtual ICollection<File> Files { get; set; }
        public virtual ICollection<Group> Groups { get; set; }
        public virtual ICollection<Manager> Managers { get; set; }
        public virtual ICollection<Member> Members { get; set; }
        public virtual ICollection<Request> Requests { get; set; }
        public virtual ICollection<Task> Tasks { get; set; }
    }
}