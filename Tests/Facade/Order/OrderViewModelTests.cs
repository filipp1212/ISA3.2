using ISA3.Facade.Order;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ISA3.Tests.Facade.Order
{
    [TestClass]
    public class OrderViewModelTests : ClassTest<OrderViewModel, object>
    {
        [TestMethod]
        public void Id()
        {
            IsNullableProperty(() => BaseObj.Id, x => BaseObj.Id = x);
        }

        [TestMethod]
        public void OrderItemDataObjects()
        {
            IsNullableProperty(() => BaseObj.OrderItemDataObjects, x => BaseObj.OrderItemDataObjects = x);
        }

        [TestMethod]
        public void ContentsDescription()
        {
            IsNullableProperty(() => BaseObj.ContentsDescription, x => BaseObj.ContentsDescription = x);
        }

        [TestMethod]
        public void TotalOrderValue()
        {
            IsProperty(() => BaseObj.TotalOrderValue, x => BaseObj.TotalOrderValue = x);
        }
    }
}