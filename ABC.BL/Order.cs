using System;

namespace ABC.BL
{
    public class Order
    {
        public Order()
        {

        }

        public Order(int orderId)
        {
            OrderId = orderId;
        }

        public int OrderId { get; private set; }
        public DateTimeOffset? OrderDate { get; set; }

        public Order Load(int orderId)
        {
            return new Order();
        }

        public bool Save()
        {
            return true;
        }

        public bool Validate()
        {
            var correct = true;

            if (OrderDate == null)
            {
                correct = false;
            }

            return correct;
        }
    }
}
