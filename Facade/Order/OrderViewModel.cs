using ISA3.Data.Order;
using System.Collections.Generic;

namespace ISA3.Facade.Order
{
    public class OrderViewModel
    {
        public string Id { get; set; }
        public List<OrderItemData> OrderItemDataObjects { get; set; }
        public string ContentsDescription { get; set; }
        public double TotalOrderValue { get; set; }
    }
}