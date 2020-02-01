using ISA3.Data.Shipment;
using System;
using System.Collections.Generic;

namespace ISA3.Domain.Shipment
{
    public class IncomingShipmentObjectsList : List<IncomingShipmentObject>
    {
        public IncomingShipmentObjectsList(IEnumerable<IncomingShipmentData> shipmentData)
        {
            foreach (var data in shipmentData)
            {
                Add(IncomingShipmentFactory.Create(
                    data.Id,
                    data.BillNumber,
                    data.CountryId,
                    data.DeliveryNumber,
                    data.ArrivalDate ?? DateTime.MaxValue,
                    data.EstimatedReadyDate ?? DateTime.MaxValue,
                    data.ShipmentReportCreationDate ?? DateTime.Now,
                    data.LandCadastre,
                    data.OrderId,
                    data.ShippingCompanyId,
                    data.TransportCompanyId,
                    data.Notes));
            }
        }
    }
}
