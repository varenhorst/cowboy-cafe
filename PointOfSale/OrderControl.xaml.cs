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
            AddTrailBurgerButton.Click += OnAddTrailBurgerButtonClicked;
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
            OrderListView.Items.Add(new TrailBurger().ToString());
        }

        void OnAddAngryChickenClicked(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new AngryChicken().ToString());
        }

        void OnAddDakotaDoubleBurgerClicked(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new DakotaDoubleBurger().ToString());
        }

        void OnAddRustlersRibsClicked(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new RustlersRibs().ToString());
        }

        void OnAddCowpokeChiliClicked(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new CowpokeChili().ToString());
        }

        void OnAddPecosPulledPorkClicked(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new PecosPulledPork().ToString());
        }

        void OnAddTexasTripleBurgerClicked(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new TexasTripleBurger().ToString());
        }

        void OnAddJerkedSodaClicked(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new JerkedSoda().ToString());
        }

        void OnAddWaterClicked(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new Water().ToString());
        }

        void OnAddCowboyCoffeeClicked(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new CowboyCoffee().ToString());
        }

        void OnAddTexasTeaClicked(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new TexasTea().ToString());
        }

        void OnAddChiliCheeseFries(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new ChiliCheeseFries().ToString());
        }
        void OnAddCornDodgersClicked(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new CornDodgers().ToString());
        }
        void OnAddPanDeCampoClicked(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new PanDeCampo().ToString());
        }
        void OnAddBakedBeansClicked(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new BakedBeans().ToString());
        }
    }
}
