using System;
using System.Collections.Generic;

namespace WebApplication.abbas_lkb
{
    public partial class TblItem
    {
        public TblItem()
        {
            TblItemCar = new HashSet<TblItemCar>();
            TblItemFeature = new HashSet<TblItemFeature>();
            TblItemPics = new HashSet<TblItemPics>();
            TblOrderItems = new HashSet<TblOrderItems>();
            TblSectionItems = new HashSet<TblSectionItems>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Pic { get; set; }
        public string Price { get; set; }
        public int Stock { get; set; }
        public int? InstallPriceGroup { get; set; }
        public int GuarantyMonth { get; set; }
        public int CatId { get; set; }
        public int Active { get; set; }
        public DateTimeOffset CreatedAt { get; set; }
        public int Priority { get; set; }
        public string Text { get; set; }
        public int View { get; set; }
        public int ForceInstall { get; set; }
        public int IsLimited { get; set; }
        public int MaxPerOrder { get; set; }
        public int LimitPeriod { get; set; }

        public TblCategory Cat { get; set; }
        public TblInstallPrice InstallPriceGroupNavigation { get; set; }
        public ICollection<TblItemCar> TblItemCar { get; set; }
        public ICollection<TblItemFeature> TblItemFeature { get; set; }
        public ICollection<TblItemPics> TblItemPics { get; set; }
        public ICollection<TblOrderItems> TblOrderItems { get; set; }
        public ICollection<TblSectionItems> TblSectionItems { get; set; }
    }
}
