using System;
using System.Collections.Generic;

#nullable disable

namespace RevenueTracker.Data
{
    public partial class TblProjectMaster
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public int? ProjectTypeId { get; set; }
        public DateTime? ProjectStartDate { get; set; }
        public DateTime? ProjectEndDate { get; set; }
        public int? BillingType { get; set; }
        public int? UnitRate { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? CreatedDate { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public long? UpdatedBy { get; set; }
    }
}
