using System;
using System.Collections.Generic;

#nullable disable

namespace RevenueTracker.Data
{
    public partial class TblCurrencyMaster
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public decimal? ConversionRate { get; set; }
        public DateTime? CreatedDate { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public long? UpdatedBy { get; set; }
    }
}
