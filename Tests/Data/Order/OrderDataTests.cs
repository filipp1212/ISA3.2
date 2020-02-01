using ISA3.Data.Common;
using ISA3.Data.Order;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ISA3.Tests.Data.Order
{
    [TestClass]
    public class OrderDataTests : ClassTest<OrderData, UniqueEntityData>
    {
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