using VehicleRepair.Models;

namespace VehicleRepair.Rules
{
    public abstract class Rule
    {
        public OrderStatus OrderStatus { get; }

        protected Rule(OrderStatus orderStatus)
        {
            OrderStatus = orderStatus;
        }

        public abstract bool IsMatch(OrderRequest orderRequest);
    }
}