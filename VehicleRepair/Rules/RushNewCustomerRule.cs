using VehicleRepair.Models;

namespace VehicleRepair.Rules
{
    public class RushNewCustomerRule : Rule
    {
        public RushNewCustomerRule()
            : base(OrderStatus.AuthorisationRequired)
        {
        }

        public override bool IsMatch(OrderRequest orderRequest)
        {
            return orderRequest.IsRushOrder &&
                   orderRequest.IsNewCustomer;
        }
    }
}