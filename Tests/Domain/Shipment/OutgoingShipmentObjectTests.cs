using ISA3.Data.Shipment;
using ISA3.Domain.Shipment;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ISA3.Tests.Domain.Shipment
{
    [TestClass]
    public class OutgoingShipmentObjectTests : BaseTest<OutgoingShipmentObject, object>
    {
        protected object Obj;

        [TestInitialize]
        public override void TestInitialize()
        {
            Obj = new OutgoingShipmentData();
            Type = typeof(OutgoingShipmentData);
        }

        public override void IsInheritedTest()
        {
            Assert.AreEqual(typeof(ShipmentData), Type.BaseType);
        }

        [TestMethod]
        public void CanCreateTest()
        {
            Assert.IsNotNull(Obj);
        }
    }
}