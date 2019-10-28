using System;
using System.Collections.Generic;

namespace WebApplication.abbas_lkb
{
    public partial class TblOrderRate
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int Rate { get; set; }
        public string Text { get; set; }
        public DateTimeOffset CreatedAt { get; set; }

        public TblOrder Order { get; set; }
    }
}
