using System;
using System.Collections.Generic;

namespace WebApplication.abbas_lkb
{
    public partial class TblItemCar
    {
        public int Id { get; set; }
        public int ItemId { get; set; }
        public int CarId { get; set; }

        public TblCar Car { get; set; }
        public TblItem Item { get; set; }
    }
}
