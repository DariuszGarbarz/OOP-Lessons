using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC.BL
{
    public class Product: BaseClass
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



        public override bool Validate()
        {
            var correct = true;

            if (string.IsNullOrWhiteSpace(ProductName))
            {
                correct = false;
            }

            return correct;
        }

        public override string ToString()
        {
            return ProductName;
        }
    }
}
