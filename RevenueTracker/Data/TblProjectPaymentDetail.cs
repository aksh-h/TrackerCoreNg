using System;
using System.Collections.Generic;

#nullable disable

namespace RevenueTracker.Data
{
    public partial class TblProjectPaymentDetail
    {
        public int Id { get; set; }
        public long ProjectId { get; set; }
        public string PaymentName { get; set; }
        public decimal Percentage { get; set; }
        public long? Amount { get; set; }
        public DateTime? CreatedDate { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public long? UpdatedBy { get; set; }
    }
}
