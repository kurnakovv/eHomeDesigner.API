using System;

namespace eHomeDesigner.Application.Interfaces.POCOs.Rooms
{
    public interface IRoom : IGetableRoom, IEditableRoom, ICalculableRoom
    {
        Guid Id { get; }
        Guid CustomerId { get; }
        string Type { get; }
        int SquareMeters { get; }
    }
}
