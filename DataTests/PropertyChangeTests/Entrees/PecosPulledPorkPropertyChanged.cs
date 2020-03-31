using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using System.ComponentModel;
using CowboyCafe.Data;

namespace CowboyCafe.DataTests.PropertyChangeTests.Entrees
{
    public class PecosPulledPorkPropertyChanged
    {
        [Fact]
        public void PecosPulledPorkImplementsINotifyPropertyChanged()
        {
            var pulledPorkOrder = new PecosPulledPork();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(pulledPorkOrder);
        }

        [Theory]
        [InlineData("Bread")]
        [InlineData("SpecialInstructions")]
        public void ChangingBreadInvokesPropertyChanged_Bread_SpecialInstructions(string property)
        {
            var pulledPorkOrder = new PecosPulledPork();
            Assert.PropertyChanged(pulledPorkOrder, property, () =>
            {
                pulledPorkOrder.Bread = false;
            });
        }

        [Theory]
        [InlineData("Pickle")]
        [InlineData("SpecialInstructions")]
        public void ChangingPickleInvokesPropertyChanged_Pickle_SpecialInstructions(string property)
        {
            var pulledPorkOrder = new PecosPulledPork();
            Assert.PropertyChanged(pulledPorkOrder, property, () =>
            {
                pulledPorkOrder.Pickle = false;
            });
        }
    }
}
