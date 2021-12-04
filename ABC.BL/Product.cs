using System;
using Common;

namespace ABC.BL
{
    public class Product: BaseClass, ILog
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
        private string _productName;

        public string ProductName
        {
            get { return _productName.SpaceInsert(); }
            set { _productName = value; }
        }




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

        public string Log()
        {
            var logText = ProduktId + ": " +
                            ProductName + " " +
                            "Opis: " + Description + " " +
                            "Status: " + ObjectCondition.ToString();

            return logText;

        }

    }
}
