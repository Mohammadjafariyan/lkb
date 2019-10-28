using System;
using System.Collections.Generic;

namespace WebApplication.abbas_lkb
{
    public partial class TblTicket
    {
        public TblTicket()
        {
            TblTicketMsg = new HashSet<TblTicketMsg>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public int CustomerId { get; set; }
        public int Section { get; set; }
        public DateTimeOffset CreatedAt { get; set; }
        public int? IsClosed { get; set; }
        public int? OrderId { get; set; }

        public TblCustomer Customer { get; set; }
        public TblOrder Order { get; set; }
        public ICollection<TblTicketMsg> TblTicketMsg { get; set; }
    }
}
