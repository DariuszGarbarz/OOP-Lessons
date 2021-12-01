using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC.BL
{
    public class Product
    {
        public Product()
        {

        }

        public Product(int productId)
        {
            ProduktId = productId;
        }

        public int ProduktId { get; private set; }

        public Decimal? CurrentPrice { get; set; }
        public string Description { get; set; }
        public string ProductName { get; set; }

        public Product Load(int productId)
        {
            return new Product();
        }

        public bool Save()
        {
            return true;
        }

        public bool Validate()
        {
            var correct = true;

            if (string.IsNullOrWhiteSpace(ProductName))
            {
                correct = false;
            }

            return correct;
        }
    }
}
