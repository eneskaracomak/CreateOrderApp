using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreateOrderApp.WebApi.Models
{
    public class BilingModel
    {
        public int ItemPrice { get; set; }
        public decimal Discount { get; set; }
        public decimal Tax { get; set; }
        public decimal TotalCost { get; set; }
    }
}
