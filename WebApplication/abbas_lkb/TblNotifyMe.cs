using System;
using System.Collections.Generic;

namespace WebApplication.abbas_lkb
{
    public partial class TblNotifyMe
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int ItemId { get; set; }
        public int Seen { get; set; }
        public int IsNotified { get; set; }
        public DateTimeOffset CreatedAt { get; set; }
    }
}
