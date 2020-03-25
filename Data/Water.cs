/*
 Author: Alex Varenhorst
 Modified: 2/16/2020 9:50pm
 Class: CIS-400 Object Oriented Design
 Description: The class Water class
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class Water : Drink
    {

        private bool lemon = false;
        /// <summary>
        /// If there is lemon in the water
        /// </summary>
        public bool Lemon 
        {
            get
            {
                return lemon;
            }
            set
            {
                lemon = value;
                NotifyThatPropertyChanged("Lemon");
            }
        }

        private bool ice = true;
        /// <summary>
        /// if there is ice in the water.
        /// </summary>
        public override bool Ice 
        { 
            get
            {
                return ice;
            }
            set 
            {
                ice = value;
                NotifyThatPropertyChanged("Ice");
            } 
        }

        /// <summary>
        /// The price of the water
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return .12;
                    case Size.Medium:
                        return .12;
                    case Size.Large:
                        return .12;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// The calories of the water
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 0;
                    case Size.Medium:
                        return 0;
                    case Size.Large:
                        return 0;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// Set the special instructions for the water.
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (Lemon) instructions.Add("Add Lemon");
                if (!Ice) instructions.Add("Hold Ice");

                return instructions;
            }
        }

        /// <summary>
        /// Returns the human-readable string describing the order of water.
        /// </summary>
        public override string ToString()
        {
            switch (this.Size)
            {
                case Size.Small:
                    return "Small Water";

                case Size.Medium:
                    return "Medium Water";

                case Size.Large:
                    return "Large Water";
                default:
                    return "Small Water";
            }
        }
    }
}
