/*
 Author: Alex Varenhorst
 Modified: 2/16/2020 9:50pm
 Class: CIS-400 Object Oriented Design
 Description: Class representing the Texas Tea
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class TexasTea : Drink
    {
        private bool sweet = true;
        /// <summary>
        /// if there is sweetner in the tea
        /// </summary>
        public bool Sweet
        {
            get { return sweet; }
            set 
            { 
                sweet = value;
                NotifyThatPropertyChanged("Sweet");
            }
        }

        private bool lemon = false;
        /// <summary>
        /// If there is lemon in the tea
        /// </summary>
        public bool Lemon
        {
            get { return lemon; }
            set 
            { 
                lemon = value;
                NotifyThatPropertyChanged("Lemon");
            }
        }

        private bool ice = true;
        /// <summary>
        /// If there is ice in the Texas Tea
        /// </summary>
        public override bool Ice {
            get { return ice; }
            set 
            { 
                ice = value;
                NotifyThatPropertyChanged("Ice");
            }
        }

        /// <summary>
        /// Set the price of the tea, depending on size.
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 1.00;
                    case Size.Medium:
                        return 1.50;
                    case Size.Large:
                        return 2.00;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// Set the price of the tea, depending on size.
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        if (sweet) return 10;
                        else return 5; 
                    case Size.Medium:
                        if (sweet) return 22;
                        else return 11;
                    case Size.Large:
                        if (sweet) return 36;
                        else return 18;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// get the special instructions for the Texas Tea.
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (!ice) instructions.Add("Hold Ice");
                if (lemon) instructions.Add("Add Lemon");

                return instructions;
            }
        }

        /// <summary>
        /// Returns the human-readable string describing the order of Texas Tea.
        /// </summary>
        public override string ToString()
        {
            var size = this.Size.ToString();

            if(sweet)
            {
                return size + " Texas Sweet Tea";
            }

            return size + " Texas Plain Tea"; 
        }
    }
}
