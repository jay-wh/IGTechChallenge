using VehicleRepair.Models;

namespace VehicleRepair.Rules.Interfaces
{
    public interface IRule
    {
        public bool IsMatch(OrderRequest orderRequest);
    }
}