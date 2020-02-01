using System;
using ISA3.Data.Shipment;
using ISA3.Domain.Shipment;

namespace ISA3.Facade.Shipments
{
    public static class OutgoingShipmentViewFactory
    {
        //public List<CountryData> CountryList { get; set; }
        public static OutgoingShipmentObject Create(OutgoingShipmentView v)
        {
            var d = new OutgoingShipmentData
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
                ShippingCompanyId = v.TransportCompanyId,

                OrderId = v.OrderId,
                ShipmentReportCreationDate = v.ShipmentReportCreationDate
            };
            return new OutgoingShipmentObject(d);
        }

        public static OutgoingShipmentView Create(IShipment o)
        {
            var obj = o as OutgoingShipmentObject;
            var v = new OutgoingShipmentView
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
                ShippingCompanyId = obj.Data.TransportCompanyId,
                OrderId = obj.Data.OrderId,
                ShipmentReportCreationDate = obj.Data.ShipmentReportCreationDate,
            };
            return v;
        }
    }
}
