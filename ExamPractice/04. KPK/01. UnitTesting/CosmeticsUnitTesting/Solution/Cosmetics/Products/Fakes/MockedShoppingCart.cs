using Cosmetics.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmetics.Products.Fakes
{
    internal class MockedShoppingCart : ShoppingCart
    {
        public IList<IProduct> Products
        {
            get
            {
                return base.products;
            }
        }

    }
}
