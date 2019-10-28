using System;
using System.Collections.Generic;

namespace WebApplication.abbas_lkb
{
    public partial class TblOrderPay
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int Amount { get; set; }
        public string TransactionId { get; set; }
        public DateTimeOffset CreatedAt { get; set; }

        public TblOrder Order { get; set; }
    }
}
