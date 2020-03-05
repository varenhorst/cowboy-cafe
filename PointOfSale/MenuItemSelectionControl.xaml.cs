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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for MenuItemSelectionControl.xaml
    /// </summary>
    public partial class MenuItemSelectionControl : UserControl
    {
        public MenuItemSelectionControl()
        {
            InitializeComponent(); AddTrailBurgerButton.Click += OnAddTrailBurgerButtonClicked;
            AddAngryChickenButton.Click += OnAddAngryChickenClicked;
            AddDakotaDoubleBurgerButton.Click += OnAddDakotaDoubleBurgerClicked;
            AddRustlersRibsButton.Click += OnAddRustlersRibsClicked;
            AddCowpokeChiliButton.Click += OnAddCowpokeChiliClicked;
            AddPecosPulledPorkButton.Click += OnAddPecosPulledPorkClicked;
            AddTexasTripleBurgerButton.Click += OnAddTexasTripleBurgerClicked;
            AddJerkedSoda.Click += OnAddJerkedSodaClicked;
            AddTexasTea.Click += OnAddTexasTeaClicked;
            AddWater.Click += OnAddWaterClicked;
            AddCowboyCoffee.Click += OnAddCowboyCoffeeClicked;
            AddChiliCheeseFries.Click += OnAddChiliCheeseFries;
            AddCornDodgers.Click += OnAddCornDodgersClicked;
            AddPanDeCampo.Click += OnAddPanDeCampoClicked;
            AddBakedBeans.Click += OnAddBakedBeansClicked;
        }

        void OnAddTrailBurgerButtonClicked(object sender, RoutedEventArgs e)
        {
            if(DataContext is Order data)
            {
               data.Add(new TrailBurger());
            }
        }

        void OnAddAngryChickenClicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data)
            {
                data.Add(new AngryChicken());
            }
        }

        void OnAddDakotaDoubleBurgerClicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data)
            {
                data.Add(new DakotaDoubleBurger());
            }
        }

        void OnAddRustlersRibsClicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data)
            {
                data.Add(new RustlersRibs());
            }
        }

        void OnAddCowpokeChiliClicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data)
            {
                data.Add(new CowpokeChili());
            }
        }

        void OnAddPecosPulledPorkClicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data)
            {
                data.Add(new PecosPulledPork());
            }
        }

        void OnAddTexasTripleBurgerClicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data)
            {
                data.Add(new TexasTripleBurger());
            }
        }

        void OnAddJerkedSodaClicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data)
            {
                data.Add(new JerkedSoda());
            }
        }

        void OnAddWaterClicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data)
            {
                data.Add(new Water());
            }
        }

        void OnAddCowboyCoffeeClicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data)
            {
                data.Add(new CowboyCoffee());
            }
        }

        void OnAddTexasTeaClicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data)
            {
                data.Add(new TexasTea());
            }
        }

        void OnAddChiliCheeseFries(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data)
            {
                data.Add(new ChiliCheeseFries());
            }
        }
        void OnAddCornDodgersClicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data)
            {
                data.Add(new CornDodgers());
            }
        }
        void OnAddPanDeCampoClicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data)
            {
                data.Add(new PanDeCampo());
            }
        }
        void OnAddBakedBeansClicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data)
            {
                data.Add(new BakedBeans());
            }
        }
    }
}
