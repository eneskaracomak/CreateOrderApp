using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CreateOrderApp.Business.Abstract;
using CreateOrderApp.Entities.Concrete;
using CreateOrderApp.WebApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CreateOrderApp.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private IOrderService _orderService;
        private IAdreService _adresService;
        private IOrderLineService _orderLineService;
        private IProductService _productService;
        private ICustomerService _customerService;
        private ICustomerAdreService _customerAdresService;
        public OrderController(IOrderService orderService, IAdreService adreService, IOrderLineService orderLineService, IProductService productService, ICustomerAdreService customerAdreService, ICustomerService customerService)
        {
            _orderService = orderService;
            _adresService = adreService;
            _orderLineService = orderLineService;
            _productService = productService;
            _customerService = customerService;
            _customerAdresService = customerAdreService;
        }




        [HttpPost(template: "CreateOrder")]
        public IActionResult CreateOrder([FromBody]OrderModel orderModel)
        {
            try
            {
                if (orderModel.ProductId >0 )
                {

                    var product = _productService.GetById(orderModel.ProductId);

                    if (product.Data == null)
                        return BadRequest("Product Not Found");

                    if (product.Data.Stock < orderModel.Stock)
                        return BadRequest("Insufficient Stock Amount.");

                    Order order = new Order();
                    order.AdressId = orderModel.Customer.AdressId;
                    order.CustomerId = orderModel.Customer.CustomerId;
                    order.IsActive = orderModel.Status;
                    var result = _orderService.Add(order);
                    if (result.Success)
                    {
                        OrderLine orderLine = new OrderLine();
                        orderLine.LineDiscount = orderModel.Biling.Discount;
                        orderLine.LineTax = orderModel.Biling.Tax;
                        orderLine.OrderId = 1;
                        orderLine.ProductId = orderModel.ProductId;
                        var orderLineAdd = _orderLineService.Add(orderLine);
                        if (orderLineAdd.Success)
                        {
                            decimal newStok = product.Data.Stock - orderModel.Quantity;
                            product.Data.Stock = newStok;
                            _productService.Update(product.Data);
                            return Ok(result.Message);

                        }
                        else
                        {
                            return BadRequest(orderLineAdd.Message);
                        }
                    }
                    else
                    {
                        return BadRequest(result.Message);

                    }


                }
                else
                {
                    return BadRequest("ModelState Not Valid.");
                }

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }



        }



    }
}
