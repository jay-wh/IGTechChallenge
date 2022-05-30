using VehicleRepair.Models;
using VehicleRepair.Rules.Interfaces;

namespace VehicleRepair.Rules
{
    public abstract class Rule : IRule
    {
        public OrderStatus OrderStatus { get; }

        protected Rule(OrderStatus orderStatus)
        {
            OrderStatus = orderStatus;
        }

        public abstract bool IsMatch(OrderRequest orderRequest);
    }
}