using System;
using System.Collections.Generic;

namespace WebApplication.abbas_lkb
{
    public partial class TblServiceman
    {
        public TblServiceman()
        {
            TblOrder = new HashSet<TblOrder>();
            TblServicemanTrack = new HashSet<TblServicemanTrack>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Password { get; set; }
        public int Active { get; set; }
        public string ApiKey { get; set; }

        public ICollection<TblOrder> TblOrder { get; set; }
        public ICollection<TblServicemanTrack> TblServicemanTrack { get; set; }
    }
}
