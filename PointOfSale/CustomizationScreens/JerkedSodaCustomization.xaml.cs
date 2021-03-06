﻿ using System;
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
using CowboyCafe.Extensions;

namespace PointOfSale.CustomizationScreens
{
    /// <summary>
    /// Interaction logic for JerkedSodaCustomization.xaml
    /// </summary>
    public partial class JerkedSodaCustomization : UserControl
    {
        public JerkedSodaCustomization()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Click event for size
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void AddSize_Click(object sender, RoutedEventArgs e)
        {
            var ancestor = this.FindAncestor<OrderControl>();

            if (ancestor is OrderControl)
            {
                ancestor.ChangeSizeEnum();
            }
        }

        /// <summary>
        /// Click event for flavor
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void AddFlavor_Click(object sender, RoutedEventArgs e)
        {
            var ancestor = this.FindAncestor<OrderControl>();

            if (ancestor is OrderControl)
            {
                ancestor.ChangeFlavorEnum();
            }
        }
    }
}
