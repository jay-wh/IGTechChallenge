using VehicleRepair.Models;

namespace VehicleRepair.Rules
{
    public class LargeRepairRule : Rule
    {
        public LargeRepairRule()
            : base(OrderStatus.AuthorisationRequired)
        {
        }

        public override bool IsMatch(OrderRequest orderRequest)
        {
            return orderRequest.IsLargeOrder &&
                   orderRequest.OrderType == OrderType.Repair;
        }
    }
}