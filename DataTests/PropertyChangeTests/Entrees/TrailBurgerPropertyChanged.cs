using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using System.ComponentModel;
using CowboyCafe.Data;

namespace CowboyCafe.DataTests.PropertyChangeTests.Entrees
{
    public class TrailBurgerPropertyChanged
    {
        [Fact]
        public void TrailBurgerImplementsINotifyPropertyChanged()
        {
            var trailBurgerOrder = new TrailBurger();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(trailBurgerOrder);
        }

        [Theory]
        [InlineData("Bun")]
        [InlineData("SpecialInstructions")]
        public void ChangingBunInvokesPropertyChanged_Bun_SpecialInstructions(string property)
        {
            var trailBurgerOrder = new TrailBurger();
            Assert.PropertyChanged(trailBurgerOrder, property, () =>
            {
                trailBurgerOrder.Bun = false;
            });
        }

        [Theory]
        [InlineData("Mustard")]
        [InlineData("SpecialInstructions")]
        public void ChangingMustardInvokesPropertyChanged_Mustard_SpecialInstructions(string property)
        {
            var trailBurgerOrder = new TrailBurger();
            Assert.PropertyChanged(trailBurgerOrder, property, () =>
            {
                trailBurgerOrder.Mustard = false;
            });
        }

        [Theory]
        [InlineData("Ketchup")]
        [InlineData("SpecialInstructions")]
        public void ChangingKetchupInvokesPropertyChanged_Ketchup_SpecialInstructions(string property)
        {
            var trailBurgerOrder = new TrailBurger();
            Assert.PropertyChanged(trailBurgerOrder, property, () =>
            {
                trailBurgerOrder.Ketchup = false;
            });
        }

        [Theory]
        [InlineData("Pickle")]
        [InlineData("SpecialInstructions")]
        public void ChangingPickleInvokesPropertyChanged_Pickle_SpecialInstructions(string property)
        {
            var trailBurgerOrder = new TrailBurger();
            Assert.PropertyChanged(trailBurgerOrder, property, () =>
            {
                trailBurgerOrder.Pickle = false;
            });
        }

        [Theory]
        [InlineData("Cheese")]
        [InlineData("SpecialInstructions")]
        public void ChangingCheeseInvokesPropertyChanged_Cheese_SpecialInstructions(string property)
        {
            var trailBurgerOrder = new TrailBurger();
            Assert.PropertyChanged(trailBurgerOrder, property, () =>
            {
                trailBurgerOrder.Cheese = false;
            });
        }
    }
}
