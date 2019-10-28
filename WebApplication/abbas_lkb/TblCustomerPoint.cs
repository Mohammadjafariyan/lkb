using System;
using System.Collections.Generic;

namespace WebApplication.abbas_lkb
{
    public partial class TblCustomerPoint
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int? OrderId { get; set; }
        public int Type { get; set; }
        public int Points { get; set; }
        public DateTimeOffset CreatedAt { get; set; }

        public TblCustomer Customer { get; set; }
    }
}
