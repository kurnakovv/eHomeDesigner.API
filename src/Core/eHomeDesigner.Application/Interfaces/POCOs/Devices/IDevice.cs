using System;

namespace eHomeDesigner.Application.Interfaces.POCOs.Devices
{
    public interface IDevice
    {
        Guid Id { get; }
        string Type { get; }
        int Price { get; }
        int SquareMeters { get; }
        int EnergyPerHour { get; }
        string Author { get; }
        int CalculateEnergyPerDay(int days);
        int CalculateEnergyPrice(int energy);
    }
}
