using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using System.ComponentModel;
using CowboyCafe.Data;

namespace CowboyCafe.DataTests.PropertyChangeTests.Drinks
{
    public class WaterPropertyChanged
    {
        [Fact]
        public void WaterImplementsINotifyPropertyChanged()
        {
            var waterOrder = new Water();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(waterOrder);
        }

        [Fact]
        public void ChangeSizeInvokesPropertyChanged_Size()
        {
            var waterOrder = new Water();
            Assert.PropertyChanged(waterOrder, "Size", () => {
                waterOrder.Size = Size.Large;
            });
        }

        [Theory]
        [InlineData("Lemon")]
        [InlineData("SpecialInstructions")]
        public void ChangeLemonInvokesPropertyChanged_Lemon_SpecialInstructions(string property)
        {
            var waterOrder = new Water();
            Assert.PropertyChanged(waterOrder, property, () => {
                waterOrder.Lemon = true;
            });
        }

        [Theory]
        [InlineData("Ice")]
        [InlineData("SpecialInstructions")]
        public void ChangeIceInvokesPropertyChanged_Ice_SpecialInstructions(string property)
        {
            var waterOrder = new Water();
            Assert.PropertyChanged(waterOrder, property, () => {
                waterOrder.Ice = false;
            });
        }
    }
}
