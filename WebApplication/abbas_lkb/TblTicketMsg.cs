using System;
using System.Collections.Generic;

namespace WebApplication.abbas_lkb
{
    public partial class TblTicketMsg
    {
        public int Id { get; set; }
        public int TicketId { get; set; }
        public string Text { get; set; }
        public string Pic { get; set; }
        public int FromUser { get; set; }
        public int Seen { get; set; }
        public DateTimeOffset CreatedAt { get; set; }

        public TblTicket Ticket { get; set; }
    }
}
