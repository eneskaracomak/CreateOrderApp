using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreateOrderApp.WebApi.Models
{
    public class OrderModel
    {
        public int ProductId { get; set; }
        public decimal Quantity { get; set; }
        public decimal Stock { get; set; }
        public CustomerModel Customer { get; set; }
        public BilingModel Biling { get; set; }
        public bool Status { get; set; }

    }
}
