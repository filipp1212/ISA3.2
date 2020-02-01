using ISA3.Data.Common;
using ISA3.Data.Order;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ISA3.Tests.Data.Order
{
    [TestClass]
    public class OrderItemDataTests : ClassTest<OrderItemData, UniqueEntityData>
    {
        [TestMethod]
        public void OrderItemSeqId()
        {
            IsNullableProperty(() => BaseObj.OrderItemSeqId, x => BaseObj.OrderItemSeqId = x);
        }
        [TestMethod]
        public void Quantity()
        {
            IsNullableProperty(() => BaseObj.Quantity, x => BaseObj.Quantity = x);
        }
        [TestMethod]
        public void ShippingInstructions()
        {
            IsNullableProperty(() => BaseObj.ShippingInstructions, x => BaseObj.ShippingInstructions = x);
        }
    }
}