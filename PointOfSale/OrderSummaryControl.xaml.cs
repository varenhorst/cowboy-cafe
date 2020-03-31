/*
 Author: Alex Varenhorst
 Modified: 3/3/2020 9:50pm
 Class: CIS-400 Object Oriented Design
 Description: Class that drives the order summary control
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
using CowboyCafe.Extensions;
using PointOfSale;
using PointOfSale.CustomizationScreens;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for OrderSummaryControl.xaml
    /// </summary>
    public partial class OrderSummaryControl : UserControl
    {
        public OrderSummaryControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Method for the remove-item button next to each order. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnItemRemoval_Click(object sender, RoutedEventArgs e)
        {
            if(DataContext is Order data)
            {
                if(sender is Button button)
                {
                    if(button.DataContext is IOrderItem item)
                    {
                        data.Remove(item);
                    }
                }
            }
        }

        /// <summary>
        /// Method for when a user clicks on an item in the OrderList | The selected item is casted to an IOrderItem, and changes
        /// to a new screen.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnListItem_Click(object sender, SelectionChangedEventArgs e)
        {
            IOrderItem item = (sender as ListBox).SelectedItem as IOrderItem;

            var screen = (item?.CustomizationScreen as FrameworkElement);
            var orderCon = this.FindAncestor<OrderControl>();

            if (DataContext is Order)
            {
                if (screen != null)
                {
                    screen.DataContext = item;
                    orderCon?.SwapScreen(screen);
                }
            }

            (sender as ListBox).SelectedItem = null;
        }

    }
}
