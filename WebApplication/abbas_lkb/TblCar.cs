using System;
using System.Collections.Generic;

namespace WebApplication.abbas_lkb
{
    public partial class TblCar
    {
        public TblCar()
        {
            TblItemCar = new HashSet<TblItemCar>();
            TblOrder = new HashSet<TblOrder>();
            TblServiceCar = new HashSet<TblServiceCar>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int CatId { get; set; }
        public int Active { get; set; }

        public TblCarCategory Cat { get; set; }
        public ICollection<TblItemCar> TblItemCar { get; set; }
        public ICollection<TblOrder> TblOrder { get; set; }
        public ICollection<TblServiceCar> TblServiceCar { get; set; }
    }
}
