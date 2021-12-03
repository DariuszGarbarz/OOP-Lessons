namespace ABC.BL
{
    public class ProductRepository
    {

        public ProductRepository()
        {

        }

        public Product Load(int productId)
        {
            //hard codding fdor tests
            Product product = new Product(productId);
            
            if(productId == 1)
            {
                product.ProductName = "rig";
                product.Description = "rig dla simracera";
                product.CurrentPrice = 1990.89M;
            }

            return product;
        }

        public bool Save(Product product)
        {
            var success = true;

            if (product.HasChanges && product.IsValid)
            {
                if (product.IsNew)
                {
                    // insert procedure
                }
                else
                {
                    //update procedure
                }
            }


            return success;
        }
    }
}
