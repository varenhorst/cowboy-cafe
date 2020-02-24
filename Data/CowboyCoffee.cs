/*
 Author: Alex Varenhorst
 Modified: 2/16/2020 9:50pm
 Class: CIS-400 Object Oriented Design
 Description: Class representing the cowboy coffee
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class CowboyCoffee : Drink
    {
        /// <summary>
        /// Set the price of the coffee, depending on size.
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return .60;
                    case Size.Medium:
                        return 1.10;
                    case Size.Large:
                        return 1.60;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// Set the calores of the coffee, depending on size.
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 3;
                    case Size.Medium:
                        return 5;
                    case Size.Large:
                        return 7;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        private bool ice = false;
        /// <summary>
        /// If there is ice in the drink
        /// </summary>
        public override bool Ice
        {
            get { return ice; }
            set { ice = value; }
        }

        private bool roomforcream = false;
        /// <summary>
        /// if there is room for cream in the coffee
        /// </summary>
        public bool RoomForCream
        {
            get { return roomforcream; }
            set { roomforcream = value; }
        }

        private bool decaf = false;
        /// <summary>
        /// If coffee is decaf
        /// </summary>
        public bool Decaf
        {
            get { return decaf; }
            set { decaf = value; }
        }

        /// <summary>
        /// Sets the special instructions for the coffee
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();
                if (ice) instructions.Add("Add Ice");
                if (roomforcream) instructions.Add("Room for Cream");

                return instructions;
            }
        }

        /// <summary>
        /// Returns the human-readable string describing the order of cowboy coffee
        /// </summary>
        public override string ToString()
        {
            var size = this.Size.ToString();
           
            if(decaf)
            {
                return size + " Decaf Cowboy Coffee";
            }

            return size + " Cowboy Coffee";
           
        }
    }
}
