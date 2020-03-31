using System;
using System.Collections.Generic;
using System.Text;
using CowboyCafe.Data;
using Xunit;
using System.ComponentModel;

namespace CowboyCafe.DataTests.PropertyChangeTests.Entrees
{
    public class AngryChickenPropertyChanged
    {
        [Fact]
        public void AngryChickenImplementsINotifyPropertyChanged()
        {
            var angryChickenOrder = new AngryChicken();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(angryChickenOrder);
        }

        [Theory]
        [InlineData("Pickle")]
        [InlineData("SpecialInstructions")]
        public void ChaningPickleInvokesPropertyChanged_Pickle_SpecialInstructions(string property)
        {
            var angryChickenOrder = new AngryChicken();
            Assert.PropertyChanged(angryChickenOrder, property, () =>
            {
                angryChickenOrder.Pickle = false;            
            });
        }

        [Theory]
        [InlineData("Bread")]
        [InlineData("SpecialInstructions")]
        public void ChaningBreadInvokesPropertyChanged_Bread_SpecialInstructions(string property)
        {
            var angryChickenOrder = new AngryChicken();
            Assert.PropertyChanged(angryChickenOrder, property, () =>
            {
                angryChickenOrder.Bread = false;
            });
        }
    }
}
