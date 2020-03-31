/*
 Author: Alex Varenhorst
 Modified: 2/16/2020 9:50pm
 Class: CIS-400 Object Oriented Design
 Description: The Drink base class
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A base class representing a side
    /// </summary>
    public abstract class Drink : IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// Customization screen | IOrderItem
        /// </summary>
        public object CustomizationScreen { get; set; }

        /// <summary>
        /// Event handler for property changes
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;


        private Size size = Size.Small;
        /// <summary>
        /// Gets the size of the drink
        /// </summary>
        public virtual Size Size {
            get
            {
                return size;
            }
            set
            {
                size = value;
                NotifyThatPropertyChanged("Size");
            }
        }

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


        private bool ice = true;
        /// <summary>
        /// Whether or not there is ice in the drink
        /// </summary>
        public virtual bool Ice {
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
        /// Notifies that the property has changed, based on Drinks
        /// </summary>
        /// <param name="propertyChanged"></param>
        protected void NotifyThatPropertyChanged(string propertyChanged)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyChanged));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Size"));
        }
    }
}
