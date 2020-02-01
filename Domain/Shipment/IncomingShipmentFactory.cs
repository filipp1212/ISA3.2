using ISA3.Data.Shipment;
using System;

namespace ISA3.Domain.Shipment
{
    public class IncomingShipmentFactory
    {
        public static IncomingShipmentObject Create(
            string id,
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
            var incomingShipmentData = new IncomingShipmentData()
            {
                Id = id,
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

            return new IncomingShipmentObject(incomingShipmentData);
        }
    }
}
