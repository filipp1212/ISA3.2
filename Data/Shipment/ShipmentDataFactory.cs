using System;

namespace ISA3.Data.Shipment
{
    public class ShipmentDataFactory
    {
        public static ShipmentData Create(string Id,
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
            string notes)
        {
            var shipmentData = new ShipmentData()
            {
                Id = Id,
                BillNumber = billNumber,
                CountryId = countryId,
                DeliveryNumber = deliveryNumber,
                ArrivalDate = estimatedArrivalDate, // ?? string.Empty
                EstimatedReadyDate = estimatedReadyDate,
                ShipmentReportCreationDate = shipmentReportCreationDate,
                LandCadastre = landCadastre,
                OrderId = orderId,
                ShippingCompanyId = shippingCompanyId,
                TransportCompanyId = transportCompanyId,
                Notes = notes
            };
            return shipmentData;
        }
    }
}
