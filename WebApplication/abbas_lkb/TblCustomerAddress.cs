using System;
using System.Collections.Generic;

namespace WebApplication.abbas_lkb
{
    public partial class TblCustomerAddress
    {
        public TblCustomerAddress()
        {
            TblOrder = new HashSet<TblOrder>();
        }

        public int Id { get; set; }
        public int? CustomerId { get; set; }
        public string Title { get; set; }
        public string Address { get; set; }
        public double Lat { get; set; }
        public double Lng { get; set; }
        public string AddressPhone { get; set; }
        public int Hidden { get; set; }

        public TblCustomer Customer { get; set; }
        public ICollection<TblOrder> TblOrder { get; set; }
    }
}
