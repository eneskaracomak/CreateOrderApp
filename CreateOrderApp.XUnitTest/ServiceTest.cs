using CreateOrderApp.Business.Abstract;
using CreateOrderApp.WebApi.Controllers;
using CreateOrderApp.XUnitTest.FakeModels;
using Microsoft.AspNetCore.Mvc;
using System;
using Xunit;

namespace CreateOrderApp.XUnitTest
{
    public class ServiceTest
    {
        private readonly IOrderService _orderService;

        public ServiceTest(IOrderService orderService)
        {
            _orderService = orderService;
 
        }
        
        [Fact]
        public void CreateOrder_Test()
        {
            OrderModel orderModel = new OrderModel();
            var res = _orderService.Add(orderModel._order);
            Assert.IsType<OkObjectResult>(res as OkObjectResult);

        }
    }
}
