namespace ISA3.Data.Shipment
{
    public sealed class OutgoingShipmentData : ShipmentData
    {
        public override ShipmentType ShipmentType => ShipmentType.Outgoing;
    }
}