using eHomeDesigner.Application.Interfaces.POCOs.Devices;
using eHomeDesigner.Application.POCOs.Devices;
using System;
using Xunit;

namespace eHomeDesigner.Application.UnitTests.POCOs.Devices
{
    public class FridgeTest
    {
        private readonly IDevice _fridge = new Fridge(
                                               Guid.NewGuid(),
                                               10000,
                                               10,
                                               100,
                                               "Fridge author"
                                           );

        [Fact]
        public void CanInitFridge_Fridge()
        {
            Assert.NotNull(_fridge);
        }

        [Fact]
        public void Type_CanGetType_Fridge()
        {
            // Act
            string result = _fridge.Type;

            // Assert
            Assert.Equal("Fridge", result);
        }

        [Fact]
        public void CalculateEnergyPerDay_CanCalculateEnergyPerTwoDays_4800()
        {
            // Arrange
            int days = 2;

            // Act
            int result = _fridge.CalculateEnergyPerDay(days);

            // Assert
            Assert.Equal(4800, result);
        }

        [Fact]
        public void CalculateEnergyPrice_CanCalculateEnergyPrice_2500()
        {
            // Arrange
            var energy = 5000;

            // Act
            int result = _fridge.CalculateEnergyPrice(energy);

            // Assert
            Assert.Equal(2500, result);
        }
    }
}
