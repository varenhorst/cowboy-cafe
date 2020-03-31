/*
 Author: Alex Varenhorst
 Modified: 3/23/2020 9:50pm
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
        static private uint lastOrderNumber;
        
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
                foreach (IOrderItem item in items)
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
                lastOrderNumber++;
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

            if(item is INotifyPropertyChanged changeditem)
            {
                changeditem.PropertyChanged += OnItemPropertyChanged;
            }

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

            if(item is INotifyPropertyChanged changeditem)
            {
                changeditem.PropertyChanged -= OnItemPropertyChanged;
            }
           
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
        }
        
        /// <summary>
        /// If the items property changed, invoke changes on price/subtotal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnItemPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("items"));
            if(e.PropertyName == "Price")
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
            }
        }

        /// <summary>
        /// Function to change the total, and the size based on size chosen
        /// </summary>
        public void ChangeSizeEnum()
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
        }

        /// <summary>
        /// Function to change total, and the flavor based on the flavor chosen. Only used in Jerked Soda.
        /// </summary>
        public void ChangeFlavorEnum()
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Flavor"));
        }
    }
}
