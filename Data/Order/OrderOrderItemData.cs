using ISA3.Data.Common;

namespace ISA3.Data.Order
{
    public class OrderOrderItemData : UniqueEntityData
    {
        public string OrderId { get; set; }
        public string OrderItemId { get; set; }

        public virtual OrderData Order { get; set; }
        public virtual OrderItemData OrderItem { get; set; }
    }
}
