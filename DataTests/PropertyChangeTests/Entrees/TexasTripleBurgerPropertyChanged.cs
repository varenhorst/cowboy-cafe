using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using System.ComponentModel;
using CowboyCafe.Data;

namespace CowboyCafe.DataTests.PropertyChangeTests.Entrees
{
    public class TexasTripleBurgerPropertyChanged
    {
        [Fact]
        public void TexasTripleBurgerImplementsINotifyPropertyChanged()
        {
            var tripleBurgerOrder = new TexasTripleBurger();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(tripleBurgerOrder);
        }

        [Theory]
        [InlineData("Bun")]
        [InlineData("SpecialInstructions")]
        public void ChangingBunInvokesPropertyChanged_Bun_SpecialInstructions(string property)
        {
            var tripleBurgerOrder = new TexasTripleBurger();
            Assert.PropertyChanged(tripleBurgerOrder, property, () =>
            {
                tripleBurgerOrder.Bun = false;
            });
        }

        [Theory]
        [InlineData("Mustard")]
        [InlineData("SpecialInstructions")]
        public void ChangingMustardInvokesPropertyChanged_Mustard_SpecialInstructions(string property)
        {
            var tripleBurgerOrder = new TexasTripleBurger();
            Assert.PropertyChanged(tripleBurgerOrder, property, () =>
            {
                tripleBurgerOrder.Mustard = false;
            });
        }

        [Theory]
        [InlineData("Ketchup")]
        [InlineData("SpecialInstructions")]
        public void ChangingKetchupInvokesPropertyChanged_Ketchup_SpecialInstructions(string property)
        {
            var tripleBurgerOrder = new TexasTripleBurger();
            Assert.PropertyChanged(tripleBurgerOrder, property, () =>
            {
                tripleBurgerOrder.Ketchup = false;
            });
        }

        [Theory]
        [InlineData("Mayo")]
        [InlineData("SpecialInstructions")]
        public void ChangingMayoInvokesPropertyChanged_Mayo_SpecialInstructions(string property)
        {
            var tripleBurgerOrder = new TexasTripleBurger();
            Assert.PropertyChanged(tripleBurgerOrder, property, () =>
            {
                tripleBurgerOrder.Mayo = false;
            });
        }

        [Theory]
        [InlineData("Bacon")]
        [InlineData("SpecialInstructions")]
        public void ChangingBaconInvokesPropertyChanged_Bacon_SpecialInstructions(string property)
        {
            var tripleBurgerOrder = new TexasTripleBurger();
            Assert.PropertyChanged(tripleBurgerOrder, property, () =>
            {
                tripleBurgerOrder.Bacon = false;
            });
        }

        [Theory]
        [InlineData("Egg")]
        [InlineData("SpecialInstructions")]
        public void ChangingEggInvokesPropertyChanged_Egg_SpecialInstructions(string property)
        {
            var tripleBurgerOrder = new TexasTripleBurger();
            Assert.PropertyChanged(tripleBurgerOrder, property, () =>
            {
                tripleBurgerOrder.Egg = false;
            });
        }

        [Theory]
        [InlineData("Lettuce")]
        [InlineData("SpecialInstructions")]
        public void ChangingLettuceInvokesPropertyChanged_Lettuce_SpecialInstructions(string property)
        {
            var tripleBurgerOrder = new TexasTripleBurger();
            Assert.PropertyChanged(tripleBurgerOrder, property, () =>
            {
                tripleBurgerOrder.Lettuce = false;
            });
        }

        [Theory]
        [InlineData("Cheese")]
        [InlineData("SpecialInstructions")]
        public void ChangingCheeseInvokesPropertyChanged_Cheese_SpecialInstructions(string property)
        {
            var tripleBurgerOrder = new TexasTripleBurger();
            Assert.PropertyChanged(tripleBurgerOrder, property, () =>
            {
                tripleBurgerOrder.Cheese = false;
            });
        }

        [Theory]
        [InlineData("Tomato")]
        [InlineData("SpecialInstructions")]
        public void ChangingTomatoInvokesPropertyChanged_Tomato_SpecialInstructions(string property)
        {
            var tripleBurgerOrder = new TexasTripleBurger();
            Assert.PropertyChanged(tripleBurgerOrder, property, () =>
            {
                tripleBurgerOrder.Tomato = false;
            });
        }

        [Theory]
        [InlineData("Pickle")]
        [InlineData("SpecialInstructions")]
        public void ChangingPickleInvokesPropertyChanged_Pickle_SpecialInstructions(string property)
        {
            var tripleBurgerOrder = new TexasTripleBurger();
            Assert.PropertyChanged(tripleBurgerOrder, property, () =>
            {
                tripleBurgerOrder.Pickle = false;
            });
        }
    }
}
