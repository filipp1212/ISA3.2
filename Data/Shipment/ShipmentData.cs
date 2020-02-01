using System;
using ISA3.Data.Common;
using ISA3.Data.Country;
using ISA3.Data.Order;
using ISA3.Data.Party;

namespace ISA3.Data.Shipment
{
    public class ShipmentData : UniqueEntityData
    {
        public uint BillNumber { get; set; }
        public string CountryId { get; set; }
        public virtual CountryData Country { get; set; }
        public uint DeliveryNumber { get; set; }
        public DateTime? ArrivalDate { get; set; }
        public DateTime? EstimatedReadyDate { get; set; }
        public DateTime? ShipmentReportCreationDate { get; set; }
        public string LandCadastre { get; set; }
        public string OrderId { get; set; }
        public virtual OrderData Order { get; set; }
        public string ShippingCompanyId { get; set; }
        public virtual OrganizationData ShippingCompany { get; set; }
        public string TransportCompanyId { get; set; }
        public virtual OrganizationData TransportCompany { get; set; }
        public string Notes { get; set; }

        public virtual ShipmentType ShipmentType { get; }
    }
}