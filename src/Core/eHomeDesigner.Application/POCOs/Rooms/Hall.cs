using eHomeDesigner.Application.Interfaces.POCOs.Devices;
using eHomeDesigner.Application.Interfaces.POCOs.Furnitures;
using eHomeDesigner.Application.Interfaces.POCOs.Rooms;
using eHomeDesigner.Application.Interfaces.Repositories;
using System;

namespace eHomeDesigner.Application.POCOs.Rooms;

public class Hall : BaseRoom
{
    public Hall(
               Guid customerId,
               int squareMeters,
               IFurnitureRepository<BaseFurniture> furnitureRepository,
               IDeviceRepository<BaseDevice> deviceRepository
           ) : base(customerId, squareMeters, furnitureRepository, deviceRepository) { }

    public override string Type => GetType().Name;
}
