using System;
using System.Collections.Generic;

namespace WebApplication.abbas_lkb
{
    public partial class TblCategory
    {
        public TblCategory()
        {
            TblCategoryFeatures = new HashSet<TblCategoryFeatures>();
            TblItem = new HashSet<TblItem>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Pic { get; set; }
        public int Active { get; set; }

        public ICollection<TblCategoryFeatures> TblCategoryFeatures { get; set; }
        public ICollection<TblItem> TblItem { get; set; }
    }
}
