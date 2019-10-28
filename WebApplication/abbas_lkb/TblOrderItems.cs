using System;
using System.Collections.Generic;

namespace WebApplication.abbas_lkb
{
    public partial class TblOrderItems
    {
        public int Id { get; set; }
        public int? OrderId { get; set; }
        public int? ServiceId { get; set; }
        public int? ItemId { get; set; }
        public int Qnt { get; set; }
        public int Price { get; set; }
        public int ChkNeed { get; set; }
        public int InstallNeed { get; set; }
        public DateTime GuarantyExpire { get; set; }

        public TblItem Item { get; set; }
        public TblOrder Order { get; set; }
        public TblServiceCar Service { get; set; }
    }
}
