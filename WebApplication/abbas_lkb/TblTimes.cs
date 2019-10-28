using System;
using System.Collections.Generic;

namespace WebApplication.abbas_lkb
{
    public partial class TblTimes
    {
        public TblTimes()
        {
            TblOrder = new HashSet<TblOrder>();
        }

        public int Id { get; set; }
        public string Type { get; set; }
        public TimeSpan StartTs { get; set; }
        public TimeSpan StopTs { get; set; }
        public int Active { get; set; }

        public ICollection<TblOrder> TblOrder { get; set; }
    }
}
