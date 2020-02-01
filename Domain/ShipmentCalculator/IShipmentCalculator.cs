using ISA3.Domain.Order;

namespace ISA3.Domain.ShipmentCalculator
{
    public interface IShipmentCalculator
    {
        void CalculateBillNumber();
        ushort CalculateLateDeliveryDays();
        double CalculateVat();
        void CalculateOrderCost(OrderObject order);
    }
}