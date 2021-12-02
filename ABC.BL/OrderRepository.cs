using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC.BL
{
    public class OrderRepository
    {


        public Order Load(int orderId)
        {
            var order = new Order(orderId);
            if(orderId == 1)
            {
                order.OrderDate = new DateTimeOffset(2018, 4, 14, 10, 00, 00, new TimeSpan(7, 0, 0));
            }

            return order;
        }

        public bool Save()
        {
            return true;
        }
    }
}
