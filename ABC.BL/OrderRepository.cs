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
        // Loading order to display
        public OrderViewcs LoadOrderToDisplay(int orderId)
        {
            OrderViewcs orderView = new OrderViewcs();
            //hard coded for testing purposes
            if(orderId == 10)
            {
                orderView.Name = "Dariusz";
                orderView.Surname = "Mariusz";
                orderView.OrderDate = new DateTimeOffset(2018, 4, 14, 10, 00, 00, new TimeSpan(7, 0, 0));
                orderView.DeliveryAddress = new Address()
                {
                    AddressType = 1,
                    Street = "happystreet",
                    City = "New York",
                    PostalCode = "00-000",
                    Country = "USA"
                };
            }
            orderView.OrderPositionViewList = new List<OrderPositionView>();
            //
            if (orderId == 10)
            {
                var orderPositionView = new OrderPositionView()
                {
                    ProductName = "Rig",
                    OrderQuantity = 1,
                    PurchasePrice = 119M
                };
                orderView.OrderPositionViewList.Add(orderPositionView);

                orderPositionView = new OrderPositionView()
                {
                    ProductName = "Screen",
                    OrderQuantity = 3,
                    PurchasePrice = 1200.99M
                };
                orderView.OrderPositionViewList.Add(orderPositionView);
            }

            return orderView;


        }




        public bool Save(Order order)
        {

            var success = true;

            if (order.HasChanges && order.IsValid)
            {
                if (order.IsNew)
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
