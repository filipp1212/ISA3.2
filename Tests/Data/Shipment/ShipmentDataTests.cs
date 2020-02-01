using ISA3.Data.Common;
using ISA3.Data.Shipment;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ISA3.Tests.Data.Shipment
{
    [TestClass]
    public class ShipmentDataTests : ClassTest<ShipmentData, UniqueEntityData>
    {
        private class TestClass : ShipmentData { }

        [TestInitialize]
        public override void TestInitialize()
        {
            base.TestInitialize();
            BaseObj = new TestClass();
        }
        [TestMethod]
        public void BillNumber()
        {
            IsProperty(() => BaseObj.BillNumber, x => BaseObj.BillNumber = x);
        }

        [TestMethod]
        public void CountryId()
        {
            IsNullableProperty(() => BaseObj.CountryId, x => BaseObj.CountryId = x);
        }

        [TestMethod]
        public void Country()
        {
            IsNullableProperty(() => BaseObj.Country, x => BaseObj.Country = x);
        }

        [TestMethod]
        public void DeliveryNumber()
        {
            IsProperty(() => BaseObj.DeliveryNumber, x => BaseObj.DeliveryNumber = x);
        }

        [TestMethod]
        public void ArrivalDate()
        {
            IsNullableProperty(() => BaseObj.ArrivalDate, x => BaseObj.ArrivalDate = x);
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
        public void Order()
        {
            IsNullableProperty(() => BaseObj.Order, x => BaseObj.Order = x);
        }

        [TestMethod]
        public void ShippingCompanyId()
        {
            IsNullableProperty(() => BaseObj.ShippingCompanyId, x => BaseObj.ShippingCompanyId = x);
        }

        [TestMethod]
        public void ShippingCompany()
        {
            IsNullableProperty(() => BaseObj.ShippingCompany, x => BaseObj.ShippingCompany = x);
        }

        [TestMethod]
        public void TransportCompanyId()
        {
            IsNullableProperty(() => BaseObj.TransportCompanyId, x => BaseObj.TransportCompanyId = x);
        }

        [TestMethod]
        public void TransportCompany()
        {
            IsNullableProperty(() => BaseObj.TransportCompany, x => BaseObj.TransportCompany = x);
        }

        [TestMethod]
        public void Notes()
        {
            IsNullableProperty(() => BaseObj.Notes, x => BaseObj.Notes = x);
        }
    }
}