using eHomeDesigner.Application.Interfaces.POCOs.Devices;
using eHomeDesigner.Application.Interfaces.POCOs.Furnitures;
using eHomeDesigner.Application.Interfaces.POCOs.Rooms;
using eHomeDesigner.Application.POCOs.Devices;
using eHomeDesigner.Application.POCOs.Furnitures;
using System;
using System.Collections.Generic;
using Xunit;

namespace eHomeDesigner.Application.UnitTests.POCOs.Rooms
{
    public class RoomTest : IDisposable
    {
        private Room _room = new DefaultRoom(Guid.NewGuid(), 10000);
        private static Guid _furnitureId = Guid.NewGuid();
        private static Guid _deviceId = Guid.NewGuid();
        private IFurniture _furniture = new Sofa(_furnitureId, 1000, 100);
        private IDevice _device = new TV(_deviceId, 10000, 10, 10, "Some author");

        public RoomTest()
        {
            _room.AddFurniture(_furniture);
            _room.AddDevice(_device);
        }

        [Fact]
        public void GetDevices_CanGetDevices_Devices()
        {
            // Act
            IReadOnlyCollection<IDevice> result = _room.GetDevices();

            // Assert
            Assert.NotNull(result);
            Assert.Equal(1, result.Count);
        }

        [Fact]
        public void GetFurnitures_CanGetFurnitures_Furnitures()
        {
            // Act
            IReadOnlyCollection<IFurniture> result = _room.GetFurnitures();

            // Assert
            Assert.NotNull(result);
            Assert.Equal(1, result.Count);
        }

        [Fact]
        public void AddDevice_CanAddDevice_NotException()
        {
            // Act
            Exception exception = Record.Exception(() => _room.AddDevice(_device));

            // Assert
            Assert.Null(exception);
        }

        [Fact]
        public void AddFurniture_CanAddFurniture_NotException()
        {
            // Act
            Exception exception = Record.Exception(() => _room.AddFurniture(_furniture));

            // Assert
            Assert.Null(exception);
        }

        [Fact]
        public void DeleteDevice_CanDeleteDevice_NotException()
        {
            // Act
            Exception exception = Record.Exception(() => _room.DeleteDevice(Guid.NewGuid()));

            // Assert
            Assert.Null(exception);
        }

        [Fact]
        public void DeleteFurniture_CanDeleteFurniture_NotException()
        {
            // Act
            Exception exception = Record.Exception(() => _room.DeleteFurniture(Guid.NewGuid()));

            // Assert
            Assert.Null(exception);
        }

        [Fact]
        public void CalculateEnergyPerDay_CanCalculateEnergyPerDay_Energy()
        {
            // Arrange
            _room.AddDevice(new Computer(Guid.NewGuid(), 1000, 10, 20, "Some author"));

            // Act
            int result = _room.CalculateEnergyPerDay();

            // Assert
            Assert.Equal(720, result);
        }

        [Fact]
        public void CalculatePrice_CanCalculatePrice_Price()
        {
            // Act
            int result = _room.CalculatePrice();

            // Assert
            Assert.Equal(11000, result);
        }

        [Fact]
        public void Save_CanSaveRoom_NotException()
        {
            // Act
            Exception exception = Record.Exception(() => _room.Save());

            // Assert
            Assert.Null(exception);
        }

        public void Dispose()
        {
            _room.DeleteFurniture(_furnitureId);
            _room.DeleteDevice(_deviceId);
        }
    }
}
