using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pro3_Sem3.Models
{
    public class CartItem
    {
        
        public int quantity { set; get; }
        public decimal Total { get; set; }
        public Food product { set; get; }

        public CartItem()
        {

        }
        
    }
}
