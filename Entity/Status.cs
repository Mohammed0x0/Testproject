//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TestProj.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class Status
    {
        public int Id { get; set; }
        public int Device_id { get; set; }
        public int User_id { get; set; }
        public System.DateTime DateStart { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public Nullable<bool> isActive { get; set; }
    
        public virtual Devices Devices { get; set; }
        public virtual Users Users { get; set; }
    }
}
