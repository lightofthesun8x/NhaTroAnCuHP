//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NhaTroAnCu.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Notification
    {
        public int Id { get; set; }
        public int TenantId { get; set; }
        public string Content { get; set; }
        public System.DateTime CreatedAt { get; set; }
        public bool IsRead { get; set; }
    
        public virtual Tenant Tenant { get; set; }
    }
}
