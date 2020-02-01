using ISA3.Facade.Shipments;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ISA3.Tests.Facade.Shipments
{
    [TestClass]
    public class ShipmentViewTests : ClassTest<ShipmentView, object>
    {
        private class TestClass : ShipmentView { }

        [TestInitialize]
        public override void TestInitialize()
        {
            base.TestInitialize();
            BaseObj = new TestClass();
        }

        [TestMethod]
        public void Id()
        {
            IsNullableProperty(() => BaseObj.Id, x => BaseObj.Id = x);
        }
        [TestMethod]
        public void BillNumber()
        {
            IsProperty(() => BaseObj.BillNumber, x => BaseObj.BillNumber = x);
        }
        [TestMethod]
        public void Country()
        {
            IsNullableProperty(() => BaseObj.Country, x => BaseObj.Country = x);
        }
        [TestMethod]
        public void CountryId()
        {
            IsNullableProperty(() => BaseObj.CountryId, x => BaseObj.CountryId = x);
        }
        [TestMethod]
        public void DeliveryNumber()
        {
            IsProperty(() => BaseObj.DeliveryNumber, x => BaseObj.DeliveryNumber = x);
        }
        [TestMethod]
        public void EstimatedArrivalDate()
        {
            IsNullableProperty(() => BaseObj.EstimatedArrivalDate, x => BaseObj.EstimatedArrivalDate = x);
        }
        [TestMethod]
        public void EstimatedReadyDate()
        {
            IsNullableProperty(() => BaseObj.EstimatedReadyDate, x => BaseObj.EstimatedReadyDate = x);
        }
        [TestMethod]
        public void ShipmentReportCreationDate()
        {
            IsNullableProperty(() => BaseObj.ShipmentReportCreationDate, x => BaseObj.ShipmentReportCreationDate = x);
        }
        [TestMethod]
        public void LandCadastre()
        {
            IsNullableProperty(() => BaseObj.LandCadastre, x => BaseObj.LandCadastre = x);
        }
        [TestMethod]
        public void OrderId()
        {
            IsNullableProperty(() => BaseObj.OrderId, x => BaseObj.OrderId = x);
        }
        [TestMethod]
        public void ShippingCompanyId()
        {
            IsNullableProperty(() => BaseObj.ShippingCompanyId, x => BaseObj.ShippingCompanyId = x);
        }
        [TestMethod]
        public void TransportCompanyId()
        {
            IsNullableProperty(() => BaseObj.TransportCompanyId, x => BaseObj.TransportCompanyId = x);
        }
        [TestMethod]
        public void Notes()
        {
            IsNullableProperty(() => BaseObj.Notes, x => BaseObj.Notes = x);
        }
    }
}