using eHomeDesigner.Application.Interfaces.POCOs.Rooms;
using eHomeDesigner.Application.Interfaces.Repositories;

namespace eHomeDesigner.Application.POCOs.Rooms;

public class Hall : Room
{
    public Hall(
               Guid customerId,
               int squareMeters,
               IFurnitureRepository furnitureRepository,
               IDeviceRepository deviceRepository
           ) : base(customerId, squareMeters, furnitureRepository, deviceRepository) { }

    public override string Type => GetType().Name;
}
