using ISA3.Data.Shipment;
using ISA3.Domain.Shipment;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace ISA3.Tests.Domain.Shipment
{
    [TestClass]
    public class IncomingShipmentObjectsListTests : BaseTest<IncomingShipmentObjectsList, List<IncomingShipmentObject>>
    {
        protected object Obj;

        [TestInitialize]
        public override void TestInitialize()
        {
            Obj = new List<IncomingShipmentData>();
            Type = typeof(List<IncomingShipmentData>);
        }

        public override void IsInheritedTest()
        {
            Assert.AreEqual(typeof(List<IncomingShipmentData>).BaseType, Type.BaseType);
        }

        [TestMethod]
        public void CanCreateTest()
        {
            Assert.IsNotNull(Obj);
        }
    }
}