using System;

namespace eHomeDesigner.Application.Interfaces.POCOs.Furnitures
{
    public interface IFurniture
    {
        Guid Id { get; }
        string Type { get; }
        int Price { get; }
        int SquareMeters { get; }
    }
}
