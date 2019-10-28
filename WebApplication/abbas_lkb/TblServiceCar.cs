using System;
using System.Collections.Generic;

namespace WebApplication.abbas_lkb
{
    public partial class TblServiceCar
    {
        public TblServiceCar()
        {
            TblOrderItems = new HashSet<TblOrderItems>();
        }

        public int Id { get; set; }
        public int ServiceId { get; set; }
        public int CarId { get; set; }
        public int Price { get; set; }

        public TblCar Car { get; set; }
        public TblService Service { get; set; }
        public ICollection<TblOrderItems> TblOrderItems { get; set; }
    }
}
