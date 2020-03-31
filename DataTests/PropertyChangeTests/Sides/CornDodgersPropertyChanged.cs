using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using System.ComponentModel;
using CowboyCafe.Data;

namespace CowboyCafe.DataTests.PropertyChangeTests.Sides
{
    public class CornDodgersPropertyChanged
    {
        [Fact]
        public void CornDodgersImplementsINotifyPropertyChanged()
        {
            var dodgerOrder = new CornDodgers();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(dodgerOrder);
        }

        [Theory]
        [InlineData("Size")]
        [InlineData("Calories")]
        [InlineData("Price")]
        public void ChangingSizeInvokesPropertyChanged_Size_Calories_Price(string property)
        {
            var dodgerOrder = new CornDodgers();
            Assert.PropertyChanged(dodgerOrder, property, () =>
            {
                dodgerOrder.Size = Size.Large;
            });
        }
    }
}
