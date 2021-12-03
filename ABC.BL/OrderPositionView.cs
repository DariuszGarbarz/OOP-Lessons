namespace ABC.BL
{
    public class OrderPositionView
    {
        public int OrderPositionId { get; set; }
        public int OrderQuantity { get; set; }
        public string ProductName { get; set; }
        public decimal? PurchasePrice { get; set; }

    }
}