/*
 Author: Alex Varenhorst
 Modified: 2/8/2020 9:50pm
 Class: CIS-400 Object Oriented Design
 Description: Class for the rustlers ribs entree.
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class RustlersRibs : Entree
    {
        /// <summary>
        /// The price of the ribs
        /// </summary>
        public override double Price
        {
            get
            {
                return 7.50;
            }
        }

        /// <summary>
        /// The calories of the Ribs
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 894;
            }
        }

        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();
                return instructions;
            }
        }
    }
}
