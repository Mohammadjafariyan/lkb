using System;
using System.Collections.Generic;

namespace WebApplication.abbas_lkb
{
    public partial class TblService
    {
        public TblService()
        {
            TblDiscount = new HashSet<TblDiscount>();
            TblServiceCar = new HashSet<TblServiceCar>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int HasPrice { get; set; }
        public int HasCount { get; set; }
        public int CatId { get; set; }
        public string Pic { get; set; }
        public string Desc { get; set; }
        public int Priority { get; set; }
        public int Active { get; set; }

        public TblServiceCategory Cat { get; set; }
        public ICollection<TblDiscount> TblDiscount { get; set; }
        public ICollection<TblServiceCar> TblServiceCar { get; set; }
    }
}
