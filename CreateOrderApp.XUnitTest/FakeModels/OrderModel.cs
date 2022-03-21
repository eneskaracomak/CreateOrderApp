using CreateOrderApp.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateOrderApp.XUnitTest.FakeModels
{
    class OrderModel
    {
        public readonly Order _order;
        public OrderModel()
        {
            _order = new Order() { AdressId = 1, CustomerId = 1, IsActive = true };
        }
    }
}
