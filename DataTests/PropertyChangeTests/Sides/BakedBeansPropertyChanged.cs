using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using System.ComponentModel;
using CowboyCafe.Data;

namespace CowboyCafe.DataTests.PropertyChangeTests.Sides
{
    public class BakedBeansPropertyChanged
    {
        [Fact]
        public void BakedBeansImplementsINotifyPropertyChanged()
        {
            var beansOrder = new BakedBeans();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(beansOrder);
        }

        [Theory]
        [InlineData("Size")]
        [InlineData("Calories")]
        [InlineData("Price")]
        public void ChangingSizeInvokesPropertyChanged_Size_Calories_Price(string property)
        {
            var beansOrder = new BakedBeans();
            Assert.PropertyChanged(beansOrder, property, () =>
            {
                beansOrder.Size = Size.Large;
            });
        }
    }
}
