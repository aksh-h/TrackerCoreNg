using System;
using System.Collections.Generic;

#nullable disable

namespace RevenueTracker.Data
{
    public partial class TblRevenueTargetMaster
    {
        public int Id { get; set; }
        public DateTime FinancialYearStart { get; set; }
        public DateTime? FinancialYearEnd { get; set; }
        public int? CompanyId { get; set; }
        public int? CurrencyId { get; set; }
        public string TargetAmount { get; set; }
        public string ConversionRate { get; set; }
        public DateTime CreatedDate { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public long? UpdatedBy { get; set; }
    }
}
