//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SA41Team02B
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tran
    {
        public int TransactionID { get; set; }
        public string MemberID { get; set; }
        public string FacilityID { get; set; }
        public Nullable<System.DateTime> SlotDate { get; set; }
        public string SlotTime { get; set; }
        public Nullable<System.DateTime> DateBooking { get; set; }
        public string Action { get; set; }
    
        public virtual Facility Facility { get; set; }
        public virtual Member Member { get; set; }
    }
}
