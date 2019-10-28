using System;
using System.Collections.Generic;

namespace WebApplication.abbas_lkb
{
    public partial class TblCarCategory
    {
        public TblCarCategory()
        {
            TblCar = new HashSet<TblCar>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int Active { get; set; }
        public string Pic { get; set; }

        public ICollection<TblCar> TblCar { get; set; }
    }
}
