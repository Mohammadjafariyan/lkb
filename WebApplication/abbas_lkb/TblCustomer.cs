using System;
using System.Collections.Generic;

namespace WebApplication.abbas_lkb
{
    public partial class TblCustomer
    {
        public TblCustomer()
        {
            TblCustomerAddress = new HashSet<TblCustomerAddress>();
            TblCustomerGcm = new HashSet<TblCustomerGcm>();
            TblCustomerPoint = new HashSet<TblCustomerPoint>();
            TblDiscount = new HashSet<TblDiscount>();
            TblOrder = new HashSet<TblOrder>();
            TblTicket = new HashSet<TblTicket>();
        }

        public int Id { get; set; }
        public string Phone { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Mail { get; set; }
        public int Active { get; set; }
        public string ActivationCode { get; set; }
        public DateTimeOffset ActivationTs { get; set; }
        public string ApiKey { get; set; }
        public DateTimeOffset CreatedAt { get; set; }
        public int? ReagentId { get; set; }

        public ICollection<TblCustomerAddress> TblCustomerAddress { get; set; }
        public ICollection<TblCustomerGcm> TblCustomerGcm { get; set; }
        public ICollection<TblCustomerPoint> TblCustomerPoint { get; set; }
        public ICollection<TblDiscount> TblDiscount { get; set; }
        public ICollection<TblOrder> TblOrder { get; set; }
        public ICollection<TblTicket> TblTicket { get; set; }
    }
}
