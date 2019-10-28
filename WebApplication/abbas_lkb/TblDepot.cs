using System;
using System.Collections.Generic;

namespace WebApplication.abbas_lkb
{
    public partial class TblDepot
    {
        public TblDepot()
        {
            TblOrder = new HashSet<TblOrder>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public double Lat { get; set; }
        public double Lng { get; set; }
        public int Active { get; set; }

        public ICollection<TblOrder> TblOrder { get; set; }
    }
}
