using ISA3.Aids;
using ISA3.Domain.Shipment;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ISA3.Tests.Domain.Shipment
{
    [TestClass]
    public class OutgoingShipmentFactoryTests : ClassTest<OutgoingShipmentFactory, object>
    {
        [TestMethod]
        public void Create()
        {
            OutgoingShipmentObject testObject = OutgoingShipmentFactory.Create(
                GetRandom.String(),
                GetRandom.UInt32(),
                GetRandom.String(),
                GetRandom.UInt32(),
                GetRandom.DateTime(),
                GetRandom.DateTime(),
                GetRandom.DateTime(),
                GetRandom.String(),
                GetRandom.String(),
                GetRandom.String(),
                GetRandom.String(),
                GetRandom.String()
            );
            IsNullableProperty(() => testObject.Data.Id, x => testObject.Data.Id = x);
            IsProperty(() => testObject.Data.BillNumber, x => testObject.Data.BillNumber = x);
            IsNullableProperty(() => testObject.Data.CountryId, x => testObject.Data.CountryId = x);
            IsProperty(() => testObject.Data.DeliveryNumber, x => testObject.Data.DeliveryNumber = x);
            IsProperty(() => testObject.Data.ArrivalDate, x => testObject.Data.ArrivalDate = x);
            IsProperty(() => testObject.Data.EstimatedReadyDate, x => testObject.Data.EstimatedReadyDate = x);
            IsProperty(() => testObject.Data.ShipmentReportCreationDate, x => testObject.Data.ShipmentReportCreationDate = x);
            IsNullableProperty(() => testObject.Data.LandCadastre, x => testObject.Data.LandCadastre = x);
            IsNullableProperty(() => testObject.Data.OrderId, x => testObject.Data.OrderId = x);
            IsNullableProperty(() => testObject.Data.ShippingCompanyId, x => testObject.Data.ShippingCompanyId = x);
            IsNullableProperty(() => testObject.Data.TransportCompanyId, x => testObject.Data.TransportCompanyId = x);
            IsNullableProperty(() => testObject.Data.Notes, x => testObject.Data.Notes = x);

            Assert.AreEqual(testObject.GetType(), OutgoingShipmentFactory.Create(
                GetRandom.String(),
                GetRandom.UInt32(),
                GetRandom.String(),
                GetRandom.UInt32(),
                GetRandom.DateTime(),
                GetRandom.DateTime(),
                GetRandom.DateTime(),
                GetRandom.String(),
                GetRandom.String(),
                GetRandom.String(),
                GetRandom.String(),
                GetRandom.String()).GetType());
                
        }
    }
}