﻿/*
 Author: Alex Varenhorst
 Modified: 2/8/2020 9:50pm
 Class: CIS-400 Object Oriented Design
 Description: Class for the trailburger entree.
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class TrailBurger : Entree,IOrderItem
    {
        /// <summary>
        /// The price of the trail burger
        /// </summary>
        public override double Price
        {
            get
            {
                return 4.50;
            }
        }

        /// <summary>
        /// The calories of the trail burger
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 288;
            }
        }

        private bool bun = true;
        /// <summary>
        /// If there chicken comes with bun
        /// </summary>
        public bool Bun
        {
            get { return bun; }
            set 
            { 
                bun = value;
                NotifyOfPropertyChange("Bun");
            }
        }

        private bool ketchup = true;
        /// <summary>
        /// If the chicken comes with ketchup
        /// </summary>
        public bool Ketchup
        {
            get { return ketchup; }
            set 
            {
                ketchup = value;
                NotifyOfPropertyChange("Ketchup");
            }
        }

        private bool mustard = true;
        /// <summary>
        /// If the chicken comes with mustard
        /// </summary>
        public bool Mustard
        {
            get { return mustard; }
            set 
            { 
                mustard = value;
                NotifyOfPropertyChange("Mustard");

            }
        }

        private bool pickle = true;
        /// <summary>
        /// If the chicken comes with Pickle
        /// </summary>
        public bool Pickle
        {
            get { return pickle; }
            set 
            {
                pickle = value;
                NotifyOfPropertyChange("Pickle");
            }
        }

        private bool cheese = true;
        /// <summary>
        /// If the chicken comes with cheese
        /// </summary>
        public bool Cheese
        {
            get { return cheese; }
            set 
            { 
                cheese = value;
                NotifyOfPropertyChange("Cheese");
            }
        }

        /// <summary>
        /// The special instructions for the angry chicken
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (!bun) instructions.Add("hold bun");
                if (!ketchup) instructions.Add("hold ketchup");
                if (!mustard) instructions.Add("hold mustard");
                if (!pickle) instructions.Add("hold pickle");
                if (!cheese) instructions.Add("hold cheese");

                return instructions;
            }
        }
        /// <summary>
        /// Retuns the string representation of the food item here.
        /// </summary>
        /// <returns>A string of the food item</returns>
        public override string ToString()
        {
            return "Trail Burger";
        }
    }
}
