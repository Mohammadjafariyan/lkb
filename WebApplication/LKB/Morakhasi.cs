using System;
using System.Collections.Generic;

namespace WebApplication.LKB
{
    public partial class Morakhasi
    {
        public int Id { get; set; }
        public string MDate { get; set; }
        public DateTime? NowDate { get; set; }
        public byte IsHour { get; set; }
        public string SHour { get; set; }
        public string EHour { get; set; }
        public string User { get; set; }
        public string Message { get; set; }
        public int? Ref { get; set; }
        public byte Approved { get; set; }
    }
}
