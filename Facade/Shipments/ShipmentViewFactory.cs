using System;
using ISA3.Data.Shipment;
using ISA3.Domain.Shipment;

namespace ISA3.Facade.Shipments
{
    public static class ShipmentViewFactory
    {
        public static ShipmentObject Create(ShipmentView v)
        {
            var d = new ShipmentData
            {
                Id = Guid.NewGuid().ToString(),
                BillNumber = v.BillNumber,
                /*Country = v.CountryId.name,*/ // dropdown
                CountryId = v.CountryId,
                DeliveryNumber = v.DeliveryNumber,
                ArrivalDate = v.EstimatedArrivalDate,
                EstimatedReadyDate = v.EstimatedReadyDate,
                LandCadastre = v.LandCadastre,
                Notes = v.Notes,
                //TransportCompany = v.TransportCompanyId.name, // dropdown
                //ShippingCompany = v.TransportCompanyId.name, // dropdown
                TransportCompanyId = v.TransportCompanyId,
                ShippingCompanyId = v.ShippingCompanyId,

                OrderId = v.OrderId,
                ShipmentReportCreationDate = v.ShipmentReportCreationDate
            };
            return new ShipmentObject(d);
        }

        public static ShipmentView Create(IShipment o)
        {
            var obj = o as ShipmentObject;
            var v = new ShipmentView
            {
                Id = obj.Data.Id,
                BillNumber = obj.Data.BillNumber,
                //Country = o._incomingShipmentData.CountryId.name, 
                //Country = obj.Data.
                CountryId = obj.Data.CountryId,
                DeliveryNumber = obj.Data.DeliveryNumber,
                EstimatedArrivalDate = obj.Data.ArrivalDate,
                EstimatedReadyDate = obj.Data.EstimatedReadyDate,
                LandCadastre = obj.Data.LandCadastre,
                Notes = obj.Data.Notes,
                //TransportCompany = o._incomingShipmentData.TransportCompanyId.name,
                //ShippingCompany = o._incomingShipmentData.TransportCompanyId.name,
                TransportCompanyId = obj.Data.TransportCompanyId,
                ShippingCompanyId = obj.Data.ShippingCompanyId,
                OrderId = obj.Data.OrderId,
                ShipmentReportCreationDate = obj.Data.ShipmentReportCreationDate,
            };
            return v;
        }
    }
}
