using System;
using System.Collections.Generic;

namespace WebApplication.abbas_lkb
{
    public partial class TblCustomerGcm
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public string GcmId { get; set; }
        public int DevType { get; set; }

        public TblCustomer Customer { get; set; }
    }
}
