using System;
using System.Collections.Generic;

#nullable disable

namespace RevenueTracker.Data
{
    public partial class TblClientContactMaster
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public string PersonName { get; set; }
        public string EmailId { get; set; }
        public string PhoneNumber { get; set; }
        public string Designation { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? CreatedDate { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public long? UpdatedBy { get; set; }
    }
}
