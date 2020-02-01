using ISA3.Data.Shipment;

namespace ISA3.Domain.Shipment
{
    public class OutgoingShipmentObject : IShipment
    {
        public readonly OutgoingShipmentData Data;

        public OutgoingShipmentObject(OutgoingShipmentData r)
        {
            Data = r;
        }
    }
}
