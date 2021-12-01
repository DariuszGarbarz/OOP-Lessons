using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC.BL
{
    public class OrderPosition
    {
        public OrderPosition()
        {

        }

        public OrderPosition(int orderPositionId)
        {
            OrderPositionId = orderPositionId;
        }

        public int OrderPositionId { get; private set; }
        public int Count { get; set; }
        public int ProductId { get; set; }
        public decimal? Price { get; set; }

        public OrderPosition Load(int orderPositionId)
        {
            return new OrderPosition();
        }

        public bool Save()
        {
            return true;
        }

        public bool Validate()
        {
            var correct = true;

            if (Count <= 0)
            {
                correct = false;
            }
            if (ProductId <= 0)
                correct = false;
            if (Price == null)
                correct = false;
            return correct;
        }
    }
}

