using ISA3.Domain.Order;
using System;

namespace ISA3.Domain.ShipmentCalculator
{
    public class ShipmentCalculatorObject : IShipmentCalculator
    {
        public void CalculateBillNumber()
        {
            throw new NotImplementedException();
        }

        public ushort CalculateLateDeliveryDays()
        {
            throw new NotImplementedException();
        }

        double IShipmentCalculator.CalculateVat()
        {
            throw new NotImplementedException();
        }

        public void CalculateOrderCost(OrderObject order)
        {
            throw new NotImplementedException();
        }
    }
}
