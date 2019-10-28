using System;
using System.Collections.Generic;

namespace WebApplication.abbas_lkb
{
    public partial class TblItemPics
    {
        public int Id { get; set; }
        public int? ItemId { get; set; }
        public string Pic { get; set; }

        public TblItem Item { get; set; }
    }
}
