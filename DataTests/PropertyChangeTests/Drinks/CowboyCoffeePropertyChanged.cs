using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using System.ComponentModel;
using CowboyCafe.Data;

namespace CowboyCafe.DataTests.PropertyChangeTests.Drinks
{
    public class CowboyCoffeePropertyChanged
    {

        [Fact]
        public void CowboyCoffeeShouldImplementINotidyPropertyChanged()
        {
            var coffeeOrder = new CowboyCoffee();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(coffeeOrder);
        }

        [Theory]
        [InlineData("Size")]
        public void ChangingSizeInvokesPropertyChangedFor_Size_Calories_Price(string property)
        {
            var coffeeOrder = new CowboyCoffee();
            Assert.PropertyChanged(coffeeOrder, property, () =>
            {
                coffeeOrder.Size = Size.Medium;
            });
        }

        [Theory]
        [InlineData("Ice")]
        [InlineData("SpecialInstructions")]
        public void ChangingSizeInvokesPropertyChangedFor_Ice_SpecialInstructions(string property)
        {
            var coffeeOrder = new CowboyCoffee();
            Assert.PropertyChanged(coffeeOrder, property, () =>
            {
                coffeeOrder.Ice = true;
            });
        }

        [Fact]
        public void InvokePropertyChangeOnDecaf()
        {
            var coffeeOrder = new CowboyCoffee();
            Assert.PropertyChanged(coffeeOrder, "Decaf", () =>
            {
                coffeeOrder.Decaf = true;
            });
        }

        [Theory]
        [InlineData("RoomForCream")]
        [InlineData("SpecialInstructions")]
        public void ChangingRoomForCreamInvokesPropertyChanged_Cream_SpecialInstructions(string property)
        {
            var coffeeOrder = new CowboyCoffee();
            Assert.PropertyChanged(coffeeOrder, property, () =>
            {
                coffeeOrder.RoomForCream = true;
            });
        }
    }
}
