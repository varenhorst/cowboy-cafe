using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class RustlersRibs
    {
        /// <summary>
        /// The price of the ribs
        /// </summary>
        public double Price
        {
            get
            {
                return 7.50;
            }
        }

        /// <summary>
        /// The calories of the Ribs
        /// </summary>
        public uint Calories
        {
            get
            {
                return 894;
            }
        }

        public List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();
                return instructions;
            }
        }
    }
}
