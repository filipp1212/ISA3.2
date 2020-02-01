using ISA3.Data.Shipment;
using ISA3.Domain.Shipment;
using System;
using System.Diagnostics;

namespace ISA3.Facade.Shipments
{
    public static class IncomingShipmentViewFactory
    {
        public static IncomingShipmentObject Create(IncomingShipmentView v)
        {
            var d = new IncomingShipmentData
            {
                Id = Guid.NewGuid().ToString(),
                BillNumber = v.BillNumber,
                CountryId = v.CountryId,
                DeliveryNumber = v.DeliveryNumber,
                ArrivalDate = v.EstimatedArrivalDate,
                EstimatedReadyDate = v.EstimatedReadyDate,
                LandCadastre = v.LandCadastre,
                Notes = v.Notes,
                TransportCompanyId = v.TransportCompanyId,
                ShippingCompanyId = v.TransportCompanyId,

                OrderId = v.OrderId,
                ShipmentReportCreationDate = v.ShipmentReportCreationDate
            };
            return new IncomingShipmentObject(d);
        }

        public static IncomingShipmentView Create(IShipment o)
        {
            var obj = o as IncomingShipmentObject;
            Debug.Assert(obj != null, nameof(obj) + " != null");
            var v = new IncomingShipmentView
            {
                Id = obj.Data.Id,
                BillNumber = obj.Data.BillNumber,
                CountryId = obj.Data.CountryId,
                DeliveryNumber = obj.Data.DeliveryNumber,
                EstimatedArrivalDate = obj.Data.ArrivalDate,
                EstimatedReadyDate = obj.Data.EstimatedReadyDate,
                LandCadastre = obj.Data.LandCadastre,
                Notes = obj.Data.Notes,
                TransportCompanyId = obj.Data.TransportCompanyId,
                ShippingCompanyId = obj.Data.TransportCompanyId,
                OrderId = obj.Data.OrderId,
                ShipmentReportCreationDate = obj.Data.ShipmentReportCreationDate,
            };
            return v;
        }
    }
}
