using System;
using System.Collections.Generic;

namespace WebApplication.abbas_lkb
{
    public partial class TblItemStockLog
    {
        public int Id { get; set; }
        public int ItemId { get; set; }
        public int Type { get; set; }
        public int Amount { get; set; }
        public DateTimeOffset Timestamp { get; set; }
        public int OrderId { get; set; }
    }
}
