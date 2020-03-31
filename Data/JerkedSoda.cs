/*
 Author: Alex Varenhorst
 Modified: 2/16/2020 9:50pm
 Class: CIS-400 Object Oriented Design
 Description: Class representing jerked soda
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class JerkedSoda : Drink
    {
        private SodaFlavor flavor = SodaFlavor.CreamSoda;
        /// <summary>
        /// Property for the flavor
        /// </summary>
        public SodaFlavor Flavor 
        {
            get
            {
                return flavor;
            }
            set
            {
                flavor = value;
                NotifyThatPropertyChanged("Flavor");
            }
        }


        private bool ice = true;
        /// <summary>
        /// if the drink comes with Ice
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
        /// Set the price of the jerked soda, depending on size.
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 1.59;
                    case Size.Medium:
                        return 2.10;
                    case Size.Large:
                        return 2.59;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// Set the price of the drink, depending on size.
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 110;
                    case Size.Medium:
                        return 146;
                    case Size.Large:
                        return 198;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// Sets the special instructions
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (!ice) instructions.Add("Hold Ice");

                return instructions;
            }
        }

        /// <summary>
        /// Returns the human-readable string describing the order of jerked soda.
        /// </summary>
        public override string ToString()
        {
            var size = this.Size.ToString();
            var flavor = "";

            switch (this.Flavor) 
            {
                case SodaFlavor.CreamSoda:
                    flavor = "Cream Soda";
                    break;
                case SodaFlavor.BirchBeer:
                    flavor = "Birch Beer";
                    break;
                case SodaFlavor.OrangeSoda:
                    flavor = "Orange Soda";
                    break;
                case SodaFlavor.RootBeer:
                    flavor = "Root Beer";
                    break;
                case SodaFlavor.Sarsparilla:
                    flavor = "Sarsparilla";
                    break;
                default:
                    flavor = "Cream Soda";
                    break;
            }

            return size + " " + flavor + " Jerked Soda";
        }

    }
}
