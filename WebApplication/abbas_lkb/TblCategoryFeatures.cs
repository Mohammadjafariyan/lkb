using System;
using System.Collections.Generic;

namespace WebApplication.abbas_lkb
{
    public partial class TblCategoryFeatures
    {
        public TblCategoryFeatures()
        {
            TblItemFeature = new HashSet<TblItemFeature>();
        }

        public int Id { get; set; }
        public int CatId { get; set; }
        public string Feature { get; set; }
        public string DefaultValues { get; set; }
        public int IsFilter { get; set; }
        public int Type { get; set; }

        public TblCategory Cat { get; set; }
        public ICollection<TblItemFeature> TblItemFeature { get; set; }
    }
}
