using ISA3.Data.Shipment;
using ISA3.Domain.Shipment;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace ISA3.Tests.Domain.Shipment
{
    [TestClass]
    public class OutgoingShipmentObjectsListTest : BaseTest<OutgoingShipmentObjectsList, List<OutgoingShipmentObject>>
    {
        protected object Obj;

        [TestInitialize]
        public override void TestInitialize()
        {
            Obj = new List<OutgoingShipmentData>();
            Type = typeof(List<OutgoingShipmentData>);
        }

        public override void IsInheritedTest()
        {
            Assert.AreEqual(typeof(List<OutgoingShipmentData>).BaseType, Type.BaseType);
        }

        [TestMethod]
        public void CanCreateTest()
        {
            Assert.IsNotNull(Obj);
        }
    }
}