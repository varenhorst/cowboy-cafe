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

            //add functions to the buttons.
            CancelOrder.Click += onRemoveOrder;
            CompleteOrder.Click += onAddOrder;
        }

        //make the datacontext a new order.
        void onRemoveOrder(object sender, RoutedEventArgs e)
        {
            DataContext = new Order();
        }

        //make the datacontext a new order.
        void onAddOrder(object sender, RoutedEventArgs e)
        {
            DataContext = new Order();
        }
    }
}
