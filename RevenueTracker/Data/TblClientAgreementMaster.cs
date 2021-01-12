using System;
using System.Collections.Generic;

#nullable disable

namespace RevenueTracker.Data
{
    public partial class TblClientAgreementMaster
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime CreatedDate { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public long? UpdatedBy { get; set; }
    }
}
