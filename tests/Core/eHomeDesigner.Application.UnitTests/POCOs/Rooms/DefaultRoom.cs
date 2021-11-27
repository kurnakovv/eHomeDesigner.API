using eHomeDesigner.Application.Interfaces.POCOs.Rooms;
using eHomeDesigner.Application.Interfaces.Repositories;
using System;

namespace eHomeDesigner.Application.UnitTests.POCOs.Rooms
{
    /// <summary>
    /// Default room for testing abstract Room.
    /// </summary>
    internal class DefaultRoom : Room
    {
        public DefaultRoom(
                   Guid customerId,
                   int squareMeters,
                   IFurnitureRepository furnitureRepository,
                   IDeviceRepository deviceRepository
               ) : base(customerId, squareMeters, furnitureRepository, deviceRepository) { }

        public override string Type => throw new NotImplementedException();
    }
}
