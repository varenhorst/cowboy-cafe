/*
 Author: Alex Varenhorst
 Modified: 3/3/2020 9:50pm
 Class: CIS-400 Object Oriented Design
 Description: The logic that drives the OrderControl
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using CowboyCafe.Data;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for OrderControl.xaml
    /// </summary>
    public partial class OrderControl : UserControl
    {
        public OrderControl()
        {
            InitializeComponent();
            //initialize the data to a new order.
            var data = new Order();

            DataContext = data;
        }

        /// <summary>
        /// If Item selection is clicked, create a new MenuItemSelectionControl
        /// </summary>
        /// <param name="snder"></param>
        /// <param name="e"></param>
        public void OnItemSelection_Click(object snder, RoutedEventArgs e)
        {
            Container.Child = new MenuItemSelectionControl();
        }

        /// <summary>
        /// Swap screen, set container.Child to given element.
        /// </summary>
        /// <param name="e"></param>
        public void SwapScreen(FrameworkElement e)
        {
            Container.Child = e;
        }

       /// <summary>
       /// Cancels the order | Sets the datacontext to a new order instance.
       /// </summary>
       /// <param name="sender"></param>
       /// <param name="e"></param>
        void OnRemoveOrder_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order)
            {
                DataContext = new Order();
                Container.Child = new MenuItemSelectionControl();
            }
        }

        /// <summary>
        /// Adds an order | Sets the datacontext to a new order instance.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnAddOrder_Click(object sender, RoutedEventArgs e)
        {
            if(DataContext is Order)
            {
                DataContext = new Order();
                Container.Child = new MenuItemSelectionControl();
            }
        }

        /// <summary>
        /// Calls ChangeSizeEnum on the order.
        /// </summary>
        public void ChangeSizeEnum()
        {
            if(DataContext is Order order)
            {
                order.ChangeSizeEnum();
            }
        }

        /// <summary>
        /// Calls ChangeFlavor enum to the order. Only pertains to jerked soda.
        /// </summary>
        public void ChangeFlavorEnum()
        {
            if(DataContext is Order order)
            {
                order.ChangeFlavorEnum();
            }
        }

    }
}
