using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CowboyCafe.Data
{
    public static class Menu
    {

        public static string[] OrderTypes
        {
            get => new string[] {"Side","Entree","Drink"};
        }
        /// <summary>
        /// Gets all the menu items that exist in cowboy cafe.
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<IOrderItem> CompleteMenu()
        {
            List<IOrderItem> completeMenu = new List<IOrderItem>
            {
                new Water(),
                new JerkedSoda(),
                new TexasTea(),
                new CowboyCoffee(),

                new ChiliCheeseFries(),
                new BakedBeans(),
                new CornDodgers(),
                new PanDeCampo(),

                new AngryChicken(),
                new DakotaDoubleBurger(),
                new TexasTripleBurger(),
                new PecosPulledPork(),
                new RustlersRibs(),
                new TrailBurger(),
                new CowpokeChili()

            };

            return completeMenu;
        }

        public static IEnumerable<IOrderItem> AllSides()
        {
            List<IOrderItem> allsides = new List<IOrderItem>
            {
                new ChiliCheeseFries(),
                new BakedBeans(),
                new CornDodgers(),
                new PanDeCampo()
            };
            return allsides;
        }

        public static IEnumerable<IOrderItem> AllEntrees()
        {
            List<IOrderItem> allentrees = new List<IOrderItem>
            {
                new AngryChicken(),
                new DakotaDoubleBurger(),
                new TexasTripleBurger(),
                new PecosPulledPork(),
                new RustlersRibs(),
                new TrailBurger(),
                new CowpokeChili()
            };
            return allentrees;
        }

        public static IEnumerable<IOrderItem> AllDrinks()
        {
            List<IOrderItem> alldrinks = new List<IOrderItem>
            {
                new Water(),
                new JerkedSoda(),
                new TexasTea(),
                new CowboyCoffee(),
            };
            return alldrinks;
        }

        /// <summary>
        /// Searchs for a given string in the Cowboy cafe menu
        /// </summary>
        /// <param name="orders"></param>
        /// <param name="s"></param>
        /// <returns></returns>
        public static IEnumerable<IOrderItem> Search(IEnumerable<IOrderItem> orders, string s)
        {

            if (s == null)
            {
                return orders;
            }

            if(s != null)
            {
                orders = orders.Where(
                    order => order.ToString() != null && order.ToString().Contains(s, StringComparison.CurrentCultureIgnoreCase)
                );
            }
            return orders;
        }

        /// <summary>
        /// FIlters the search by the order type.
        /// </summary>
        /// <param name="orders"></param>
        /// <param name="menuCategories"></param>
        /// <returns></returns>
        public static IEnumerable<IOrderItem> FilterByCategory(IEnumerable<IOrderItem> orders, IEnumerable<string> menuCategories)
        {
            
            if(menuCategories == null || menuCategories.Count() == 0)
            {
                return orders;
            }

            if(menuCategories != null && menuCategories.Count()!=0)
            {
                orders = orders.Where(
                    order => order.OrderType != null && OrderTypes.Contains(order.OrderType)
                );
            }

            return orders;
        }

        /// <summary>
        /// Filters the search by price.
        /// </summary>
        /// <param name="orders"></param>
        /// <param name="max"></param>
        /// <param name="min"></param>
        /// <returns></returns>
        public static IEnumerable<IOrderItem> FilterByPrice(IEnumerable<IOrderItem> orders, double? max, double? min)
        {
            if (min == null && max == null) return orders;
            
            if(min!=null && max!=null)
            {
                orders = orders.Where(
                    order => order.Price >= min && order.Price <= max
                );
            } 
            else if(max == null && min!=null)
            {
                orders = orders.Where(
                    order => order.Price >= min
                );
            }
            else // max is null
            {
                orders = orders.Where(
                    order => order.Price <= max
                );
            }

            return orders;
        }

        /// <summary>
        /// Filters the search by calories
        /// </summary>
        /// <param name="orders"></param>
        /// <param name="max"></param>
        /// <param name="min"></param>
        /// <returns></returns>
        public static IEnumerable<IOrderItem> FilterByCalories(IEnumerable<IOrderItem> orders, double? max, double? min)
        {
            if(max == null && min == null)
            {
                return orders;
            }

            if (min != null && max != null)
            {
                orders = orders.Where(
                    order => order.Calories >= min && order.Calories <= max
                );
            }
            else if(max == null && min != null)
            {
                orders = orders.Where(
                    order => order.Calories >= min
                );
            }
            else // min is null
            {
                orders = orders.Where(
                    order=> order.Calories <= max
                    );
            }
            return orders;
        }

        public static IEnumerable<IOrderItem> Entrees => AllEntrees();
        public static IEnumerable<IOrderItem> Drinks => AllDrinks();
        public static IEnumerable<IOrderItem> Sides => AllSides();


        /// <summary>
        /// Changes the side of the drink
        /// </summary>
        /// <param name="drink"></param>
        /// <param name="size"></param>
        public static void UpdateDrinkSize(Drink drink, Size size) => drink.Size = size;

        /// <summary>
        /// Changes the size of the side
        /// </summary>
        /// <param name="side"></param>
        /// <param name="size"></param>
        public static void UpdateSideSize(Side side, Size size) => side.Size = size;
    }
}
