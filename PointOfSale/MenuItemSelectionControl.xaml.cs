/*
 Author: Alex Varenhorst
 Modified: 3/3/2020 9:50pm
 Class: CIS-400 Object Oriented Design
 Description: Class that represents the Menu Selection control
 */
using CowboyCafe.Data;
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
using CowboyCafe.Extensions;
using PointOfSale;
using PointOfSale.CustomizationScreens;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for MenuItemSelectionControl.xaml
    /// </summary>
    public partial class MenuItemSelectionControl : UserControl
    {
        public MenuItemSelectionControl()
        {
            InitializeComponent(); 
        }

        void AddTrailBurgerButton_Click(object sender, RoutedEventArgs e)
        {
            AddItemAndOpenCustomizationScreen(new TrailBurger(), new TrailBurgerCustomization());
        }

        void AddAngryChicken_Click(object sender, RoutedEventArgs e)
        {
            AddItemAndOpenCustomizationScreen(new AngryChicken(), new AngryChickenCustomization());
        }

        void AddDakotaDoubleBurger_Click(object sender, RoutedEventArgs e)
        {
            AddItemAndOpenCustomizationScreen(new DakotaDoubleBurger(), new DakotaDoubleBurgerCustomization());
        }

        void AddRustlersRibs_Click(object sender, RoutedEventArgs e)
        {
            AddItemAndOpenCustomizationScreen(new RustlersRibs(), new RustlersRibsCustomization());
        }

        void AddCowpokeChiliButton_Click(object sender, RoutedEventArgs e)
        {
            AddItemAndOpenCustomizationScreen(new CowpokeChili(), new CowpokeChiliCustomization());
        }

        void AddPecosPulledPork_Click(object sender, RoutedEventArgs e)
        {
            AddItemAndOpenCustomizationScreen(new PecosPulledPork(), new PecosPulledPorkCustomization());
        }

        void AddTexasTripleBurger_Click(object sender, RoutedEventArgs e)
        {
            AddItemAndOpenCustomizationScreen(new TexasTripleBurger(), new TexasTripleBurgerCustomization());
        }

        void AddJerkedSoda_Click(object sender, RoutedEventArgs e)
        {
            AddItemAndOpenCustomizationScreen(new JerkedSoda(), new JerkedSodaCustomization());
        }

        void AddWater_Click(object sender, RoutedEventArgs e)
        {
            AddItemAndOpenCustomizationScreen(new Water(), new WaterCustomization());
        }

        void AddCowboyCoffee_Click(object sender, RoutedEventArgs e)
        {
            AddItemAndOpenCustomizationScreen(new CowboyCoffee(), new CowboyCoffeeCustomization());
        }

        void AddTexasTea_Click(object sender, RoutedEventArgs e)
        {
           AddItemAndOpenCustomizationScreen(new TexasTea(), new TexasTeaCustomization());
        }

        void AddChiliCheeseFries_Click(object sender, RoutedEventArgs e)
        {
            AddItemAndOpenCustomizationScreen(new ChiliCheeseFries(), new ChiliCheeseFriesCustomization());
        }
        void AddCornDodgers_Click(object sender, RoutedEventArgs e)
        {
            AddItemAndOpenCustomizationScreen(new CornDodgers(), new CornDodgersCustomization());
        }
        void AddPanDeCampo_Click(object sender, RoutedEventArgs e)
        {
            AddItemAndOpenCustomizationScreen(new PanDeCampo(), new PanDeCampoCustomization());
        }
        void AddBakedBeans_Click(object sender, RoutedEventArgs e)
        {
            AddItemAndOpenCustomizationScreen(new BakedBeans(), new BakedBeansCustomization());
        }
        

        /// <summary>
        /// Method for opening the customization screens, with the given context
        /// </summary>
        /// <param name="item"></param>
        /// <param name="screen"></param>
        void AddItemAndOpenCustomizationScreen(IOrderItem item, FrameworkElement screen)
        {
            var orderCon = this.FindAncestor<OrderControl>();

            if (DataContext is Order data)
            {
                data.Add(item);
                screen.DataContext = item;
                orderCon?.SwapScreen(screen);
            }

        }

 
    }
}
