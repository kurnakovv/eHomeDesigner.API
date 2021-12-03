using eHomeDesigner.Application.Interfaces.POCOs.Devices;
using eHomeDesigner.Application.Interfaces.POCOs.Furnitures;
using System.Collections.Generic;

namespace eHomeDesigner.Application.Interfaces.POCOs.Rooms;

public interface IGetableRoom
{
    IReadOnlyCollection<IFurniture> Furnitures { get; }
    IReadOnlyCollection<IDevice> Devices { get; }
}