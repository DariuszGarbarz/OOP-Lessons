using System;
using System.Collections.Generic;

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
        public List<OrderPosition> orderPosition { get; set; }
        public int KlientId { get; set; }
        public int DeliveryAddressId { get; set; }

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
