using System;
using System.Collections.Generic;

namespace WebApplication.abbas_lkb
{
    public partial class TblUpdate
    {
        public int Id { get; set; }
        public string Os { get; set; }
        public string Ver { get; set; }
        public int IsEssential { get; set; }
        public DateTimeOffset Timestamp { get; set; }
    }
}
