﻿/*
 Author: Alex Varenhorst
 Modified: 2/8/2020 9:50pm
 Class: CIS-400 Object Oriented Design
 Description: Class for the texas triple burger entree.
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class TexasTripleBurger : Entree
    {

        /// <summary>
        /// The price of the Triple Burger
        /// </summary>
        public override double Price
        {
            get
            {
                return 6.45;
            }
        }

        /// <summary>
        /// The calories of the Triple Burger
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 698;
            }
        }

        private bool tomato = true;
        /// <summary>
        /// If the burger comes with bun
        /// </summary>
        public bool Tomato
        {
            get { return tomato; }
            set 
            {
                tomato = value;
                NotifyOfPropertyChange("Tomato");
            }
        }

        private bool lettuce = true;
        /// <summary>
        /// If the burger comes with ketchup
        /// </summary>
        public bool Lettuce
        {
            get { return lettuce; }
            set 
            { 
                lettuce = value;
                NotifyOfPropertyChange("Lettuce");
            }
        }

        private bool mayo = true;
        /// <summary>
        /// If the burger comes with mayo
        /// </summary>
        public bool Mayo
        {
            get { return mayo; }
            set 
            { 
                mayo = value;
                NotifyOfPropertyChange("Mayo");
            }
        }

        private bool bacon = true;
        /// <summary>
        /// If the burger comes with mayo
        /// </summary>
        public bool Bacon
        {
            get { return bacon; }
            set 
            { 
                bacon = value;
                NotifyOfPropertyChange("Bacon");
            }
        }

        private bool egg = true;
        /// <summary>
        /// If the burger comes with mayo
        /// </summary>
        public bool Egg
        {
            get { return egg; }
            set 
            { 
                egg = value;
                NotifyOfPropertyChange("Egg");
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
        /// The special instructions for the Dakota Double Burger
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (!tomato) instructions.Add("hold tomato");
                if (!lettuce) instructions.Add("hold lettuce");
                if (!mayo) instructions.Add("hold mayo");
                if (!bun) instructions.Add("hold bun");
                if (!ketchup) instructions.Add("hold ketchup");
                if (!mustard) instructions.Add("hold mustard");
                if (!pickle) instructions.Add("hold pickle");
                if (!cheese) instructions.Add("hold cheese");
                if (!bacon) instructions.Add("hold bacon");
                if (!egg) instructions.Add("hold egg");

                return instructions;
            }
        }

        /// <summary>
        /// Retuns the string representation of the food item here.
        /// </summary>
        /// <returns>A string of the food item</returns>
        public override string ToString()
        {
            return "Texas Triple Burger";
        }
    }
}
