using System;
using System.Collections.Generic;
using System.Text;

namespace Linq2
{
    internal class Siparis
    {
        public Siparis(int customerId, int productId)
        {
            CustomerId = customerId;
            ProductId = productId;
        }

        public int CustomerId { get; set; }
        public int ProductId { get; set; }


    }
}
