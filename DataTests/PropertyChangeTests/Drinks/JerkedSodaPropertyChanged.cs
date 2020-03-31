using System;
using System.Collections.Generic;
using System.Text;
using CowboyCafe.Data;
using Xunit;
using System.ComponentModel;

namespace CowboyCafe.DataTests.PropertyChangeTests.Drinks
{
    public class JerkedSodaPropertyChanged
    {
        [Fact]
        public void JerkedSodaImplementsINotifyPropertyChanged()
        {
            var sodaOrder = new JerkedSoda();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(sodaOrder);

        }

        [Fact]
        public void ChangeFlavorInvokesPropertyChange_JerkedSoda()
        {
            var sodaOrder = new JerkedSoda();
            Assert.PropertyChanged(sodaOrder, "Flavor", () =>
            {
                sodaOrder.Flavor = SodaFlavor.OrangeSoda;
            });
        }

        [Theory]
        [InlineData("SpecialInstructions")]
        [InlineData("Ice")]
        public void ChangeIceInvokesPropertyChanged_Ice_SpecialInstructions(string property)
        {
            var sodaOrder = new JerkedSoda();
            Assert.PropertyChanged(sodaOrder, property, () =>
            {
                sodaOrder.Ice = false;
            });
        }


        [Theory]
        [InlineData("Size")]
        public void ChangeSizeInvokesPropertyChanged_Size_Price_SpecialInstructions(string property)
        {
            var sodaOrder = new JerkedSoda();
            Assert.PropertyChanged(sodaOrder, property, () =>
            {
                sodaOrder.Size = Size.Large;
            });
        }
    }
}
