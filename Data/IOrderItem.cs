/*
 Author: Alex Varenhorst
 Modified: 3/3/2020 9:50pm
 Class: CIS-400 Object Oriented Design
 Description: The Iorderitem interface.
 */
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

        object CustomizationScreen { get; set; }

        string OrderType { get; set; }

        uint Calories { get; }

    }
}
