/*
 Author: Alex Varenhorst
 Modified: 3/3/2020 9:50pm
 Class: CIS-400 Object Oriented Design
 Description: Class that represents an order
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace CowboyCafe.Data
{
    public class Order : INotifyPropertyChanged
    {
        /// <summary>
        /// Number holding the number of the last order.
        /// </summary>
        static private uint lastOrderNumber = 0;
        
        /// <summary>
        /// List of IOrderItems
        /// </summary>
        private List<IOrderItem> items = new List<IOrderItem>();

        //event property.
        public event PropertyChangedEventHandler PropertyChanged;
        public IEnumerable<IOrderItem> Items => items.ToArray();

        /// <summary>
        /// Calculate Subtotal, based off the items in the array.
        /// </summary>
        public double Subtotal
        {
            get
            {
                double price = 0;
                foreach (var item in Items)
                {
                    price += item.Price;
                }
                return price;
            }
        }

        /// <summary>
        /// Calculate the order number.
        /// </summary>
        public uint orderNumber 
        { 
            get
            {
                int i = 0;
                foreach(var item in Items)
                {
                    i++;
                }
                if(i == 0)
                {
                    lastOrderNumber = lastOrderNumber + 1;
                    return lastOrderNumber;
                }
                return lastOrderNumber;
            }
        }
        
        /// <summary>
        /// On Add, invoke the event, and update he properties.
        /// </summary>
        /// <param name="item"></param>
        public void Add(IOrderItem item)
        {
            items.Add(item);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("orderNumber"));
        }
        /// <summary>
        /// On remove, invoke the event, and update he properties.
        /// </summary>
        /// <param name="item"></param>
        public void Remove(IOrderItem item)
        {
            items.Remove(item);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
        }
    }
}
