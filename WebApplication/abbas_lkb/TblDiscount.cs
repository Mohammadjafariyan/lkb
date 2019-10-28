using System;
using System.Collections.Generic;

namespace WebApplication.abbas_lkb
{
    public partial class TblDiscount
    {
        public TblDiscount()
        {
            TblOrder = new HashSet<TblOrder>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public int Type { get; set; }
        public string Code { get; set; }
        public string AmountType { get; set; }
        public int Amount { get; set; }
        public string Text { get; set; }
        public int? UserId { get; set; }
        public int? ServiceId { get; set; }
        public int CatId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime StopDate { get; set; }
        public DateTimeOffset CreatedAt { get; set; }
        public int Active { get; set; }
        public int MinFAmount { get; set; }

        public TblService Service { get; set; }
        public TblCustomer User { get; set; }
        public ICollection<TblOrder> TblOrder { get; set; }
    }
}
