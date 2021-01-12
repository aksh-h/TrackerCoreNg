using System;
using System.Collections.Generic;


namespace RevenueTracker.Data
{
    public partial class State
    {
        public int StateId { get; set; }
        public string StateName { get; set; }
        public DateTime? CreatedDate { get; set; }
        public bool? IsActive { get; set; }
    }
}
