using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using System.ComponentModel;
using CowboyCafe.Data;

namespace CowboyCafe.DataTests.PropertyChangeTests.Sides
{
    public class PanDeCampoPropertyChanged
    {
        [Fact]
        public void PanDeCampoImplementsINotifyPropertyChanged()
        {
            var campoOrder = new PanDeCampo();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(campoOrder);
        }

        [Theory]
        [InlineData("Size")]
        [InlineData("Calories")]
        [InlineData("Price")]
        public void ChangingSizeInvokesPropertyChanged_Size_Calories_Price(string property)
        {
            var campoOrder = new PanDeCampo();
            Assert.PropertyChanged(campoOrder, property, () =>
            {
                campoOrder.Size = Size.Large;
            });
        }
    }
}
