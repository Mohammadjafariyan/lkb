using System;
using System.Collections.Generic;

namespace WebApplication.abbas_lkb
{
    public partial class TblOrder
    {
        public TblOrder()
        {
            TblOrderItems = new HashSet<TblOrderItems>();
            TblOrderPay = new HashSet<TblOrderPay>();
            TblOrderRate = new HashSet<TblOrderRate>();
            TblTicket = new HashSet<TblTicket>();
        }

        public int Id { get; set; }
        public int Type { get; set; }
        public string Text { get; set; }
        public int CustomerId { get; set; }
        public int? CarId { get; set; }
        public DateTimeOffset Time { get; set; }
        public DateTime Date { get; set; }
        public int? TimeId { get; set; }
        public int? AddressId { get; set; }
        public int Status { get; set; }
        public int Price { get; set; }
        public int? DiscountId { get; set; }
        public int DelayPenalty { get; set; }
        public int InstallCost { get; set; }
        public int DisAmount { get; set; }
        public int DeliveryCost { get; set; }
        public int FinalPrice { get; set; }
        public int PayType { get; set; }
        public int? ServicemanId { get; set; }
        public DateTimeOffset CreatedAt { get; set; }
        public DateTimeOffset UpdatedAt { get; set; }
        public int NationalId { get; set; }
        public string Plaque { get; set; }
        public int DeliverType { get; set; }
        public int? DepotId { get; set; }
        public DateTimeOffset StopedAt { get; set; }
        public DateTimeOffset StartedAt { get; set; }

        public TblCustomerAddress Address { get; set; }
        public TblCar Car { get; set; }
        public TblCustomer Customer { get; set; }
        public TblDepot Depot { get; set; }
        public TblDiscount Discount { get; set; }
        public TblServiceman Serviceman { get; set; }
        public TblTimes TimeNavigation { get; set; }
        public ICollection<TblOrderItems> TblOrderItems { get; set; }
        public ICollection<TblOrderPay> TblOrderPay { get; set; }
        public ICollection<TblOrderRate> TblOrderRate { get; set; }
        public ICollection<TblTicket> TblTicket { get; set; }
    }
}
