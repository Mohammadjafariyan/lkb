using System;
using System.Collections.Generic;

namespace WebApplication.abbas_lkb
{
    public partial class TblServiceCategory
    {
        public TblServiceCategory()
        {
            TblService = new HashSet<TblService>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int? Active { get; set; }

        public ICollection<TblService> TblService { get; set; }
    }
}
