using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using System.ComponentModel;
using CowboyCafe.Data;

namespace CowboyCafe.DataTests.PropertyChangeTests.Sides
{
    public class ChiliCheeseFriesPropertyChanged
    {
        [Fact]
        public void ChiliCheeseFriesImplementsINotifyPropertyChanged()
        {
            var friesOrder = new ChiliCheeseFries();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(friesOrder);
        }

        [Theory]
        [InlineData("Size")]
        [InlineData("Calories")]
        [InlineData("Price")]
        public void ChangingSizeInvokesPropertyChanged_Size_Calories_Price(string property)
        {
            var friesOrder = new ChiliCheeseFries();
            Assert.PropertyChanged(friesOrder, property, () =>
            {
                friesOrder.Size = Size.Large;
            });
        }
    }
}
