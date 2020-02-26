using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    //Interface representing a single item in an order.
    public interface IOrderItem
    {
        /// <summary>
        /// The price of this order item.
        /// </summary>
        double Price { get; }
        /// <summary>
        /// Special instructions for this Iorderitem
        /// </summary>
        List<string> SpecialInstructions { get; }

    }
}
