using eHomeDesigner.Application.Interfaces.POCOs.Devices;
using eHomeDesigner.Application.POCOs.Devices;
using System;
using Xunit;

namespace eHomeDesigner.Application.UnitTests.POCOs.Devices
{
    public class ComputerTest
    {
        private readonly IDevice _computer = new Computer(
                                                 Guid.NewGuid(),
                                                 30000,
                                                 2,
                                                 200,
                                                 "Computer author"
                                             );

        [Fact]
        public void CanInitComputer_Computer()
        {
            Assert.NotNull(_computer);
        }

        [Fact]
        public void Type_CanGetType_Computer()
        {
            // Act
            string result = _computer.Type;

            // Assert
            Assert.Equal("Computer", result);
        }

        [Fact]
        public void CalculateEnergyPerDay_CanCalculateEnergyPerTwoDays_9600()
        {
            // Arrange
            int days = 2;

            // Act
            int result = _computer.CalculateEnergyPerDay(days);

            // Assert
            Assert.Equal(9600, result);
        }

        [Fact]
        public void CalculateEnergyPrice_CanCalculateEnergyPrice_1500()
        {
            // Arrange
            var energy = 5000;

            // Act
            int result = _computer.CalculateEnergyPrice(energy);

            // Assert
            Assert.Equal(1500, result);
        }
    }
}
