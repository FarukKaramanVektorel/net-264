using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Inheritance
{
    internal class Sell
    {

        public void sell(Product product) // uses a
        {
            if (product != null)
            {
                Console.WriteLine(product.Name + " satıldı...");
            }
        }
    }
}
