using System;
using System.Collections.Generic;

namespace WebApplication.abbas_lkb
{
    public partial class TblInstallPrice
    {
        public TblInstallPrice()
        {
            TblItem = new HashSet<TblItem>();
        }

        public int Id { get; set; }
        public string GroupName { get; set; }
        public int Price { get; set; }

        public ICollection<TblItem> TblItem { get; set; }
    }
}
