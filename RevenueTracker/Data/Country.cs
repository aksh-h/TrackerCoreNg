using System;
using System.Collections.Generic;


namespace RevenueTracker.Data
{
    public partial class Country
    {
        public int CountryId { get; set; }
        public string CountryName { get; set; }
        public DateTime? CreatedDate { get; set; }
        public bool? IsActive { get; set; }
    }
}
