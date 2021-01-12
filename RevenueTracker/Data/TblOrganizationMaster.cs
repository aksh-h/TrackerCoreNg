using System;
using System.Collections.Generic;

#nullable disable

namespace RevenueTracker.Data
{
    public partial class TblOrganizationMaster
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int? CountryId { get; set; }
        public int? StateId { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? CreatedDate { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public long? UpdatedBy { get; set; }
    }
}
