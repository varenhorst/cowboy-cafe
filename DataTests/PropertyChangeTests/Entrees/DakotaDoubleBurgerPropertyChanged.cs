using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using System.ComponentModel;
using CowboyCafe.Data;

namespace CowboyCafe.DataTests.PropertyChangeTests.Entrees
{
    public class DakotaDoubleBurgerPropertyChanged
    {
        [Fact]
        public void DakotaDoubleBurgerImplementsINotifyPropertyChanged()
        {
            var dakotaOrder = new DakotaDoubleBurger();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(dakotaOrder);
        }

        [Theory]
        [InlineData("Bun")]
        [InlineData("SpecialInstructions")]
        public void ChangingBunInvokesPropertyChanged_Bun_SpecialInstructions(string property)
        {
            var dakotaOrder = new DakotaDoubleBurger();
            Assert.PropertyChanged(dakotaOrder, property, () =>
            {
                dakotaOrder.Bun = false;
            });
        }

        [Theory]
        [InlineData("Mustard")]
        [InlineData("SpecialInstructions")]
        public void ChangingMustardInvokesPropertyChanged_Mustard_SpecialInstructions(string property)
        {
            var dakotaOrder = new DakotaDoubleBurger();
            Assert.PropertyChanged(dakotaOrder, property, () =>
            {
                dakotaOrder.Mustard = false;
            });
        }

        [Theory]
        [InlineData("Ketchup")]
        [InlineData("SpecialInstructions")]
        public void ChangingKetchupInvokesPropertyChanged_Ketchup_SpecialInstructions(string property)
        {
            var dakotaOrder = new DakotaDoubleBurger();
            Assert.PropertyChanged(dakotaOrder, property, () =>
            {
                dakotaOrder.Ketchup = false;
            });
        }

        [Theory]
        [InlineData("Mayo")]
        [InlineData("SpecialInstructions")]
        public void ChangingMayoInvokesPropertyChanged_Mayo_SpecialInstructions(string property)
        {
            var dakotaOrder = new DakotaDoubleBurger();
            Assert.PropertyChanged(dakotaOrder, property, () =>
            {
                dakotaOrder.Mayo = false;
            });
        }

        [Theory]
        [InlineData("Cheese")]
        [InlineData("SpecialInstructions")]
        public void ChangingCheeseInvokesPropertyChanged_Cheese_SpecialInstructions(string property)
        {
            var dakotaOrder = new DakotaDoubleBurger();
            Assert.PropertyChanged(dakotaOrder, property, () =>
            {
                dakotaOrder.Cheese = false;
            });
        }

        [Theory]
        [InlineData("Lettuce")]
        [InlineData("SpecialInstructions")]
        public void ChangingLettuceInvokesPropertyChanged_Lettuce_SpecialInstructions(string property)
        {
            var dakotaOrder = new DakotaDoubleBurger();
            Assert.PropertyChanged(dakotaOrder, property, () =>
            {
                dakotaOrder.Lettuce = false;
            });
        }

        [Theory]
        [InlineData("Tomato")]
        [InlineData("SpecialInstructions")]
        public void ChangingTomatoInvokesPropertyChanged_Tomato_SpecialInstructions(string property)
        {
            var dakotaOrder = new DakotaDoubleBurger();
            Assert.PropertyChanged(dakotaOrder, property, () =>
            {
                dakotaOrder.Tomato = false;
            });
        }

        [Theory]
        [InlineData("Pickle")]
        [InlineData("SpecialInstructions")]
        public void ChangingPickleInvokesPropertyChanged_Pickle_SpecialInstructions(string property)
        {
            var dakotaOrder = new DakotaDoubleBurger();
            Assert.PropertyChanged(dakotaOrder, property, () =>
            {
                dakotaOrder.Pickle = false;
            });
        }

    }
}
