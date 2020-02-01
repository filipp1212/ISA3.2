using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ISA3.Facade.Shipments
{
    public class ShipmentView
    {
        public string Id { get; set; }
        public string Type { get; set; }
        public uint BillNumber { get; set; }
        public string Country { get; set; }
        public string CountryId { get; set; }
        public uint DeliveryNumber { get; set; }
        [DataType(DataType.Date)]
        [DisplayName("Estimated ArrivalDate")]
        public DateTime? EstimatedArrivalDate { get; set; }
        [DataType(DataType.Date)]
        [DisplayName("Estimated ReadyDate")]
        public DateTime? EstimatedReadyDate { get; set; }
        [DataType(DataType.Date)]
        [DisplayName("Shipment ReadyDate")]
        public DateTime? ShipmentReportCreationDate { get; set; }
        public string LandCadastre { get; set; }

        public string OrderId { get; set; }
        public string ShippingCompanyId { get; set; }
        public string TransportCompanyId { get; set; }
        public string ShippingCompany { get; set; }
        public string TransportCompany { get; set; }
        public string Notes { get; set; }
    }
}