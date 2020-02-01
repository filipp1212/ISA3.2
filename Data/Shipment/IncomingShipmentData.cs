namespace ISA3.Data.Shipment
{
    public sealed class IncomingShipmentData : ShipmentData
    {
        public override ShipmentType ShipmentType => ShipmentType.Incoming;
    }
}