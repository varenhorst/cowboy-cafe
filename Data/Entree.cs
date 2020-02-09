/*
 Author: Alex Varenhorst
 Modified: 2/8/2020 9:50pm
 Class: CIS-400 Object Oriented Design
 Description: Abstract base class for Entree's. Inherited by all entree classes
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public abstract class Entree
    {
        /// <summary>
        /// Gets the price of the entree
        /// </summary>
        public abstract double Price { get; }

        /// <summary>
        /// Gets the calories of the entree
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// Gets the speial instructions for the entree.
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }
    }
}
