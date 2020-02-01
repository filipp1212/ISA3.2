using ISA3.Data.Shipment;
using System;

namespace ISA3.Domain.Shipment
{
    public class OutgoingShipmentFactory
    {
        public static OutgoingShipmentObject Create(
            string Id,
            uint billNumber,
            string countryId,
            uint deliveryNumber,
            DateTime estimatedArrivalDate,
            DateTime estimatedReadyDate,
            DateTime shipmentReportCreationDate,
            string landCadastre,
            string orderId,
            string shippingCompanyId,
            string transportCompanyId,
            string notes
            )
        {
            var outgoingShipmentData = new OutgoingShipmentData()
            {
                Id = Id,
                BillNumber = billNumber,
                CountryId = countryId,
                DeliveryNumber = deliveryNumber,
                ArrivalDate = estimatedArrivalDate,
                EstimatedReadyDate = estimatedReadyDate,
                ShipmentReportCreationDate = shipmentReportCreationDate,
                LandCadastre = landCadastre,
                OrderId = orderId,
                ShippingCompanyId = shippingCompanyId,
                TransportCompanyId = transportCompanyId,
                Notes = notes
            };

            return new OutgoingShipmentObject(outgoingShipmentData);
        }
    }
}
