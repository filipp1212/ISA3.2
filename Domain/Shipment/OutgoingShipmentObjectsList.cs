using System;
using System.Collections.Generic;
using ISA3.Data.Shipment;

namespace ISA3.Domain.Shipment
{
    public class OutgoingShipmentObjectsList : List<OutgoingShipmentObject>
    {
        public OutgoingShipmentObjectsList(IEnumerable<OutgoingShipmentData> shipmentData)
        {
            foreach (var data in shipmentData)
            {
                Add(OutgoingShipmentFactory.Create(
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