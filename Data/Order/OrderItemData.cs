using ISA3.Data.Common;

namespace ISA3.Data.Order
{
    public sealed class OrderItemData : UniqueEntityData
    {
        public string OrderItemSeqId { get; set; }
        public string Quantity { get; set; }
        public string ShippingInstructions { get; set; }
    }
}
