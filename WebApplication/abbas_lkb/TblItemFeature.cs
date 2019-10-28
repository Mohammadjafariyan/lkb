using System;
using System.Collections.Generic;

namespace WebApplication.abbas_lkb
{
    public partial class TblItemFeature
    {
        public int Id { get; set; }
        public int ItemId { get; set; }
        public int FeatureId { get; set; }
        public string Value { get; set; }

        public TblCategoryFeatures Feature { get; set; }
        public TblItem Item { get; set; }
    }
}
