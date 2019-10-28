using System;
using System.Collections.Generic;

namespace WebApplication.abbas_lkb
{
    public partial class TblSectionItems
    {
        public int Id { get; set; }
        public int SectionId { get; set; }
        public int ItemId { get; set; }
        public int Priority { get; set; }

        public TblItem Item { get; set; }
        public TblSection Section { get; set; }
    }
}
