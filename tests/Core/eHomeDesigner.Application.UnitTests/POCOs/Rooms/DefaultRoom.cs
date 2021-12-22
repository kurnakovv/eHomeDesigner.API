using eHomeDesigner.Application.Interfaces.POCOs.Devices;
using eHomeDesigner.Application.Interfaces.POCOs.Furnitures;
using eHomeDesigner.Application.Interfaces.POCOs.Rooms;
using eHomeDesigner.Application.Interfaces.Repositories;
using System;

namespace eHomeDesigner.Application.UnitTests.POCOs.Rooms;

/// <summary>
/// Default room for testing abstract Room.
/// </summary>
internal class DefaultRoom : BaseRoom
{
    public DefaultRoom(
               Guid customerId,
               int squareMeters,
               IFurnitureRepository<BaseFurniture> furnitureRepository,
               IDeviceRepository<BaseDevice> deviceRepository
           ) : base(customerId, squareMeters, furnitureRepository, deviceRepository) { }

    public override string Type => throw new NotImplementedException();
}
