using System;
using System.Collections.Generic;

namespace WebApplication.abbas_lkb
{
    public partial class TblSlider
    {
        public int Id { get; set; }
        public string Pic { get; set; }
        public int Type { get; set; }
        public int? CatId { get; set; }
        public int? ItemId { get; set; }
        public string WebUrl { get; set; }
        public int Priority { get; set; }
        public DateTimeOffset CreatedAt { get; set; }
    }
}
