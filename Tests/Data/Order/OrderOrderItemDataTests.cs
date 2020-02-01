using ISA3.Data.Common;
using ISA3.Data.Order;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ISA3.Tests.Data.Order
{
    [TestClass]
    public class OrderOrderItemDataTests : ClassTest<OrderOrderItemData, UniqueEntityData>
    {
        [TestMethod]
        public void OrderId()
        {
            IsNullableProperty(() => BaseObj.OrderId, x => BaseObj.OrderId = x);
        }

        [TestMethod]
        public void OrderItemId()
        {
            IsNullableProperty(() => BaseObj.OrderItemId, x => BaseObj.OrderItemId = x);
        }

        [TestMethod]
        public void Order()
        {
            IsNullableProperty(() => BaseObj.Order, x => BaseObj.Order = x);
        }

        [TestMethod]
        public void OrderItem()
        {
            IsNullableProperty(() => BaseObj.OrderItem, x => BaseObj.OrderItem = x);
        }
    }
}