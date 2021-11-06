using System;

namespace eHomeDesigner.Application.Interfaces.POCOs.Furnitures
{
    public interface IFurniture
    {
        Guid Id { get; }
        int Price { get; }
        int SquareMeters { get; }
    }
}
