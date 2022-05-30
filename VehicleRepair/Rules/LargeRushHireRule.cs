using VehicleRepair.Models;

namespace VehicleRepair.Rules
{
    public class LargeRushHireRule : Rule
    {
        public LargeRushHireRule()
            : base(OrderStatus.Closed)
        {
        }

        public override bool IsMatch(OrderRequest orderRequest)
        {
            return orderRequest.IsLargeOrder &&
                   orderRequest.IsRushOrder &&
                   orderRequest.OrderType == OrderType.Hire;
        }
    }
}