using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eHomeDesigner.Application.Interfaces.POCOs.Devices;

public abstract class BaseDevice : BasePOCO, IDevice
{
    public abstract Guid Id { get; }

    public abstract string Type { get; }

    public abstract int Price { get; }

    public abstract int SquareMeters { get; }

    public abstract int EnergyPerHour { get; }

    public abstract string Author { get; }

    public abstract int CalculateEnergyPerDay(int days);

    public abstract int CalculateEnergyPrice(int energy);
}
