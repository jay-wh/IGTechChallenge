using VehicleRepair.Models;

namespace VehicleRepair.Rules
{
    public class LargeRepairNewCustomerRule : Rule
    {
        public LargeRepairNewCustomerRule()
            : base(OrderStatus.Closed)
        {
        }

        public override bool IsMatch(OrderRequest orderRequest)
        {
            return orderRequest.IsLargeOrder &&
                   orderRequest.IsNewCustomer &&
                   orderRequest.OrderType == OrderType.Repair;
        }
    }
}