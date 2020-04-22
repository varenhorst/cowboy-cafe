using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public static class Menu
    {

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
