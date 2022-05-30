using NUnit.Framework;
using VehicleRepair.Models;

namespace VehicleRepair.Tests
{
    public class OrderStatusAnalyzerTests
    {
        [Test]
        public void LargeRepairOrdersForNewCustomers_Should_Return_Closed()
        {
            var request = new OrderRequest
            {
                IsLargeOrder = true,
                OrderType = OrderType.Repair,
                IsNewCustomer = true
            };

            var orderStatus = OrderStatusAnalyzer.GetOrderStatus(request);

            Assert.AreEqual(OrderStatus.Closed, orderStatus);
        }

        [Test]
        public void LargeRushHireOrders_Should_Return_Closed()
        {
            var request = new OrderRequest
            {
                IsLargeOrder = true,
                OrderType = OrderType.Hire,
                IsRushOrder = true
            };

            var orderStatus = OrderStatusAnalyzer.GetOrderStatus(request);

            Assert.AreEqual(OrderStatus.Closed, orderStatus);
        }

        [Test]
        public void LargeRepairOrder_Should_Return_AuthorisationRequired()
        {
            var request = new OrderRequest
            {
                IsLargeOrder = true,
                OrderType = OrderType.Repair
            };

            var orderStatus = OrderStatusAnalyzer.GetOrderStatus(request);

            Assert.AreEqual(OrderStatus.AuthorisationRequired, orderStatus);
        }

        [Test]
        public void RushOrderNewCustomer_Should_Return_AuthorisationRequired()
        {
            var request = new OrderRequest
            {
                IsRushOrder = true,
                IsNewCustomer = true
            };

            var orderStatus = OrderStatusAnalyzer.GetOrderStatus(request);

            Assert.AreEqual(OrderStatus.AuthorisationRequired, orderStatus);
        }

        [Test]
        public void AllOtherOrders_Should_Return_Confirmed()
        {
            var request = new OrderRequest();
            var orderStatus = OrderStatusAnalyzer.GetOrderStatus(request);

            Assert.AreEqual(OrderStatus.Confirmed, orderStatus);
        }
    }
}