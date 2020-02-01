using ISA3.Data.Shipment;

namespace ISA3.Domain.Shipment
{
    public class IncomingShipmentObject : IShipment
    {
        public readonly IncomingShipmentData Data;

        public IncomingShipmentObject(IncomingShipmentData r)
        {
            Data = r;
        }
    }
}
