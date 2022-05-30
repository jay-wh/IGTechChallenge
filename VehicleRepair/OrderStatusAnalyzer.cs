using VehicleRepair.Models;
using VehicleRepair.Rules;

namespace VehicleRepair
{
    public static class OrderStatusAnalyzer
    {
        private static readonly List<Rule> Rules = new List<Rule>
        {
            new LargeRepairNewCustomerRule(),
            new LargeRushHireRule(),
            new LargeRepairRule(),
            new RushNewCustomerRule()
        };

        public static OrderStatus GetOrderStatus(OrderRequest orderRequest)
        {
            foreach (var rule in Rules)
            {
                if (rule.IsMatch(orderRequest))
                {
                    return rule.OrderStatus;
                }
            }

            return OrderStatus.Confirmed;
        }
    }
}