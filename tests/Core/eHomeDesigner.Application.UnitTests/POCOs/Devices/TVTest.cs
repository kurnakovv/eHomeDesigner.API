using eHomeDesigner.Application.Interfaces.POCOs.Devices;
using eHomeDesigner.Application.POCOs.Devices;
using System;
using Xunit;

namespace eHomeDesigner.Application.UnitTests.POCOs.Devices
{
    public class TVTest
    {
        private readonly IDevice _tv = new TV(
                                          Guid.NewGuid(),
                                          15000,
                                          3,
                                          70,
                                          "TV author"
                                     );

        [Fact]
        public void CanInitTV_TV()
        {
            Assert.NotNull(_tv);
        }

        [Fact]
        public void CalculateEnergyPerDay_CanCalculateEnergyPerTwoDays_3360()
        {
            // Arrange
            int days = 2;

            // Act
            int result = _tv.CalculateEnergyPerDay(days);

            // Assert
            Assert.Equal(3360, result);
        }

        [Fact]
        public void CalculateEnergyPrice_CanCalculateEnergyPrice_1000()
        {
            // Arrange
            var energy = 5000;

            // Act
            int result = _tv.CalculateEnergyPrice(energy);

            // Assert
            Assert.Equal(1000, result);
        }
    }
}
