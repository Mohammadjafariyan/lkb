using System;
using System.Collections.Generic;

namespace WebApplication.abbas_lkb
{
    public partial class TblServicemanTrack
    {
        public int Id { get; set; }
        public int ServicemanId { get; set; }
        public double Lat { get; set; }
        public double Lng { get; set; }
        public DateTimeOffset CreatedAt { get; set; }

        public TblServiceman Serviceman { get; set; }
    }
}
