//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Library_EntityFramework
{
    using System;
    using System.Collections.Generic;
    
    public partial class Journal
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public int ManagerId { get; set; }
        public int ReaderId { get; set; }
        public System.DateTime IssueDate { get; set; }
        public Nullable<System.DateTime> ReturnDate { get; set; }
    
        public virtual Books Books { get; set; }
        public virtual Managers Managers { get; set; }
        public virtual Readers Readers { get; set; }
    }
}
