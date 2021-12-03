using System;
using System.Collections.Generic;

namespace ABC.BL
{
    public class OrderViewcs
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTimeOffset OrderDate { get; set; }
        public List<OrderPositionView> OrderPositionViewList { get; set; }
        public int OrderId { get; set; }
        public Address DeliveryAddress { get; set; }



    }

}
