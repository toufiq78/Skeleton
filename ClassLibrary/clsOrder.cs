using System;

namespace ClassLibrary
{
    public class clsOrder
    {
        public bool Status { get; set; }
        public DateTime Date { get; set; }
        public int OrderId { get; set; }
        public string OrderName { get; set; }
        public int OrderPrice { get; set; }
        public float Price { get; set; }
        public int OrderQuantity { get; set; }
        public string PaymentMethod { get; set; }
    }
}