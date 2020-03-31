using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using System.ComponentModel;
using CowboyCafe.Data;

namespace CowboyCafe.DataTests.PropertyChangeTests.Drinks
{
    public class TexasTeaPropertyChanged
    {
        [Fact]
        public void TexasTeaImplementsINotifyPropertyChanged()
        {
            var texasTeaOrder = new TexasTea();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(texasTeaOrder);
        }

        [Theory]
        [InlineData("Size")]
        public void ChangeSizeInvokesPropertyChanged_Size_Calories_Price(string property)
        {
            var texasTeaOrder = new TexasTea();
            Assert.PropertyChanged(texasTeaOrder, property, () => {
                texasTeaOrder.Size = Size.Large;
            });
        }

        [Theory]
        [InlineData("Lemon")]
        [InlineData("SpecialInstructions")]
        public void ChangeLemonInvokesPropertyChanged_Lemon_SpecialInstructions(string property)
        {
            var texasTeaOrder = new TexasTea();
            Assert.PropertyChanged(texasTeaOrder, property, () => {
                texasTeaOrder.Lemon = true;
            });
        }

        [Theory]
        [InlineData("Ice")]
        [InlineData("SpecialInstructions")]
        public void ChangeIceInvokesPropertyChanged_Ice_SpecialInstructions(string property)
        {
            var texasTeaOrder = new TexasTea();
            Assert.PropertyChanged(texasTeaOrder, property, () => {
                texasTeaOrder.Ice = false;
            });
        }

        [Fact]
        public void ChangeSweetinvokesPropertyChanged_Sweet()
        {
            var texasTeaOrder = new TexasTea();
            Assert.PropertyChanged(texasTeaOrder, "Sweet", () => {
                texasTeaOrder.Sweet = false;
            });
        }
    }
}
