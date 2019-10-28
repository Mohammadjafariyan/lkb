using System;
using System.Collections.Generic;

namespace WebApplication.abbas_lkb
{
    public partial class TblSection
    {
        public TblSection()
        {
            TblSectionItems = new HashSet<TblSectionItems>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int Priority { get; set; }

        public ICollection<TblSectionItems> TblSectionItems { get; set; }
    }
}
