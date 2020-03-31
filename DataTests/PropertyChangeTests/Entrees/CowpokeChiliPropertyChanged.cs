using System;
using System.Collections.Generic;
using System.Text;
using CowboyCafe.Data;
using System.ComponentModel;
using Xunit;

namespace CowboyCafe.DataTests.PropertyChangeTests.Entrees
{
    public class CowpokeChiliPropertyChanged
    {
        [Fact]
        public void CowpokeChiliImplementsINotifyPropertyChanged()
        {
            var chiliOrder = new CowpokeChili();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(chiliOrder);
        }

        [Theory]
        [InlineData("GreenOnions")]
        [InlineData("SpecialInstructions")]
        public void ChangingGreenOnionsInvokesPropertyChanged_GreenOnions_SpecialInstructions(string property)
        {
            var chiliOrder = new CowpokeChili();
            Assert.PropertyChanged(chiliOrder, property, () =>
            {
                chiliOrder.GreenOnions = false;
            });
        }

        [Theory]
        [InlineData("TortillaStrips")]
        [InlineData("SpecialInstructions")]
        public void ChangingTortillaStripsInvokesPropertyChanged_TortillaStrips_SpecialInstructions(string property)
        {
            var chiliOrder = new CowpokeChili();
            Assert.PropertyChanged(chiliOrder, property, () =>
            {
                chiliOrder.TortillaStrips = false;
            });
        }

        [Theory]
        [InlineData("SourCream")]
        [InlineData("SpecialInstructions")]
        public void ChangingSourCreamInvokesPropertyChanged_SourCream_SpecialInstructions(string property)
        {
            var chiliOrder = new CowpokeChili();
            Assert.PropertyChanged(chiliOrder, property, () =>
            {
                chiliOrder.SourCream = false;
            });
        }

        [Theory]
        [InlineData("Cheese")]
        [InlineData("SpecialInstructions")]
        public void ChangingCheeseInvokesPropertyChanged_Cheese_SpecialInstructions(string property)
        {
            var chiliOrder = new CowpokeChili();
            Assert.PropertyChanged(chiliOrder, property, () =>
            {
                chiliOrder.Cheese = false;
            });
        }

    }
}
