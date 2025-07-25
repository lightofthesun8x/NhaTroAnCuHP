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
    
    public partial class UtilityBill
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public UtilityBill()
        {
            this.PaymentHistories = new HashSet<PaymentHistory>();
        }
    
        public int Id { get; set; }
        public int RoomId { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
        public Nullable<int> ContractId { get; set; }
        public Nullable<int> WaterIndexStart { get; set; }
        public Nullable<int> WaterIndexEnd { get; set; }
        public Nullable<decimal> WaterPrice { get; set; }
        public Nullable<decimal> ElectricityAmount { get; set; }
        public Nullable<decimal> Water { get; set; }
        public Nullable<decimal> RentAmount { get; set; }
        public Nullable<decimal> ExtraCharge { get; set; }
        public Nullable<decimal> Discount { get; set; }
        public Nullable<decimal> TotalAmount { get; set; }
        public string BillNote { get; set; }
        public string BillStatus { get; set; }
        public Nullable<System.DateTime> CreatedAt { get; set; }
        public Nullable<System.DateTime> UpdatedAt { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PaymentHistory> PaymentHistories { get; set; }
        public virtual Room Room { get; set; }
    }
}
