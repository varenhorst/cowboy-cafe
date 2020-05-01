using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Xunit;
using CowboyCafe.Data;

namespace CowboyCafe.DataTests.UnitTests
{
    public class MenuTest
    {
        [Fact]
        public void MenuReturnsAllItemsInMenu()
        {
            var items = Menu.CompleteMenu();
            var count = items.Count();

            Assert.Equal(15, count);
        }

        [Theory]
        [InlineData(typeof(AngryChicken))]
        [InlineData(typeof(PecosPulledPork))]
        [InlineData(typeof(DakotaDoubleBurger))]
        [InlineData(typeof(TexasTripleBurger))]
        [InlineData(typeof(RustlersRibs))]
        [InlineData(typeof(TrailBurger))]
        [InlineData(typeof(CowpokeChili))]
        public void EntreesContainAllEntrees(Type entreeList)
        {
            var list = new List<Type>();
            foreach(IOrderItem order in Menu.CompleteMenu())
            {
                list.Add(order.GetType());
            }
            Assert.Contains(entreeList, list);
        }

        [Theory]
        [InlineData(typeof(JerkedSoda))]
        [InlineData(typeof(Water))]
        [InlineData(typeof(CowboyCoffee))]
        [InlineData(typeof(TexasTea))]
        public void DrinksContainAllDrinks(Type drinkList)
        {
            var list = new List<Type>();
            foreach (IOrderItem order in Menu.CompleteMenu())
            {
                list.Add(order.GetType());
            }
            Assert.Contains(drinkList, list);
        }

        [Theory]
        [InlineData(typeof(CornDodgers))]
        [InlineData(typeof(BakedBeans))]
        [InlineData(typeof(PanDeCampo))]
        [InlineData(typeof(ChiliCheeseFries))]
        public void SidesContainAllDrinks(Type sideList)
        {
            var list = new List<Type>();
            foreach (IOrderItem order in Menu.CompleteMenu())
            {
                list.Add(order.GetType());
            }
            Assert.Contains(sideList, list);
        }


        [Theory]
        [InlineData(typeof(Water))]
        [InlineData(typeof(CowpokeChili))]
        [InlineData(typeof(CornDodgers))]
        public void ContainsAllTypes(Type type)
        {
            var items = new List<Type>();

            foreach (IOrderItem order in Menu.CompleteMenu())
            {
                items.Add(order.GetType());
            }

            Assert.Contains(type, items);
        }

        [Theory]
        [InlineData("Corn")]
        [InlineData("Chil")]
        [InlineData("")]
        public void TestSearchContainsSearchString(string term)
        {
            var search = Menu.Search(Menu.CompleteMenu(), term);
            foreach(IOrderItem order in search)
            {
                Assert.Contains(term.ToLower(), order.ToString().ToLower());
            }
        }

        [Theory]
        [InlineData(0,1,3)]
        [InlineData(0,100,15)]
        public void TestSearchFiltersByPrice(double? min, double? max, int count)
        {
            Assert.Equal(count, Menu.FilterByPrice(Menu.CompleteMenu(), max, min).Count());
        }

        [Theory]
        [InlineData(0,10,3)]
        [InlineData(0,300,8)]
        [InlineData(250,500,4)]
        public void SearchFiltersByCalorie(int? min, int? max, int count)
        {
            Assert.Equal(count, Menu.FilterByCalories(Menu.CompleteMenu(), max, min).Count());            
        }

    }
}
