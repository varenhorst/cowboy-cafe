﻿/*
 Author: Alex Varenhorst
 Modified: 2/16/2020 9:50pm
 Class: CIS-400 Object Oriented Design
 Description: The Drink base class
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A base class representing a side
    /// </summary>
    public abstract class Drink : IOrderItem
    {
        /// <summary>
        /// Gets the size of the drink
        /// </summary>
        public virtual Size Size { get; set; } = Size.Small;

        /// <summary>
        /// Gets the price of the drink
        /// </summary>
        public abstract double Price { get; }

        /// <summary>
        /// Gets the calories of the drink
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// Gets the special instructions for the drink
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }

        /// <summary>
        /// Whether or not there is ice in the drink
        /// </summary>
        public abstract bool Ice { get; set; }

    }
}
