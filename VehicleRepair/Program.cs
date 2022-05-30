using VehicleRepair.Models;

namespace VehicleRepair
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            var orderRequest = new OrderRequest
            {
                IsRushOrder = GetInputValueAsType<bool>("Is Rush Order?"),
                OrderType = GetInputValueAsType<OrderType>("Order Type?"),
                IsNewCustomer = GetInputValueAsType<bool>("Is New Customer?"),
                IsLargeOrder = GetInputValueAsType<bool>("Is Large Order?")
            };

            var orderStatus = OrderStatusAnalyzer.GetOrderStatus(orderRequest);

            Console.WriteLine($"Order status: {orderStatus}");
            Console.ReadLine();
        }

        private static T GetInputValueAsType<T>(string question)
        {
            try
            {
                Console.WriteLine(question);
                var valueAsString = Console.ReadLine();

                if (string.IsNullOrEmpty(valueAsString))
                {
                    return GetInputValueAsType<T>(question);
                }

                if (typeof(T).IsEnum)
                    return (T)Enum.Parse(typeof(T), valueAsString);

                return (T)Convert.ChangeType(valueAsString, typeof(T));
            }
            catch (Exception)
            {
                return GetInputValueAsType<T>(question);
            }
        }
    }
}