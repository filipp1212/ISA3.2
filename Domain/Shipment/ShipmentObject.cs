using ISA3.Data.Shipment;

namespace ISA3.Domain.Shipment
{
    public class ShipmentObject : IShipment
    {
        public readonly ShipmentData Data;
        public ShipmentObject(ShipmentData data)
        {
            Data = data;
        }
    }

   
}