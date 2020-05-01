using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using CowboyCafe.Data;
using Xunit;

namespace CowboyCafe.DataTests.PropertyChangeTests
{
    public class OrderPropertyTests
    {
        public class MockItem : IOrderItem
        {
            public double Price { get; set; }
            public List<string> SpecialInstructions { get; set; } = new List<string>();
            object IOrderItem.CustomizationScreen { get; set; }

            public string OrderType { get; set; }

            public uint Calories { get; }
        }

        [Fact]
        public void OrderImplementsINotifyPropertyChanged()
        {
            var order = new Order();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(order);

        }

        [Theory]
        [InlineData("Items")]
        public void RemovingOrderInvokesPropertyChanged_PriceAndSubtotal(string property)
        {
            var order = new Order();
            var item = new MockItem();

            Assert.PropertyChanged(order, property, () =>
            {
                order.Remove(item);
            });
        }


        [Theory]
        [InlineData("Items")]
        public void AddingOrderInvokesPropertyChanged_PriceAndSubtotal(string property)
        {
            var order = new Order();
            var item = new MockItem();
            Assert.PropertyChanged(order, property, () =>
            {
                order.Add(item);
            });
        }

    }
}
