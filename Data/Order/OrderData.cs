using ISA3.Data.Common;

namespace ISA3.Data.Order
{
    public sealed class OrderData : UniqueEntityData
    {
        public string ContentsDescription { get; set; }
        public double TotalOrderValue { get; set; }
    }
}